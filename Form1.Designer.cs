namespace SoundTimer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTimeLength = new System.Windows.Forms.TextBox();
            this.txbTimerInterval = new System.Windows.Forms.TextBox();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длительность таймера, мин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(274, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Интервал срабатывания, мин";
            // 
            // txbTimeLength
            // 
            this.txbTimeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbTimeLength.Location = new System.Drawing.Point(85, 60);
            this.txbTimeLength.Name = "txbTimeLength";
            this.txbTimeLength.Size = new System.Drawing.Size(100, 29);
            this.txbTimeLength.TabIndex = 1;
            // 
            // txbTimerInterval
            // 
            this.txbTimerInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbTimerInterval.Location = new System.Drawing.Point(361, 60);
            this.txbTimerInterval.Name = "txbTimerInterval";
            this.txbTimerInterval.Size = new System.Drawing.Size(100, 29);
            this.txbTimerInterval.TabIndex = 1;
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTimer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnStartTimer.Location = new System.Drawing.Point(219, 117);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(103, 39);
            this.btnStartTimer.TabIndex = 2;
            this.btnStartTimer.Text = "Начать";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter.Location = new System.Drawing.Point(108, 124);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(20, 24);
            this.lblCounter.TabIndex = 3;
            this.lblCounter.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 191);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.txbTimerInterval);
            this.Controls.Add(this.txbTimeLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таймер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTimeLength;
        private System.Windows.Forms.TextBox txbTimerInterval;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCounter;
    }
}

