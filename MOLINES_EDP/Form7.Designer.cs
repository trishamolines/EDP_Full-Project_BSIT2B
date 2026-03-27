namespace MOLINES_EDP
{
    partial class TimeClockForm
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
            this.TimeClock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeClock
            // 
            this.TimeClock.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeClock.ForeColor = System.Drawing.Color.Black;
            this.TimeClock.Location = new System.Drawing.Point(12, 9);
            this.TimeClock.Name = "TimeClock";
            this.TimeClock.Size = new System.Drawing.Size(610, 53);
            this.TimeClock.TabIndex = 4;
            this.TimeClock.Text = "Time Clock Form";
            this.TimeClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(634, 416);
            this.Controls.Add(this.TimeClock);
            this.Name = "TimeClockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimeClock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TimeClock;
    }
}