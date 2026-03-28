namespace MOLINES_EDP
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.tblelayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnStoreStatus = new System.Windows.Forms.Button();
            this.btnPricebook = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTimeClock = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pcboxArrow = new System.Windows.Forms.PictureBox();
            this.tblelayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // tblelayoutPanel
            // 
            this.tblelayoutPanel.ColumnCount = 3;
            this.tblelayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.14948F));
            this.tblelayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.18716F));
            this.tblelayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66337F));
            this.tblelayoutPanel.Controls.Add(this.btnRegister, 0, 0);
            this.tblelayoutPanel.Controls.Add(this.btnStoreStatus, 1, 0);
            this.tblelayoutPanel.Controls.Add(this.btnPricebook, 2, 0);
            this.tblelayoutPanel.Controls.Add(this.btnVendors, 0, 1);
            this.tblelayoutPanel.Controls.Add(this.btnUsers, 1, 1);
            this.tblelayoutPanel.Controls.Add(this.btnTimeClock, 2, 1);
            this.tblelayoutPanel.Location = new System.Drawing.Point(26, 113);
            this.tblelayoutPanel.Name = "tblelayoutPanel";
            this.tblelayoutPanel.RowCount = 2;
            this.tblelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.36496F));
            this.tblelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.63504F));
            this.tblelayoutPanel.Size = new System.Drawing.Size(595, 284);
            this.tblelayoutPanel.TabIndex = 0;
            this.tblelayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.Location = new System.Drawing.Point(3, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(191, 137);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStoreStatus
            // 
            this.btnStoreStatus.BackColor = System.Drawing.Color.Thistle;
            this.btnStoreStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStoreStatus.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.btnStoreStatus.Location = new System.Drawing.Point(200, 3);
            this.btnStoreStatus.Name = "btnStoreStatus";
            this.btnStoreStatus.Size = new System.Drawing.Size(191, 137);
            this.btnStoreStatus.TabIndex = 1;
            this.btnStoreStatus.Text = "Store Status";
            this.btnStoreStatus.UseVisualStyleBackColor = false;
            this.btnStoreStatus.Click += new System.EventHandler(this.btnStoreStatus_Click);
            // 
            // btnPricebook
            // 
            this.btnPricebook.BackColor = System.Drawing.Color.Lavender;
            this.btnPricebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPricebook.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.btnPricebook.Location = new System.Drawing.Point(397, 3);
            this.btnPricebook.Name = "btnPricebook";
            this.btnPricebook.Size = new System.Drawing.Size(195, 137);
            this.btnPricebook.TabIndex = 2;
            this.btnPricebook.Text = "Pricebook";
            this.btnPricebook.UseVisualStyleBackColor = false;
            this.btnPricebook.Click += new System.EventHandler(this.btnPricebook_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.BackColor = System.Drawing.Color.LightCyan;
            this.btnVendors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVendors.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.btnVendors.Location = new System.Drawing.Point(3, 146);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(191, 135);
            this.btnVendors.TabIndex = 3;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = false;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.btnUsers.Location = new System.Drawing.Point(200, 146);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(191, 135);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnTimeClock
            // 
            this.btnTimeClock.BackColor = System.Drawing.Color.MistyRose;
            this.btnTimeClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeClock.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.btnTimeClock.Location = new System.Drawing.Point(397, 146);
            this.btnTimeClock.Name = "btnTimeClock";
            this.btnTimeClock.Size = new System.Drawing.Size(195, 135);
            this.btnTimeClock.TabIndex = 5;
            this.btnTimeClock.Text = "Time Clock";
            this.btnTimeClock.UseVisualStyleBackColor = false;
            this.btnTimeClock.Click += new System.EventHandler(this.btnTimeClock_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(12, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(620, 74);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = " Welcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.pcboxArrow);
            this.panel1.Location = new System.Drawing.Point(26, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 38);
            this.panel1.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(47, 4);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(166, 34);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Hi, Trisha Molines";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcboxArrow
            // 
            this.pcboxArrow.ErrorImage = null;
            this.pcboxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pcboxArrow.Image")));
            this.pcboxArrow.InitialImage = null;
            this.pcboxArrow.Location = new System.Drawing.Point(3, 4);
            this.pcboxArrow.Name = "pcboxArrow";
            this.pcboxArrow.Size = new System.Drawing.Size(38, 34);
            this.pcboxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcboxArrow.TabIndex = 0;
            this.pcboxArrow.TabStop = false;
            this.pcboxArrow.Click += new System.EventHandler(this.pcboxArrow_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tblelayoutPanel);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.tblelayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblelayoutPanel;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnStoreStatus;
        private System.Windows.Forms.Button btnPricebook;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnTimeClock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcboxArrow;
        private System.Windows.Forms.Label lblUser;
    }
}