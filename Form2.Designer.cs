
using System.Windows.Forms;

namespace Timer
{
    partial class Timer
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
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.TimerS = new System.Windows.Forms.Timer(this.components);
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinuteText = new System.Windows.Forms.TextBox();
            this.SecondText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Minute = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.Reset2 = new System.Windows.Forms.Button();
            this.CentiSecond = new System.Windows.Forms.Label();
            this.Stop2 = new System.Windows.Forms.Button();
            this.Start2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Red;
            this.Start.Location = new System.Drawing.Point(0, 187);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(101, 44);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.Color.Blue;
            this.Stop.Location = new System.Drawing.Point(143, 187);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(102, 44);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Reset
            // 
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Reset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Reset.Location = new System.Drawing.Point(289, 187);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(107, 44);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // TimerS
            // 
            this.TimerS.Interval = 1000;
            this.TimerS.Tick += new System.EventHandler(this.TimerS_Tick);
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.Location = new System.Drawing.Point(93, 132);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(36, 35);
            this.PlusButton.TabIndex = 9;
            this.PlusButton.Text = "+5";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.Location = new System.Drawing.Point(241, 132);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(41, 35);
            this.MinusButton.TabIndex = 10;
            this.MinusButton.Text = "-5";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox1.Controls.Add(this.MinuteText);
            this.groupBox1.Controls.Add(this.SecondText);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.PlusButton);
            this.groupBox1.Controls.Add(this.MinusButton);
            this.groupBox1.Controls.Add(this.Stop);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 237);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // MinuteText
            // 
            this.MinuteText.BackColor = System.Drawing.Color.Lime;
            this.MinuteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteText.ForeColor = System.Drawing.Color.DarkViolet;
            this.MinuteText.Location = new System.Drawing.Point(120, 63);
            this.MinuteText.MinimumSize = new System.Drawing.Size(50, 38);
            this.MinuteText.Multiline = true;
            this.MinuteText.Name = "MinuteText";
            this.MinuteText.Size = new System.Drawing.Size(50, 38);
            this.MinuteText.TabIndex = 14;
            this.MinuteText.Text = "00";
            this.MinuteText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinuteText.WordWrap = false;
            this.MinuteText.TextChanged += new System.EventHandler(this.MinuteText_TextChanged);
            // 
            // SecondText
            // 
            this.SecondText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondText.ForeColor = System.Drawing.Color.Aqua;
            this.SecondText.Location = new System.Drawing.Point(205, 63);
            this.SecondText.MinimumSize = new System.Drawing.Size(50, 38);
            this.SecondText.Multiline = true;
            this.SecondText.Name = "SecondText";
            this.SecondText.Size = new System.Drawing.Size(50, 38);
            this.SecondText.TabIndex = 13;
            this.SecondText.Text = "00";
            this.SecondText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SecondText.WordWrap = false;
            this.SecondText.TextChanged += new System.EventHandler(this.SecondText_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.groupBox2.Controls.Add(this.Minute);
            this.groupBox2.Controls.Add(this.Second);
            this.groupBox2.Controls.Add(this.Reset2);
            this.groupBox2.Controls.Add(this.CentiSecond);
            this.groupBox2.Controls.Add(this.Stop2);
            this.groupBox2.Controls.Add(this.Start2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.GreenYellow;
            this.groupBox2.Location = new System.Drawing.Point(649, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 234);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "StopWatch";
            // 
            // Minute
            // 
            this.Minute.AutoSize = true;
            this.Minute.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.Minute.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Minute.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Minute.Location = new System.Drawing.Point(105, 62);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(73, 42);
            this.Minute.TabIndex = 1;
            this.Minute.Text = "00:";
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.Second.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Second.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Second.Location = new System.Drawing.Point(193, 62);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(73, 42);
            this.Second.TabIndex = 2;
            this.Second.Text = "00:";
            // 
            // Reset2
            // 
            this.Reset2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Reset2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Reset2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Reset2.Location = new System.Drawing.Point(297, 186);
            this.Reset2.Name = "Reset2";
            this.Reset2.Size = new System.Drawing.Size(99, 40);
            this.Reset2.TabIndex = 5;
            this.Reset2.Text = "Reset2";
            this.Reset2.UseVisualStyleBackColor = true;
            this.Reset2.Click += new System.EventHandler(this.Reset2_Click);
            // 
            // CentiSecond
            // 
            this.CentiSecond.AutoSize = true;
            this.CentiSecond.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CentiSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.CentiSecond.ForeColor = System.Drawing.Color.Indigo;
            this.CentiSecond.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CentiSecond.Location = new System.Drawing.Point(290, 62);
            this.CentiSecond.Name = "CentiSecond";
            this.CentiSecond.Size = new System.Drawing.Size(62, 42);
            this.CentiSecond.TabIndex = 0;
            this.CentiSecond.Text = "00";
            // 
            // Stop2
            // 
            this.Stop2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Stop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Stop2.ForeColor = System.Drawing.Color.Lime;
            this.Stop2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Stop2.Location = new System.Drawing.Point(160, 188);
            this.Stop2.Name = "Stop2";
            this.Stop2.Size = new System.Drawing.Size(106, 40);
            this.Stop2.TabIndex = 4;
            this.Stop2.Text = "Stop";
            this.Stop2.UseVisualStyleBackColor = true;
            this.Stop2.Click += new System.EventHandler(this.Stop2_Click);
            // 
            // Start2
            // 
            this.Start2.AccessibleName = "Start";
            this.Start2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Start2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start2.ForeColor = System.Drawing.Color.Red;
            this.Start2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Start2.Location = new System.Drawing.Point(6, 188);
            this.Start2.Name = "Start2";
            this.Start2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Start2.Size = new System.Drawing.Size(95, 40);
            this.Start2.TabIndex = 3;
            this.Start2.Text = "Start";
            this.Start2.UseVisualStyleBackColor = true;
            this.Start2.Click += new System.EventHandler(this.Start2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(755, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "StopWatch";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(1079, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "Timer";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Timer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Timer TimerS;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SecondText;
        private System.Windows.Forms.TextBox MinuteText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Button Reset2;
        private System.Windows.Forms.Label CentiSecond;
        private System.Windows.Forms.Button Stop2;
        private System.Windows.Forms.Button Start2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

