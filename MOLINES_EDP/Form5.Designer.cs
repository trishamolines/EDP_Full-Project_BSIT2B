namespace MOLINES_EDP
{
    partial class VendorsForm
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
            this.Vendors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vendors
            // 
            this.Vendors.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendors.ForeColor = System.Drawing.Color.Black;
            this.Vendors.Location = new System.Drawing.Point(12, 9);
            this.Vendors.Name = "Vendors";
            this.Vendors.Size = new System.Drawing.Size(610, 53);
            this.Vendors.TabIndex = 3;
            this.Vendors.Text = "Vendors Form";
            this.Vendors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VendorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(634, 416);
            this.Controls.Add(this.Vendors);
            this.Name = "VendorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVendors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Vendors;
    }
}