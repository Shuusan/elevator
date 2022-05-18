namespace Elevator
{
    partial class FrmElevator
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.floor3panel = new System.Windows.Forms.Panel();
            this.doorRight3floor = new System.Windows.Forms.Panel();
            this.doorLeft3floor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.level3btnDown = new System.Windows.Forms.Button();
            this.lblElevatorDirection3floor = new System.Windows.Forms.Label();
            this.elevator = new System.Windows.Forms.Panel();
            this.floor2panel = new System.Windows.Forms.Panel();
            this.doorRight2floor = new System.Windows.Forms.Panel();
            this.doorLeft2floor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblElevatorDirection2floor = new System.Windows.Forms.Label();
            this.level2btnUp = new System.Windows.Forms.Button();
            this.level2btnDown = new System.Windows.Forms.Button();
            this.floor1panel = new System.Windows.Forms.Panel();
            this.doorRight1floor = new System.Windows.Forms.Panel();
            this.doorLeft1floor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblElevatorDirection1floor = new System.Windows.Forms.Label();
            this.level1btnUp = new System.Windows.Forms.Button();
            this.elevatorRope = new System.Windows.Forms.Panel();
            this.insideBtnPanel = new System.Windows.Forms.Panel();
            this.lblElevatorDirection = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblQueuing = new System.Windows.Forms.Label();
            this.lblQuery = new System.Windows.Forms.Label();
            this.button3insideLift = new System.Windows.Forms.Button();
            this.button2insideLift = new System.Windows.Forms.Button();
            this.button1insideLift = new System.Windows.Forms.Button();
            this.floorPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.floor3panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.floor2panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.floor1panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.insideBtnPanel.SuspendLayout();
            this.floorPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // floor3panel
            // 
            this.floor3panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.floor3panel.Controls.Add(this.panel6);
            this.floor3panel.Controls.Add(this.panel1);
            this.floor3panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.floor3panel.Location = new System.Drawing.Point(0, 0);
            this.floor3panel.Name = "floor3panel";
            this.floor3panel.Size = new System.Drawing.Size(772, 150);
            this.floor3panel.TabIndex = 1;
            // 
            // doorRight3floor
            // 
            this.doorRight3floor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.doorRight3floor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doorRight3floor.Dock = System.Windows.Forms.DockStyle.Right;
            this.doorRight3floor.Location = new System.Drawing.Point(62, 0);
            this.doorRight3floor.Name = "doorRight3floor";
            this.doorRight3floor.Size = new System.Drawing.Size(58, 148);
            this.doorRight3floor.TabIndex = 3;
            // 
            // doorLeft3floor
            // 
            this.doorLeft3floor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.doorLeft3floor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doorLeft3floor.Dock = System.Windows.Forms.DockStyle.Left;
            this.doorLeft3floor.Location = new System.Drawing.Point(0, 0);
            this.doorLeft3floor.Name = "doorLeft3floor";
            this.doorLeft3floor.Size = new System.Drawing.Size(62, 148);
            this.doorLeft3floor.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.level3btnDown);
            this.panel1.Controls.Add(this.lblElevatorDirection3floor);
            this.panel1.Location = new System.Drawing.Point(137, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 150);
            this.panel1.TabIndex = 1;
            // 
            // level3btnDown
            // 
            this.level3btnDown.BackColor = System.Drawing.Color.White;
            this.level3btnDown.Location = new System.Drawing.Point(13, 92);
            this.level3btnDown.Name = "level3btnDown";
            this.level3btnDown.Size = new System.Drawing.Size(50, 49);
            this.level3btnDown.TabIndex = 0;
            this.level3btnDown.Text = "↓";
            this.level3btnDown.UseVisualStyleBackColor = false;
            this.level3btnDown.Click += new System.EventHandler(this.Level3btnDown_Click);
            // 
            // lblElevatorDirection3floor
            // 
            this.lblElevatorDirection3floor.AutoSize = true;
            this.lblElevatorDirection3floor.BackColor = System.Drawing.Color.Black;
            this.lblElevatorDirection3floor.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.lblElevatorDirection3floor.ForeColor = System.Drawing.Color.Yellow;
            this.lblElevatorDirection3floor.Location = new System.Drawing.Point(9, 45);
            this.lblElevatorDirection3floor.Name = "lblElevatorDirection3floor";
            this.lblElevatorDirection3floor.Size = new System.Drawing.Size(60, 24);
            this.lblElevatorDirection3floor.TabIndex = 1;
            this.lblElevatorDirection3floor.Text = " 3 ↓";
            // 
            // elevator
            // 
            this.elevator.BackColor = System.Drawing.SystemColors.Info;
            this.elevator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elevator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.elevator.Location = new System.Drawing.Point(163, 0);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(120, 150);
            this.elevator.TabIndex = 1;
            // 
            // floor2panel
            // 
            this.floor2panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.floor2panel.Controls.Add(this.panel5);
            this.floor2panel.Controls.Add(this.panel2);
            this.floor2panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.floor2panel.Location = new System.Drawing.Point(0, 150);
            this.floor2panel.Name = "floor2panel";
            this.floor2panel.Size = new System.Drawing.Size(772, 150);
            this.floor2panel.TabIndex = 2;
            // 
            // doorRight2floor
            // 
            this.doorRight2floor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.doorRight2floor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doorRight2floor.Dock = System.Windows.Forms.DockStyle.Right;
            this.doorRight2floor.Location = new System.Drawing.Point(62, 0);
            this.doorRight2floor.Name = "doorRight2floor";
            this.doorRight2floor.Size = new System.Drawing.Size(58, 148);
            this.doorRight2floor.TabIndex = 3;
            // 
            // doorLeft2floor
            // 
            this.doorLeft2floor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.doorLeft2floor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doorLeft2floor.Dock = System.Windows.Forms.DockStyle.Left;
            this.doorLeft2floor.Location = new System.Drawing.Point(0, 0);
            this.doorLeft2floor.Name = "doorLeft2floor";
            this.doorLeft2floor.Size = new System.Drawing.Size(62, 148);
            this.doorLeft2floor.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lblElevatorDirection2floor);
            this.panel2.Controls.Add(this.level2btnUp);
            this.panel2.Controls.Add(this.level2btnDown);
            this.panel2.Location = new System.Drawing.Point(137, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 150);
            this.panel2.TabIndex = 1;
            // 
            // lblElevatorDirection2floor
            // 
            this.lblElevatorDirection2floor.AutoSize = true;
            this.lblElevatorDirection2floor.BackColor = System.Drawing.Color.Black;
            this.lblElevatorDirection2floor.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.lblElevatorDirection2floor.ForeColor = System.Drawing.Color.Yellow;
            this.lblElevatorDirection2floor.Location = new System.Drawing.Point(7, 15);
            this.lblElevatorDirection2floor.Name = "lblElevatorDirection2floor";
            this.lblElevatorDirection2floor.Size = new System.Drawing.Size(60, 24);
            this.lblElevatorDirection2floor.TabIndex = 2;
            this.lblElevatorDirection2floor.Text = " 3 ↓";
            // 
            // level2btnUp
            // 
            this.level2btnUp.BackColor = System.Drawing.Color.White;
            this.level2btnUp.Location = new System.Drawing.Point(13, 51);
            this.level2btnUp.Name = "level2btnUp";
            this.level2btnUp.Size = new System.Drawing.Size(50, 49);
            this.level2btnUp.TabIndex = 0;
            this.level2btnUp.Text = "↑";
            this.level2btnUp.UseVisualStyleBackColor = false;
            this.level2btnUp.Click += new System.EventHandler(this.Level2btnUp_Click);
            // 
            // level2btnDown
            // 
            this.level2btnDown.BackColor = System.Drawing.Color.White;
            this.level2btnDown.Location = new System.Drawing.Point(13, 100);
            this.level2btnDown.Name = "level2btnDown";
            this.level2btnDown.Size = new System.Drawing.Size(50, 49);
            this.level2btnDown.TabIndex = 0;
            this.level2btnDown.Text = "↓";
            this.level2btnDown.UseVisualStyleBackColor = false;
            this.level2btnDown.Click += new System.EventHandler(this.Level2btnDown_Click);
            // 
            // floor1panel
            // 
            this.floor1panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.floor1panel.Controls.Add(this.panel4);
            this.floor1panel.Controls.Add(this.panel3);
            this.floor1panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.floor1panel.Location = new System.Drawing.Point(0, 300);
            this.floor1panel.Name = "floor1panel";
            this.floor1panel.Size = new System.Drawing.Size(772, 150);
            this.floor1panel.TabIndex = 3;
            // 
            // doorRight1floor
            // 
            this.doorRight1floor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.doorRight1floor.Dock = System.Windows.Forms.DockStyle.Right;
            this.doorRight1floor.Location = new System.Drawing.Point(62, 0);
            this.doorRight1floor.Name = "doorRight1floor";
            this.doorRight1floor.Size = new System.Drawing.Size(58, 148);
            this.doorRight1floor.TabIndex = 4;
            // 
            // doorLeft1floor
            // 
            this.doorLeft1floor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.doorLeft1floor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doorLeft1floor.Dock = System.Windows.Forms.DockStyle.Left;
            this.doorLeft1floor.Location = new System.Drawing.Point(0, 0);
            this.doorLeft1floor.Name = "doorLeft1floor";
            this.doorLeft1floor.Size = new System.Drawing.Size(62, 148);
            this.doorLeft1floor.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.lblElevatorDirection1floor);
            this.panel3.Controls.Add(this.level1btnUp);
            this.panel3.Location = new System.Drawing.Point(137, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 148);
            this.panel3.TabIndex = 2;
            // 
            // lblElevatorDirection1floor
            // 
            this.lblElevatorDirection1floor.AutoSize = true;
            this.lblElevatorDirection1floor.BackColor = System.Drawing.Color.Black;
            this.lblElevatorDirection1floor.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.lblElevatorDirection1floor.ForeColor = System.Drawing.Color.Yellow;
            this.lblElevatorDirection1floor.Location = new System.Drawing.Point(8, 28);
            this.lblElevatorDirection1floor.Name = "lblElevatorDirection1floor";
            this.lblElevatorDirection1floor.Size = new System.Drawing.Size(60, 24);
            this.lblElevatorDirection1floor.TabIndex = 3;
            this.lblElevatorDirection1floor.Text = " 3 ↓";
            // 
            // level1btnUp
            // 
            this.level1btnUp.BackColor = System.Drawing.Color.White;
            this.level1btnUp.Location = new System.Drawing.Point(12, 89);
            this.level1btnUp.Name = "level1btnUp";
            this.level1btnUp.Size = new System.Drawing.Size(50, 49);
            this.level1btnUp.TabIndex = 0;
            this.level1btnUp.Text = "↑";
            this.level1btnUp.UseVisualStyleBackColor = false;
            this.level1btnUp.Click += new System.EventHandler(this.Level1btnUp_Click);
            // 
            // elevatorRope
            // 
            this.elevatorRope.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.elevatorRope.Location = new System.Drawing.Point(226, 0);
            this.elevatorRope.Name = "elevatorRope";
            this.elevatorRope.Size = new System.Drawing.Size(3, 450);
            this.elevatorRope.TabIndex = 0;
            // 
            // insideBtnPanel
            // 
            this.insideBtnPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insideBtnPanel.Controls.Add(this.lblElevatorDirection);
            this.insideBtnPanel.Controls.Add(this.lblCounter);
            this.insideBtnPanel.Controls.Add(this.lblQueuing);
            this.insideBtnPanel.Controls.Add(this.lblQuery);
            this.insideBtnPanel.Controls.Add(this.button3insideLift);
            this.insideBtnPanel.Controls.Add(this.button2insideLift);
            this.insideBtnPanel.Controls.Add(this.button1insideLift);
            this.insideBtnPanel.Location = new System.Drawing.Point(1, 0);
            this.insideBtnPanel.Name = "insideBtnPanel";
            this.insideBtnPanel.Size = new System.Drawing.Size(150, 450);
            this.insideBtnPanel.TabIndex = 0;
            // 
            // lblElevatorDirection
            // 
            this.lblElevatorDirection.AutoSize = true;
            this.lblElevatorDirection.BackColor = System.Drawing.Color.Black;
            this.lblElevatorDirection.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.lblElevatorDirection.ForeColor = System.Drawing.Color.Yellow;
            this.lblElevatorDirection.Location = new System.Drawing.Point(43, 9);
            this.lblElevatorDirection.Name = "lblElevatorDirection";
            this.lblElevatorDirection.Size = new System.Drawing.Size(60, 24);
            this.lblElevatorDirection.TabIndex = 4;
            this.lblElevatorDirection.Text = " 3 ↓";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(13, 491);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(59, 15);
            this.lblCounter.TabIndex = 3;
            this.lblCounter.Text = "Counter";
            // 
            // lblQueuing
            // 
            this.lblQueuing.AutoSize = true;
            this.lblQueuing.Location = new System.Drawing.Point(15, 579);
            this.lblQueuing.Name = "lblQueuing";
            this.lblQueuing.Size = new System.Drawing.Size(108, 15);
            this.lblQueuing.TabIndex = 2;
            this.lblQueuing.Text = "Current Query :";
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQuery.Location = new System.Drawing.Point(12, 532);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(65, 17);
            this.lblQuery.TabIndex = 1;
            this.lblQuery.Text = "Query : ";
            // 
            // button3insideLift
            // 
            this.button3insideLift.BackColor = System.Drawing.Color.White;
            this.button3insideLift.Location = new System.Drawing.Point(33, 47);
            this.button3insideLift.Name = "button3insideLift";
            this.button3insideLift.Size = new System.Drawing.Size(75, 75);
            this.button3insideLift.TabIndex = 0;
            this.button3insideLift.Text = "3";
            this.button3insideLift.UseVisualStyleBackColor = false;
            this.button3insideLift.Click += new System.EventHandler(this.Button3insideLift_Click);
            // 
            // button2insideLift
            // 
            this.button2insideLift.BackColor = System.Drawing.Color.White;
            this.button2insideLift.Location = new System.Drawing.Point(33, 177);
            this.button2insideLift.Name = "button2insideLift";
            this.button2insideLift.Size = new System.Drawing.Size(75, 75);
            this.button2insideLift.TabIndex = 0;
            this.button2insideLift.Text = "2";
            this.button2insideLift.UseVisualStyleBackColor = false;
            this.button2insideLift.Click += new System.EventHandler(this.Button2insideLift_Click);
            // 
            // button1insideLift
            // 
            this.button1insideLift.BackColor = System.Drawing.Color.White;
            this.button1insideLift.Location = new System.Drawing.Point(33, 309);
            this.button1insideLift.Name = "button1insideLift";
            this.button1insideLift.Size = new System.Drawing.Size(75, 75);
            this.button1insideLift.TabIndex = 0;
            this.button1insideLift.Text = "1";
            this.button1insideLift.UseVisualStyleBackColor = false;
            this.button1insideLift.Click += new System.EventHandler(this.Button1insideLift_Click);
            // 
            // floorPanel
            // 
            this.floorPanel.Controls.Add(this.floor1panel);
            this.floorPanel.Controls.Add(this.floor2panel);
            this.floorPanel.Controls.Add(this.floor3panel);
            this.floorPanel.Location = new System.Drawing.Point(307, 0);
            this.floorPanel.Name = "floorPanel";
            this.floorPanel.Size = new System.Drawing.Size(772, 450);
            this.floorPanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.doorLeft1floor);
            this.panel4.Controls.Add(this.doorRight1floor);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 148);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.doorLeft2floor);
            this.panel5.Controls.Add(this.doorRight2floor);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 148);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.doorLeft3floor);
            this.panel6.Controls.Add(this.doorRight3floor);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 148);
            this.panel6.TabIndex = 4;
            // 
            // FrmElevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1082, 451);
            this.Controls.Add(this.elevator);
            this.Controls.Add(this.elevatorRope);
            this.Controls.Add(this.floorPanel);
            this.Controls.Add(this.insideBtnPanel);
            this.Name = "FrmElevator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.FrmElevator_Load);
            this.Resize += new System.EventHandler(this.FrmElevator_Resize);
            this.floor3panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.floor2panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.floor1panel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.insideBtnPanel.ResumeLayout(false);
            this.insideBtnPanel.PerformLayout();
            this.floorPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel floor3panel;
        private System.Windows.Forms.Panel floor2panel;
        private System.Windows.Forms.Panel floor1panel;
        private System.Windows.Forms.Panel elevator;
        private System.Windows.Forms.Panel elevatorRope;
        private System.Windows.Forms.Button level3btnDown;
        private System.Windows.Forms.Button level2btnDown;
        private System.Windows.Forms.Button level2btnUp;
        private System.Windows.Forms.Button level1btnUp;
        private System.Windows.Forms.Panel insideBtnPanel;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblQueuing;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Button button3insideLift;
        private System.Windows.Forms.Button button2insideLift;
        private System.Windows.Forms.Button button1insideLift;
        private System.Windows.Forms.Panel floorPanel;
        private System.Windows.Forms.Label lblElevatorDirection3floor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel doorRight3floor;
        private System.Windows.Forms.Panel doorLeft3floor;
        private System.Windows.Forms.Panel doorRight2floor;
        private System.Windows.Forms.Panel doorLeft2floor;
        private System.Windows.Forms.Label lblElevatorDirection2floor;
        private System.Windows.Forms.Panel doorRight1floor;
        private System.Windows.Forms.Panel doorLeft1floor;
        private System.Windows.Forms.Label lblElevatorDirection1floor;
        private System.Windows.Forms.Label lblElevatorDirection;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}

