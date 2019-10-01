namespace OMS
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdDescription = new System.Windows.Forms.RichTextBox();
            this.txtProdType = new System.Windows.Forms.TextBox();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet1 = new OMS.DataDataSet1();
            this.btnCreate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.productTableAdapter1 = new OMS.DataDataSet1TableAdapters.ProductTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(12, 104);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(187, 20);
            this.txtProdName.TabIndex = 6;
            // 
            // txtProdDescription
            // 
            this.txtProdDescription.Location = new System.Drawing.Point(15, 190);
            this.txtProdDescription.Name = "txtProdDescription";
            this.txtProdDescription.Size = new System.Drawing.Size(187, 60);
            this.txtProdDescription.TabIndex = 7;
            this.txtProdDescription.Text = "";
            // 
            // txtProdType
            // 
            this.txtProdType.Location = new System.Drawing.Point(15, 303);
            this.txtProdType.Name = "txtProdType";
            this.txtProdType.Size = new System.Drawing.Size(187, 20);
            this.txtProdType.TabIndex = 8;
            // 
            // OrderGrid
            // 
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Location = new System.Drawing.Point(263, 104);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OrderGrid.Size = new System.Drawing.Size(463, 219);
            this.OrderGrid.TabIndex = 9;
            this.OrderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.dataDataSet1;
            // 
            // dataDataSet1
            // 
            this.dataDataSet1.DataSetName = "DataDataSet1";
            this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(15, 342);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 32);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(96, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(177, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(730, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(259, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Search:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(332, 70);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(394, 20);
            this.txt_Search.TabIndex = 16;
            this.txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(11, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product Description:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product Type:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(758, 24);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
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
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click_1);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(758, 424);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.txtProdType);
            this.Controls.Add(this.txtProdDescription);
            this.Controls.Add(this.txtProdName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "f";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.RichTextBox txtProdDescription;
        private System.Windows.Forms.TextBox txtProdType;
        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DataDataSet1 dataDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private DataDataSet1TableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}