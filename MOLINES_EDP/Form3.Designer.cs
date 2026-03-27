namespace MOLINES_EDP
{
    partial class StoreStatusForm
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
            this.StoreStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StoreStatus
            // 
            this.StoreStatus.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold);
            this.StoreStatus.ForeColor = System.Drawing.Color.Black;
            this.StoreStatus.Location = new System.Drawing.Point(12, 9);
            this.StoreStatus.Name = "StoreStatus";
            this.StoreStatus.Size = new System.Drawing.Size(610, 60);
            this.StoreStatus.TabIndex = 1;
            this.StoreStatus.Text = "Store Status Form";
            this.StoreStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(634, 416);
            this.Controls.Add(this.StoreStatus);
            this.Name = "StoreStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStoreStatus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StoreStatus;
    }
}