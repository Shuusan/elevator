using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace Elevator
{
    public partial class FrmElevator : Form
    {
        public FrmElevator()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 使用するフロアの数を設定するもの。
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2022/05/10     作成者　：　Joshua Alviando
        /// </remarks>
        private const int FLOOR_COUNT = 3;

        /// *******************************************************************
        /// サイズパラメータを作成するための定数変数．
        private const int TITLE_BAR_HEIGHT = 40;
        private const int BORDER_WIDTH = 13;
        private const int LEFT_SIDE_PANEL = 300;
        private const int MINIMUM_WIDTH_SIZE = 550;
        private const int MINIMUM_HEIGHT_SIZE = 350;
        private const int ELEVATOR_ROPE_SIZE = 3;
        private const int ELEVATOR_SIZE = 100;
        private const int ELEVATOR_BUTTON_SIZE = 115;


        /// *******************************************************************
        /// エレベータアニメーションを管理するためのパラメータ

        private const int ELEVATOR_SPEED = 1;
        private const int ELEVATOR_DELAY = 15;
        private const int ELEVATOR_DOOR_OPEN = 1500;
        private const int ELEVATOR_LIMIT = 30;

        /// *******************************************************************
        /// エレベーターフォーム1のサイズを変更できるようにするためのパラメータ
        /// <summary>
        /// FrmElevatorの高さ
        /// </summary>
        private int intFormHeight;
        /// <summary>
        /// /// FrmElevatorの横幅
        /// </summary>
        private int intFormWidth;
        private int intLevelPerFloor;
        //*******************************************************************
        /// ロジック・パラメータ
        /// <summary>
        /// タイマー周期が何回回ったかを数える（デバッグの時に使用）
        /// </summary>
        private int intCounterCount = 0;
        /// <summary>
        /// エレベーターが止まっている階層（初期階層=1階）
        /// </summary>
        private int intCurrentFloor = 1;
        private int intDestinationFloor = 1;
        private string direction = "none";
        private int intStopFloor = 0;
        /// <summary>
        /// 次に移動する
        /// </summary>
        private int intCurrentQuery = 0;

        /// <summary>
        /// false : 現在、キュー(queQueryThreading)はない。MoveToFloor関数を直接呼び出すことができる。
        /// true : 現在エレベーターが動いている。次の目的階は待ち行列になる。
        /// </summary>
        private bool blnIsThreading = false;
        /// <summary>
        /// false : デバッグモードオフ
        /// true : デバッグモードオン
        /// </summary>
        private bool blnIsDebungging = true;
        private bool blnStopElevator = false;

        /// <summary>
        /// 押されたボタン名をすべてqueQueryThreadingに入れる
        /// </summary>
        private Queue<int> queQueryThreading = new Queue<int>();
        private Queue<int> queQueryThreadingDummy = new Queue<int>();
        private List<ClsBtnProperty> buttonProperties = new List<ClsBtnProperty>();

        private void CreateBtnProperties()
        {
            buttonProperties.Add(new ClsBtnProperty(1,"none", ClsEnums.ButtonName.firstFloorBtnInside));
            buttonProperties.Add(new ClsBtnProperty(1, "up", ClsEnums.ButtonName.firstFloorUpBtn));
            buttonProperties.Add(new ClsBtnProperty(2, "none", ClsEnums.ButtonName.secondFloorBtnInside));
            buttonProperties.Add(new ClsBtnProperty(2, "up", ClsEnums.ButtonName.secondFloorUpBtn));
            buttonProperties.Add(new ClsBtnProperty(2, "down", ClsEnums.ButtonName.secondFloorDownBtn));
            buttonProperties.Add(new ClsBtnProperty(3, "none", ClsEnums.ButtonName.thirdFloorBtnInside));
            buttonProperties.Add(new ClsBtnProperty(3, "down", ClsEnums.ButtonName.thirdFloorDownBtn));
        }


        private void FrmElevator_Load(object sender, EventArgs e)
        {
            //初期値
            intFormHeight = 500;
            intFormWidth = 1100;

            intLevelPerFloor = intFormHeight / FLOOR_COUNT - TITLE_BAR_HEIGHT / FLOOR_COUNT;
            CreateBtnProperties();

            Size = new Size(1100, 500);

            if (!blnIsDebungging)
            {
                lblQuery.Text = "";
                lblQueuing.Text = "";
                lblCounter.Text = "";
            }

            /// <summary>
            /// エレベーターのアニメーションをマルチプロセスで行うためのもの。
            /// </summary>
            /// <remarks>
            /// Rev1.0.0 2022/05/10     作成者　：　Joshua Alviando
            /// </remarks>

            /// タイマーをSystem.ThreadからSystem.Timerに変更した。
            //System.Threading.Timer t = new System.Threading.Timer(TimerCallback, null, 10, 100);

            System.Timers.Timer tmrQueueHandler = new System.Timers.Timer();
            tmrQueueHandler.Elapsed += new System.Timers.ElapsedEventHandler(TimerCallback);
            tmrQueueHandler.Interval = 100;
            tmrQueueHandler.Enabled = true;
            tmrQueueHandler.AutoReset = true;
            
        }
        

        /// <summary>
        /// 目的の階層を指定する
        /// </summary>
        /// <param name="btn">1階、2階、3階のボタン</param>
        /// <param name="floorDestination">行き先階</param>
        /// <param name="btnName">ボタンのタグ</param>
        private void MoveElevator(Button btn, int floorDestination, int btnName)
        {

            try
            {
                btn.BackColor = Color.LightYellow;
                Refresh();

                MoveWithoutThreading(floorDestination,
                    btnName);
            }
            catch(Exception error)
            {
                Console.WriteLine("Error occur : " + error.Message);
            }

        }

       
        /// <summary>
        /// 目的の階層を指定する
        /// </summary>
        /// <param name="btn">上りボタン下りボタン、</param>
        /// <param name="floorDestination">行き先階</param>
        /// <param name="btnName">ボタンのタグ</param>
        
        private void MoveElevator2(Button btn, int floorDestination, int btnName)
        {
            try
            {
                if (intCurrentFloor == floorDestination && !blnIsThreading)
                {
                    btn.BackColor = Color.LightYellow;
                    Refresh();
                    Thread.Sleep(ELEVATOR_DOOR_OPEN);
                    btn.BackColor = Color.White;
                }
                else
                {
                    MoveElevator(btn, floorDestination, btnName);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occur : " + e.Message);
            }
            
        }

        /// <summary>
        /// 1ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1insideLift_Click(object sender, EventArgs e)
        {
            try
            {
                MoveElevator(button1insideLift, (int)ClsEnums.FloorNumber.firstFloor,
                (int)ClsEnums.ButtonName.firstFloorBtnInside);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur : " + error.Message);
            }

        }

        /// <summary>
        /// ２ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2insideLift_Click(object sender, EventArgs e)
        {
            try
            {
                MoveElevator(button2insideLift, (int)ClsEnums.FloorNumber.secondFloor,
                (int)ClsEnums.ButtonName.secondFloorBtnInside);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur : " + error.Message);
            }
            
        }

        /// <summary>
        /// ３ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3insideLift_Click(object sender, EventArgs e)
        {
            try
            {
                MoveElevator(button3insideLift, (int)ClsEnums.FloorNumber.thirdFloor,
                (int)ClsEnums.ButtonName.thirdFloorBtnInside);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur : " + error.Message);
            }
            
        }

        /// <summary>
        /// ３階の下りボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level3btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                MoveElevator2(level3btnDown, (int)ClsEnums.FloorNumber.thirdFloor,
                (int)ClsEnums.ButtonName.thirdFloorDownBtn);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur : " + error.Message);
            }
            
        }


        /// <summary>
        /// ２階の上りボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level2btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                MoveElevator2(level2btnUp, (int)ClsEnums.FloorNumber.secondFloor,
                (int)ClsEnums.ButtonName.secondFloorUpBtn);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur : " + error.Message);
            }
        }

        /// <summary>
        /// ２階の下りボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level2btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                MoveElevator2(level2btnDown, (int)ClsEnums.FloorNumber.secondFloor,
                (int)ClsEnums.ButtonName.secondFloorDownBtn);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur : " + error.Message);
            }
            
        }

        /// <summary>
        /// 1階の上りボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level1btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                MoveElevator2(level1btnUp, (int)ClsEnums.FloorNumber.firstFloor,
                (int)ClsEnums.ButtonName.firstFloorUpBtn);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur : " + error.Message);
            }
            
        }
        

        /// <summary>
        /// リサイズ可能なフォーム1を実現する関数です。
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2022/05/10     作成者　：　Joshua Alviando
        /// </remarks>
        private void FrmElevator_Resize(object sender, EventArgs e)
        {
            intFormHeight = Size.Height;
            intFormWidth = Size.Width;

            // フォーム（FrmElevator)の画面サイズが下限に収まっているか
            if (intFormHeight < MINIMUM_HEIGHT_SIZE)
            {
                intFormHeight = MINIMUM_HEIGHT_SIZE;
                Size = new Size(intFormWidth, MINIMUM_HEIGHT_SIZE);
            }
            else if (intFormWidth < MINIMUM_WIDTH_SIZE)
            {
                intFormWidth = MINIMUM_WIDTH_SIZE;
                Size = new Size(MINIMUM_WIDTH_SIZE, intFormHeight);
            }

            
            else
            {
                //　画面サイズを調整する
                int perFloorHeight = intFormHeight / FLOOR_COUNT - TITLE_BAR_HEIGHT / FLOOR_COUNT;

                floorPanel.Size = new Size(intFormWidth, intFormHeight);
                elevatorRope.Size = new Size(ELEVATOR_ROPE_SIZE, intFormHeight);
                elevator.Size = new Size(ELEVATOR_SIZE, perFloorHeight);
                insideBtnPanel.Size = new Size(ELEVATOR_BUTTON_SIZE, intFormHeight);

                Panel[] pnlFloorList = { floor1panel, floor2panel, floor3panel };

                // floor(i)panelのサイズを調整する
                for (int i = 1; i <= FLOOR_COUNT; i++)
                {
                    pnlFloorList[i - 1].Height = perFloorHeight;
                }
            }

            
            SetElevator((intFormHeight / FLOOR_COUNT) * (FLOOR_COUNT - intCurrentFloor) - 
                (TITLE_BAR_HEIGHT / FLOOR_COUNT) * (3 - intCurrentFloor));
        }



        /// <summary>
        /// エレベーターを特定の階に移動させるアニメーション
        /// </summary>
        /// <param name="floorNumber"> </param>
        /// <remarks>
        /// Rev1.0.0 2022/05/10     作成者　：　Joshua Alviando
        /// </remarks>
        private void MoveToFloor(int floorNumber)
        {
            int destinationYPosition = ((intFormHeight / FLOOR_COUNT) * (FLOOR_COUNT - floorNumber)
                    - (TITLE_BAR_HEIGHT / FLOOR_COUNT) * (FLOOR_COUNT - floorNumber));
            
            intDestinationFloor = floorNumber;

            switch (floorNumber)
            {
                //最下階
                case 1:
                    while (elevator.Location.Y < destinationYPosition)
                    {
                        
                        IncrementElevator(destinationYPosition);

                    }
                    ArrivedAtDestination(destinationYPosition, floorNumber);
                    break;
                //最上階
                case FLOOR_COUNT:
                    while (elevator.Location.Y > 0)
                    {
                        DecrementElevator(destinationYPosition);

                    }
                    ArrivedAtDestination(destinationYPosition, floorNumber);
                    break;
                // 最上階と最下階の間の階
                default:
                    if (elevator.Location.Y > destinationYPosition)
                    {
                        while (elevator.Location.Y > destinationYPosition)
                        {
                            DecrementElevator(destinationYPosition);
                        }

                    }
                    else
                    {
                        while (elevator.Location.Y < destinationYPosition)
                        {
                            IncrementElevator(destinationYPosition);
                        }
                    }

                    ArrivedAtDestination(destinationYPosition, floorNumber);
                    break;
            }

            
        }

        /// <summary>
        /// 最終行き先に到着した時の処理
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="floor"></param>
        private void ArrivedAtDestination(int destination, int floor)
        {
            SetElevator(destination);
            Thread.Sleep(ELEVATOR_DOOR_OPEN);

            blnIsThreading = false;
            intCurrentFloor = floor;

            if (queQueryThreading.Count == 0)
            {
                TurnOffLight(intCurrentQuery);
                intCurrentQuery = 0;
                RefreshInvoke();
            }
        }


        /// <summary>
        /// スレッド化されていない時にエレベータをキューに入れたりアニメートさせる関数
        /// </summary>
        /// <param name="floorNumber">
        /// 行き先階
        /// </param>
        /// <param name="floorTagNumber">
        /// フォーム 1 のボタンのタグ番号。
        /// </param>
        /// <remarks>
        /// Rev1.0.0 2022/05/10     作成者　：　Joshua Alviando　
        /// </remarks>
        private void MoveWithoutThreading(int floorNumber, int floorTagNumber)
        {
            if (!blnIsThreading && queQueryThreading.Count == 0)
            {
                intCurrentQuery = floorTagNumber;
                blnIsThreading = true;
                Thread t = new Thread(() => MoveToFloor(floorNumber));
                t.Start();
            }
            else
            {
                // ボタンが既に押されている場合、このロジックはボタンが2回目に押されるのを防止します。
                if (queQueryThreading.Contains(floorTagNumber))
                {
                    // 動作なし
                }
                else
                {
                    queQueryThreading.Enqueue(floorTagNumber);
                }
                
            }
        }

        private int ChangeFloorWhenMoving(int elevatorY, bool isIncrement)
        {
            double currentHeight;
            if (isIncrement)
            {
                currentHeight = elevatorY + ELEVATOR_LIMIT;
            }
            else
            {
                currentHeight = elevatorY - ELEVATOR_LIMIT;
            }
            double levelFloor = intLevelPerFloor;


            if (isIncrement)
            {
                return FLOOR_COUNT - (int)Math.Floor(currentHeight / levelFloor);
            }
            else
            {
                return FLOOR_COUNT - (int)Math.Ceiling(currentHeight / levelFloor);
            }

            
        }

        void StopElevator()
        {
            Thread.Sleep(ELEVATOR_DOOR_OPEN);
            Console.WriteLine("Elevator stopping");
            blnStopElevator = false;
            RemoveThisTag(intStopFloor);
            intStopFloor = 0;
        }

        private void IncrementElevator(int destinationHeight)
        {
            
            intCurrentFloor = ChangeFloorWhenMoving(elevator.Location.Y, true);
            direction = "down";

            if(blnStopElevator == true && intStopFloor == intCurrentFloor)
            {
                StopElevator();
                
            }
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => elevator.Location = new Point(elevator.Location.X, 
                    elevator.Location.Y + ELEVATOR_SPEED)));
            }
            else
            {
                elevator.Location = new Point(elevator.Location.X, elevator.Location.Y + ELEVATOR_SPEED);
            }
            Thread.Sleep(ELEVATOR_DELAY);
        }

        private void DecrementElevator(int destinationHeight)
        {
            direction = "up";
            intCurrentFloor = ChangeFloorWhenMoving(elevator.Location.Y, false);

            if (blnStopElevator == true && intStopFloor == intCurrentFloor)
            {
                StopElevator();
            }
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => elevator.Location = new Point(elevator.Location.X, 
                    elevator.Location.Y - ELEVATOR_SPEED)));
            }
            else
            {
                elevator.Location = new Point(elevator.Location.X, elevator.Location.Y - ELEVATOR_SPEED);
            }
            Thread.Sleep(ELEVATOR_DELAY);
        }

        /// <summary>
        /// 画面サイズ変更時にエレベーターの位置を調整する
        /// </summary>
        /// <param name="level"></param>
        private void SetElevator(int level)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => elevator.Location = new Point(elevator.Location.X, level)));
            }
            else
            {
                elevator.Location = new Point(elevator.Location.X, level);
            }
        }


        /// <summary>
        /// この関数は、リボーク関数をより短くするためのものです。
        /// </summary>
        private void RefreshInvoke()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => Refresh()));
            }
            else
            {
                Refresh();
            }
        }


        /// <summary>
        /// 消灯機能
        /// </summary>
        /// <param name="currentQuery">
        /// フォーム 1 のボタンのタグ番号。
        /// </param>
        /// <remarks>
        /// Rev1.0.0 2022/05/10     作成者　：　Joshua Alviando
        /// </remarks>
        private void TurnOffLight(int currentQuery)
        {
            switch (currentQuery)
            {
                
                case (int)ClsEnums.ButtonName.firstFloorBtnInside:
                    button1insideLift.BackColor = Color.White;
                    break;
                case (int)ClsEnums.ButtonName.secondFloorBtnInside:
                    button2insideLift.BackColor = Color.White;
                    break;
                case (int)ClsEnums.ButtonName.thirdFloorBtnInside:
                    button3insideLift.BackColor = Color.White;
                    break;
                case (int)ClsEnums.ButtonName.thirdFloorDownBtn :
                    level3btnDown.BackColor = Color.White;
                    break;
                case (int)ClsEnums.ButtonName.secondFloorUpBtn:
                    level2btnUp.BackColor = Color.White;
                    break;
                case (int)ClsEnums.ButtonName.secondFloorDownBtn:
                    level2btnDown.BackColor = Color.White;
                    break;
                case (int)ClsEnums.ButtonName.firstFloorUpBtn:
                    level1btnUp.BackColor = Color.White;
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// 関数でスレッドを管理する。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Rev1.0.0 2022/05/10     作成者　：　Joshua Alviando
        /// </remarks>
        /// 


        private void RemoveThisTag(int tag)
        {
            queQueryThreadingDummy.Clear();
            foreach (int i in queQueryThreading.ToArray())
            {
                if(i!= tag)
                {
                    queQueryThreadingDummy.Enqueue(i);
                }
            }


            queQueryThreading.Clear();
            queQueryThreading = queQueryThreadingDummy;
            //Console.WriteLine(string.Join(",", queQueryThreading.ToArray()));
            //Console.WriteLine(string.Join(",", queQueryThreadingDummy.ToArray()));
        }

        private void TimerCallback(object source, System.Timers.ElapsedEventArgs e)
        {

            intCounterCount = intCounterCount + 1;
            

            //if (blnStopElevator)
            //{
            //    Thread.Sleep(500);
            //    blnStopElevator = false;
            //}



            ///以下のコードはデバッグ用です。///
            if (blnIsDebungging)
            {
                DebuggingMode();
            }
            ///以上のコードはデバッグ用です。///



            int[] arr = queQueryThreading.ToArray();

            
            if (arr.Length > 0)
            {
                
                for (int i = 0; i<arr.Length;i++)
                {
                    foreach (ClsBtnProperty btn in buttonProperties)
                    {
                        
                        if ((int)btn.enumTag == arr[i])
                        {
                            
                            if (intCurrentFloor < btn.floorDestination && btn.direction == direction || btn.direction == "none")
                            {
                                blnStopElevator = true;
                                intStopFloor = btn.floorDestination;
                            }
                            else if (intCurrentFloor > btn.floorDestination && btn.direction == direction || btn.direction == "none")
                            {
                                blnStopElevator = true;
                                intStopFloor = btn.floorDestination;
                            }
                        }
                       
                    }
                }
            }
            

            



            if (intCurrentFloor < intDestinationFloor)
            {

                this.Invoke(new Action(() => lblElevatorDirection.Text = "Elevator direction is currently heading : ↑"));

            }
            else
            {
                this.Invoke(new Action(() => lblElevatorDirection.Text = "Elevator direction is currently heading : ↓"));
            }



            if (!blnIsThreading && queQueryThreading.Count != 0)
            {
                TurnOffLight(intCurrentQuery);

                int dequeue = queQueryThreading.Dequeue();
                intCurrentQuery = dequeue;

                
                
                if (dequeue == 1)
                {
                    blnIsThreading = true;
                    Thread t = new Thread(() => MoveToFloor((int)ClsEnums.FloorNumber.firstFloor));
                    t.Start();
                }
                else if (dequeue == 2)
                {
                    blnIsThreading = true;
                    Thread t = new Thread(() => MoveToFloor((int)ClsEnums.FloorNumber.secondFloor));
                    t.Start();
                }
                else if (dequeue == 3)
                {
                    blnIsThreading = true;
                    Thread t = new Thread(() => MoveToFloor((int)ClsEnums.FloorNumber.thirdFloor));
                    t.Start();
                }
                else if (dequeue == 4)
                {
                    blnIsThreading = true;
                    Thread t = new Thread(() => MoveToFloor((int)ClsEnums.FloorNumber.thirdFloor));
                    t.Start();
                }
                else if (dequeue == 5)
                {
                    blnIsThreading = true;
                    Thread t = new Thread(() => MoveToFloor((int)ClsEnums.FloorNumber.secondFloor));
                    t.Start();
                }
                else if (dequeue == 6)
                {
                    blnIsThreading = true;
                    Thread t = new Thread(() => MoveToFloor((int)ClsEnums.FloorNumber.secondFloor));
                    t.Start();
                }
                else
                {
                    blnIsThreading = true;
                    Thread t = new Thread(() => MoveToFloor((int)ClsEnums.FloorNumber.firstFloor));
                    t.Start();
                }
            }

        }


        /// <summary>
        /// デバッグ画面を実行するための関数
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2022/05/11     作成者　：　Joshua Alviando
        /// </remarks>
        private void DebuggingMode()
        {
            //タイマー周期が何度回ったか
            this.Invoke(new Action(() => lblCounter.Text = intCounterCount.ToString()));
            //this.Invoke(new Action(() => lblCounter.Text = ""));
            if (this.InvokeRequired)
            {

                if (queQueryThreading.Count == 0)
                {
                    this.Invoke(new Action(() => lblQuery.Text = "No Query"));
                }
                else
                {
                    string combindedString = string.Join(",", queQueryThreading.ToArray());
                    this.Invoke(new Action(() => lblQuery.Text = combindedString));
                }

                if (intCurrentQuery == 0)
                {
                    this.Invoke(new Action(() => lblQuery.Text = "No Query"));
                }
                else
                {
                    this.Invoke(new Action(() => lblQueuing.Text = intCurrentQuery.ToString()));
                }
            }
            else
            {
                if (queQueryThreading.Count == 0)
                {
                    lblQuery.Text = "No Query";
                }
                else
                {
                    string combindedString = string.Join(",", queQueryThreading.ToArray());
                    lblQuery.Text = combindedString;
                }
                if (intCurrentQuery == 0)
                {
                    lblQuery.Text = "No Query";
                }
                else
                {
                    lblQueuing.Text = intCurrentQuery.ToString();
                }
            }
        }
        
    }
}