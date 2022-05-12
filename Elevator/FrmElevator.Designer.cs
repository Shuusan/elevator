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
            this.level3btnDown = new System.Windows.Forms.Button();
            this.elevator = new System.Windows.Forms.Panel();
            this.floor2panel = new System.Windows.Forms.Panel();
            this.level2btnUp = new System.Windows.Forms.Button();
            this.level2btnDown = new System.Windows.Forms.Button();
            this.floor1panel = new System.Windows.Forms.Panel();
            this.level1btnUp = new System.Windows.Forms.Button();
            this.elevatorRope = new System.Windows.Forms.Panel();
            this.insideBtnPanel = new System.Windows.Forms.Panel();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblQueuing = new System.Windows.Forms.Label();
            this.lblQuery = new System.Windows.Forms.Label();
            this.button3insideLift = new System.Windows.Forms.Button();
            this.button2insideLift = new System.Windows.Forms.Button();
            this.button1insideLift = new System.Windows.Forms.Button();
            this.floorPanel = new System.Windows.Forms.Panel();
            this.floor3panel.SuspendLayout();
            this.floor2panel.SuspendLayout();
            this.floor1panel.SuspendLayout();
            this.insideBtnPanel.SuspendLayout();
            this.floorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // floor3panel
            // 
            this.floor3panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.floor3panel.Controls.Add(this.level3btnDown);
            this.floor3panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.floor3panel.Location = new System.Drawing.Point(0, 0);
            this.floor3panel.Name = "floor3panel";
            this.floor3panel.Size = new System.Drawing.Size(772, 150);
            this.floor3panel.TabIndex = 1;
            // 
            // level3btnDown
            // 
            this.level3btnDown.BackColor = System.Drawing.Color.White;
            this.level3btnDown.Location = new System.Drawing.Point(32, 46);
            this.level3btnDown.Name = "level3btnDown";
            this.level3btnDown.Size = new System.Drawing.Size(50, 49);
            this.level3btnDown.TabIndex = 0;
            this.level3btnDown.Text = "↓";
            this.level3btnDown.UseVisualStyleBackColor = false;
            this.level3btnDown.Click += new System.EventHandler(this.Level3btnDown_Click);
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
            this.floor2panel.Controls.Add(this.level2btnUp);
            this.floor2panel.Controls.Add(this.level2btnDown);
            this.floor2panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.floor2panel.Location = new System.Drawing.Point(0, 150);
            this.floor2panel.Name = "floor2panel";
            this.floor2panel.Size = new System.Drawing.Size(772, 150);
            this.floor2panel.TabIndex = 2;
            // 
            // level2btnUp
            // 
            this.level2btnUp.BackColor = System.Drawing.Color.White;
            this.level2btnUp.Location = new System.Drawing.Point(32, 20);
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
            this.level2btnDown.Location = new System.Drawing.Point(32, 84);
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
            this.floor1panel.Controls.Add(this.level1btnUp);
            this.floor1panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.floor1panel.Location = new System.Drawing.Point(0, 300);
            this.floor1panel.Name = "floor1panel";
            this.floor1panel.Size = new System.Drawing.Size(772, 150);
            this.floor1panel.TabIndex = 3;
            // 
            // level1btnUp
            // 
            this.level1btnUp.BackColor = System.Drawing.Color.White;
            this.level1btnUp.Location = new System.Drawing.Point(30, 42);
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
            this.floor2panel.ResumeLayout(false);
            this.floor1panel.ResumeLayout(false);
            this.insideBtnPanel.ResumeLayout(false);
            this.insideBtnPanel.PerformLayout();
            this.floorPanel.ResumeLayout(false);
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
    }
}

