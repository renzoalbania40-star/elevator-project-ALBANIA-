namespace elevatorController4Floor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelShaft = new System.Windows.Forms.Panel();
            this.panelElevator = new System.Windows.Forms.Panel();
            this.panelDoorLeft = new System.Windows.Forms.Panel();
            this.panelDoorRight = new System.Windows.Forms.Panel();
            this.labelFloor1 = new System.Windows.Forms.Label();
            this.labelFloor2 = new System.Windows.Forms.Label();
            this.labelFloor3 = new System.Windows.Forms.Label();
            this.labelFloor4 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.lblFloor = new System.Windows.Forms.Label();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.timerDoorOpen = new System.Windows.Forms.Timer(this.components);
            this.timerDoorClose = new System.Windows.Forms.Timer(this.components);
            this.panelShaft.SuspendLayout();
            this.panelElevator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShaft
            // 
            this.panelShaft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShaft.Controls.Add(this.panelElevator);
            this.panelShaft.Location = new System.Drawing.Point(50, 50);
            this.panelShaft.Name = "panelShaft";
            this.panelShaft.Size = new System.Drawing.Size(220, 500);
            this.panelShaft.TabIndex = 0;
            // 
            // panelElevator
            // 
            this.panelElevator.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelElevator.Controls.Add(this.panelDoorRight);
            this.panelElevator.Controls.Add(this.panelDoorLeft);
            this.panelElevator.Location = new System.Drawing.Point(60, 400);
            this.panelElevator.Name = "panelElevator";
            this.panelElevator.Size = new System.Drawing.Size(100, 80);
            this.panelElevator.TabIndex = 0;
            // 
            // panelDoorLeft
            // 
            this.panelDoorLeft.BackColor = System.Drawing.Color.Silver;
            this.panelDoorLeft.Location = new System.Drawing.Point(0, 0);
            this.panelDoorLeft.Name = "panelDoorLeft";
            this.panelDoorLeft.Size = new System.Drawing.Size(50, 80);
            this.panelDoorLeft.TabIndex = 0;
            // 
            // panelDoorRight
            // 
            this.panelDoorRight.BackColor = System.Drawing.Color.Silver;
            this.panelDoorRight.Location = new System.Drawing.Point(50, 0);
            this.panelDoorRight.Name = "panelDoorRight";
            this.panelDoorRight.Size = new System.Drawing.Size(50, 80);
            this.panelDoorRight.TabIndex = 1;
            // 
            // labelFloor1
            // 
            this.labelFloor1.AutoSize = true;
            this.labelFloor1.Location = new System.Drawing.Point(316, 497);
            this.labelFloor1.Name = "labelFloor1";
            this.labelFloor1.Size = new System.Drawing.Size(47, 13);
            this.labelFloor1.TabIndex = 1;
            this.labelFloor1.Text = "1st Floor";
            // 
            // labelFloor2
            // 
            this.labelFloor2.AutoSize = true;
            this.labelFloor2.Location = new System.Drawing.Point(312, 394);
            this.labelFloor2.Name = "labelFloor2";
            this.labelFloor2.Size = new System.Drawing.Size(51, 13);
            this.labelFloor2.TabIndex = 2;
            this.labelFloor2.Text = "2nd Floor";
            // 
            // labelFloor3
            // 
            this.labelFloor3.AutoSize = true;
            this.labelFloor3.Location = new System.Drawing.Point(312, 284);
            this.labelFloor3.Name = "labelFloor3";
            this.labelFloor3.Size = new System.Drawing.Size(48, 13);
            this.labelFloor3.TabIndex = 3;
            this.labelFloor3.Text = "3rd Floor";
            // 
            // labelFloor4
            // 
            this.labelFloor4.AutoSize = true;
            this.labelFloor4.Location = new System.Drawing.Point(312, 166);
            this.labelFloor4.Name = "labelFloor4";
            this.labelFloor4.Size = new System.Drawing.Size(48, 13);
            this.labelFloor4.TabIndex = 4;
            this.labelFloor4.Text = "4th Floor";
            this.labelFloor4.Click += new System.EventHandler(this.labelFloor4_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(453, 497);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "Floor 1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(453, 384);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Floor 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(453, 274);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "Floor 3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(453, 156);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "floor 4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor.Location = new System.Drawing.Point(364, 37);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(96, 29);
            this.lblFloor.TabIndex = 9;
            this.lblFloor.Text = "Floor 1";
            // 
            // timerMove
            // 
            this.timerMove.Interval = 20;
            // 
            // timerDoorOpen
            // 
            this.timerDoorOpen.Interval = 20;
            // 
            // timerDoorClose
            // 
            this.timerDoorClose.Interval = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.labelFloor4);
            this.Controls.Add(this.labelFloor3);
            this.Controls.Add(this.labelFloor2);
            this.Controls.Add(this.labelFloor1);
            this.Controls.Add(this.panelShaft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelShaft.ResumeLayout(false);
            this.panelElevator.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelShaft;
        private System.Windows.Forms.Panel panelElevator;
        private System.Windows.Forms.Panel panelDoorRight;
        private System.Windows.Forms.Panel panelDoorLeft;
        private System.Windows.Forms.Label labelFloor1;
        private System.Windows.Forms.Label labelFloor2;
        private System.Windows.Forms.Label labelFloor3;
        private System.Windows.Forms.Label labelFloor4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Timer timerDoorOpen;
        private System.Windows.Forms.Timer timerDoorClose;
    }
}

