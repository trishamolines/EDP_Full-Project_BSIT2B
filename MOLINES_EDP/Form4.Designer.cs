namespace MOLINES_EDP
{
    partial class PricebookForm
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
            this.Pricebook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pricebook
            // 
            this.Pricebook.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold);
            this.Pricebook.ForeColor = System.Drawing.Color.Black;
            this.Pricebook.Location = new System.Drawing.Point(12, 9);
            this.Pricebook.Name = "Pricebook";
            this.Pricebook.Size = new System.Drawing.Size(610, 59);
            this.Pricebook.TabIndex = 2;
            this.Pricebook.Text = "Pricebook Form";
            this.Pricebook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PricebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(634, 416);
            this.Controls.Add(this.Pricebook);
            this.Name = "PricebookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPricebook";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Pricebook;
    }
}