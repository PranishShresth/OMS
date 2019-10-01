namespace OMS
{
    partial class Customer
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
            this.txtCustName = new System.Windows.Forms.RichTextBox();
            this.txtCustPhn = new System.Windows.Forms.RichTextBox();
            this.txtCustAdd = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Search_Cust = new System.Windows.Forms.TextBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(24, 94);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(167, 30);
            this.txtCustName.TabIndex = 3;
            this.txtCustName.Text = "";
            // 
            // txtCustPhn
            // 
            this.txtCustPhn.Location = new System.Drawing.Point(24, 162);
            this.txtCustPhn.Name = "txtCustPhn";
            this.txtCustPhn.Size = new System.Drawing.Size(167, 30);
            this.txtCustPhn.TabIndex = 7;
            this.txtCustPhn.Text = "";
            // 
            // txtCustAdd
            // 
            this.txtCustAdd.Location = new System.Drawing.Point(24, 236);
            this.txtCustAdd.Name = "txtCustAdd";
            this.txtCustAdd.Size = new System.Drawing.Size(167, 30);
            this.txtCustAdd.TabIndex = 9;
            this.txtCustAdd.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(62, 330);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 32);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Add";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(20, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer Phone:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(20, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customer Address:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(288, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Manage Users";
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(266, 110);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.Size = new System.Drawing.Size(385, 178);
            this.CustomerGridView.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(262, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search:";
            // 
            // txt_Search_Cust
            // 
            this.txt_Search_Cust.Location = new System.Drawing.Point(337, 71);
            this.txt_Search_Cust.Name = "txt_Search_Cust";
            this.txt_Search_Cust.Size = new System.Drawing.Size(314, 20);
            this.txt_Search_Cust.TabIndex = 18;
            this.txt_Search_Cust.TextChanged += new System.EventHandler(this.Txt_Search_Cust_TextChanged);
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.MinimumSize = new System.Drawing.Size(80, 30);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip3.Size = new System.Drawing.Size(680, 30);
            this.menuStrip3.TabIndex = 19;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(97)))));
            this.accountToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.ProfileToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 426);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.txt_Search_Cust);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCustAdd);
            this.Controls.Add(this.txtCustPhn);
            this.Controls.Add(this.txtCustName);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtCustName;
        private System.Windows.Forms.RichTextBox txtCustPhn;
        private System.Windows.Forms.RichTextBox txtCustAdd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Search_Cust;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}