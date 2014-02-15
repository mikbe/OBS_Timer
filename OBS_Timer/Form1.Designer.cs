namespace OBS_Timer
{
    partial class OBS_Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OBS_Timer));
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.clockLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.btn0015 = new System.Windows.Forms.Button();
            this.btn0030 = new System.Windows.Forms.Button();
            this.btn0045 = new System.Windows.Forms.Button();
            this.btn0100 = new System.Windows.Forms.Button();
            this.btn0115 = new System.Windows.Forms.Button();
            this.btn0130 = new System.Windows.Forms.Button();
            this.btn0200 = new System.Windows.Forms.Button();
            this.btn0145 = new System.Windows.Forms.Button();
            this.txtTimerMessage = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.grpMessage = new System.Windows.Forms.GroupBox();
            this.grpCountdown = new System.Windows.Forms.GroupBox();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.grpStop = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scrollCountOffset = new System.Windows.Forms.VScrollBar();
            this.lblCountOffset = new System.Windows.Forms.Label();
            this.grpButtons.SuspendLayout();
            this.grpMessage.SuspendLayout();
            this.grpCountdown.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.grpStop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Calibri", 40F);
            this.clockLabel.Location = new System.Drawing.Point(6, 29);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(218, 66);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "00:00:00";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.BackColor = System.Drawing.Color.Transparent;
            this.countLabel.Font = new System.Drawing.Font("Calibri", 40F);
            this.countLabel.Location = new System.Drawing.Point(7, 29);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(218, 66);
            this.countLabel.TabIndex = 2;
            this.countLabel.Text = "00:00:00";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn0015
            // 
            this.btn0015.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn0015.Location = new System.Drawing.Point(34, 39);
            this.btn0015.Name = "btn0015";
            this.btn0015.Size = new System.Drawing.Size(136, 45);
            this.btn0015.TabIndex = 4;
            this.btn0015.Tag = "15";
            this.btn0015.Text = "00:15";
            this.btn0015.UseVisualStyleBackColor = true;
            // 
            // btn0030
            // 
            this.btn0030.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn0030.Location = new System.Drawing.Point(34, 90);
            this.btn0030.Name = "btn0030";
            this.btn0030.Size = new System.Drawing.Size(136, 45);
            this.btn0030.TabIndex = 4;
            this.btn0030.Tag = "30";
            this.btn0030.Text = "00:30";
            this.btn0030.UseVisualStyleBackColor = true;
            // 
            // btn0045
            // 
            this.btn0045.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn0045.Location = new System.Drawing.Point(34, 141);
            this.btn0045.Name = "btn0045";
            this.btn0045.Size = new System.Drawing.Size(136, 45);
            this.btn0045.TabIndex = 4;
            this.btn0045.Tag = "45";
            this.btn0045.Text = "00:45";
            this.btn0045.UseVisualStyleBackColor = true;
            // 
            // btn0100
            // 
            this.btn0100.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn0100.Location = new System.Drawing.Point(34, 192);
            this.btn0100.Name = "btn0100";
            this.btn0100.Size = new System.Drawing.Size(136, 45);
            this.btn0100.TabIndex = 4;
            this.btn0100.Tag = "60";
            this.btn0100.Text = "01:00";
            this.btn0100.UseVisualStyleBackColor = true;
            // 
            // btn0115
            // 
            this.btn0115.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn0115.Location = new System.Drawing.Point(176, 39);
            this.btn0115.Name = "btn0115";
            this.btn0115.Size = new System.Drawing.Size(136, 45);
            this.btn0115.TabIndex = 4;
            this.btn0115.Tag = "75";
            this.btn0115.Text = "01:15";
            this.btn0115.UseVisualStyleBackColor = true;
            // 
            // btn0130
            // 
            this.btn0130.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn0130.Location = new System.Drawing.Point(176, 90);
            this.btn0130.Name = "btn0130";
            this.btn0130.Size = new System.Drawing.Size(136, 45);
            this.btn0130.TabIndex = 4;
            this.btn0130.Tag = "90";
            this.btn0130.Text = "01:30";
            this.btn0130.UseVisualStyleBackColor = true;
            // 
            // btn0200
            // 
            this.btn0200.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn0200.Location = new System.Drawing.Point(176, 192);
            this.btn0200.Name = "btn0200";
            this.btn0200.Size = new System.Drawing.Size(136, 45);
            this.btn0200.TabIndex = 4;
            this.btn0200.Tag = "120";
            this.btn0200.Text = "02:00";
            this.btn0200.UseVisualStyleBackColor = true;
            // 
            // btn0145
            // 
            this.btn0145.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn0145.Location = new System.Drawing.Point(176, 141);
            this.btn0145.Name = "btn0145";
            this.btn0145.Size = new System.Drawing.Size(136, 45);
            this.btn0145.TabIndex = 4;
            this.btn0145.Tag = "105";
            this.btn0145.Text = "01:45";
            this.btn0145.UseVisualStyleBackColor = true;
            // 
            // txtTimerMessage
            // 
            this.txtTimerMessage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimerMessage.Location = new System.Drawing.Point(34, 35);
            this.txtTimerMessage.Name = "txtTimerMessage";
            this.txtTimerMessage.Size = new System.Drawing.Size(420, 31);
            this.txtTimerMessage.TabIndex = 5;
            this.txtTimerMessage.TextChanged += new System.EventHandler(this.txtOutputText_TextChanged);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(34, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(420, 64);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btn0015);
            this.grpButtons.Controls.Add(this.btn0100);
            this.grpButtons.Controls.Add(this.btn0045);
            this.grpButtons.Controls.Add(this.btn0130);
            this.grpButtons.Controls.Add(this.btn0145);
            this.grpButtons.Controls.Add(this.btn0115);
            this.grpButtons.Controls.Add(this.btn0200);
            this.grpButtons.Controls.Add(this.btn0030);
            this.grpButtons.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpButtons.Location = new System.Drawing.Point(12, 212);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(327, 266);
            this.grpButtons.TabIndex = 9;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Timer Buttons";
            // 
            // grpMessage
            // 
            this.grpMessage.Controls.Add(this.txtTimerMessage);
            this.grpMessage.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMessage.Location = new System.Drawing.Point(12, 125);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(483, 81);
            this.grpMessage.TabIndex = 10;
            this.grpMessage.TabStop = false;
            this.grpMessage.Text = "Timer Message";
            // 
            // grpCountdown
            // 
            this.grpCountdown.Controls.Add(this.countLabel);
            this.grpCountdown.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCountdown.Location = new System.Drawing.Point(270, 12);
            this.grpCountdown.Name = "grpCountdown";
            this.grpCountdown.Size = new System.Drawing.Size(225, 107);
            this.grpCountdown.TabIndex = 11;
            this.grpCountdown.TabStop = false;
            this.grpCountdown.Text = "Countdown";
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.clockLabel);
            this.grpTime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTime.Location = new System.Drawing.Point(12, 12);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(233, 107);
            this.grpTime.TabIndex = 12;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Current Time";
            // 
            // grpStop
            // 
            this.grpStop.Controls.Add(this.btnStop);
            this.grpStop.Location = new System.Drawing.Point(12, 484);
            this.grpStop.Name = "grpStop";
            this.grpStop.Size = new System.Drawing.Size(483, 100);
            this.grpStop.TabIndex = 13;
            this.grpStop.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scrollCountOffset);
            this.groupBox1.Controls.Add(this.lblCountOffset);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(346, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 266);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Count Offset";
            // 
            // scrollCountOffset
            // 
            this.scrollCountOffset.LargeChange = 1;
            this.scrollCountOffset.Location = new System.Drawing.Point(18, 95);
            this.scrollCountOffset.Maximum = 3;
            this.scrollCountOffset.Name = "scrollCountOffset";
            this.scrollCountOffset.Size = new System.Drawing.Size(113, 142);
            this.scrollCountOffset.TabIndex = 2;
            this.scrollCountOffset.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollCountdownOffset_Scroll);
            // 
            // lblCountOffset
            // 
            this.lblCountOffset.AutoSize = true;
            this.lblCountOffset.Font = new System.Drawing.Font("Calibri", 40F);
            this.lblCountOffset.Location = new System.Drawing.Point(38, 29);
            this.lblCountOffset.Name = "lblCountOffset";
            this.lblCountOffset.Size = new System.Drawing.Size(82, 66);
            this.lblCountOffset.TabIndex = 1;
            this.lblCountOffset.Text = "00";
            this.lblCountOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OBS_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpStop);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.grpCountdown);
            this.Controls.Add(this.grpMessage);
            this.Controls.Add(this.grpButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(529, 638);
            this.MinimumSize = new System.Drawing.Size(529, 638);
            this.Name = "OBS_Timer";
            this.Text = "OBS Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OBS_Timer_FormClosing);
            this.grpButtons.ResumeLayout(false);
            this.grpMessage.ResumeLayout(false);
            this.grpMessage.PerformLayout();
            this.grpCountdown.ResumeLayout(false);
            this.grpCountdown.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            this.grpStop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button btn0015;
        private System.Windows.Forms.Button btn0030;
        private System.Windows.Forms.Button btn0045;
        private System.Windows.Forms.Button btn0100;
        private System.Windows.Forms.Button btn0115;
        private System.Windows.Forms.Button btn0130;
        private System.Windows.Forms.Button btn0200;
        private System.Windows.Forms.Button btn0145;
        private System.Windows.Forms.TextBox txtTimerMessage;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.GroupBox grpMessage;
        private System.Windows.Forms.GroupBox grpCountdown;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.GroupBox grpStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCountOffset;
        private System.Windows.Forms.VScrollBar scrollCountOffset;
    }
}

