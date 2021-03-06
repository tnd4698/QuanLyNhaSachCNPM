﻿namespace QuanLyNhaSach
{
    partial class FUpdateBookTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUpdateBookTitle));
            this.txbBookTitle = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateBookTitle = new System.Windows.Forms.Button();
            this.lbManangeBook = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.pbAddAuthor = new System.Windows.Forms.PictureBox();
            this.pbRemoveAuthor = new System.Windows.Forms.PictureBox();
            this.dtgvAuthor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbBookTitle
            // 
            this.txbBookTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBookTitle.Location = new System.Drawing.Point(143, 59);
            this.txbBookTitle.Name = "txbBookTitle";
            this.txbBookTitle.Size = new System.Drawing.Size(236, 26);
            this.txbBookTitle.TabIndex = 0;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.Black;
            this.lable.Location = new System.Drawing.Point(14, 66);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(99, 19);
            this.lable.TabIndex = 36;
            this.lable.Text = "Tên đầu sách";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(143, 103);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(236, 27);
            this.cbCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tác giả";
            // 
            // btnUpdateBookTitle
            // 
            this.btnUpdateBookTitle.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdateBookTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBookTitle.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateBookTitle.Location = new System.Drawing.Point(197, 317);
            this.btnUpdateBookTitle.Name = "btnUpdateBookTitle";
            this.btnUpdateBookTitle.Size = new System.Drawing.Size(95, 37);
            this.btnUpdateBookTitle.TabIndex = 4;
            this.btnUpdateBookTitle.Text = "Cập nhật";
            this.btnUpdateBookTitle.UseVisualStyleBackColor = false;
            this.btnUpdateBookTitle.Click += new System.EventHandler(this.btnUpdateBookTitle_Click);
            // 
            // lbManangeBook
            // 
            this.lbManangeBook.AutoSize = true;
            this.lbManangeBook.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManangeBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbManangeBook.Location = new System.Drawing.Point(95, 9);
            this.lbManangeBook.Name = "lbManangeBook";
            this.lbManangeBook.Size = new System.Drawing.Size(239, 28);
            this.lbManangeBook.TabIndex = 40;
            this.lbManangeBook.Text = "CẬP NHẬT ĐẦU SÁCH";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(303, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Trở lại";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbAuthor
            // 
            this.cbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbAuthor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(100, 144);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(120, 150);
            this.cbAuthor.TabIndex = 41;
            // 
            // pbAddAuthor
            // 
            this.pbAddAuthor.Image = ((System.Drawing.Image)(resources.GetObject("pbAddAuthor.Image")));
            this.pbAddAuthor.Location = new System.Drawing.Point(226, 180);
            this.pbAddAuthor.Name = "pbAddAuthor";
            this.pbAddAuthor.Size = new System.Drawing.Size(42, 40);
            this.pbAddAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddAuthor.TabIndex = 42;
            this.pbAddAuthor.TabStop = false;
            this.pbAddAuthor.Click += new System.EventHandler(this.pbAddAuthor_Click);
            // 
            // pbRemoveAuthor
            // 
            this.pbRemoveAuthor.Image = ((System.Drawing.Image)(resources.GetObject("pbRemoveAuthor.Image")));
            this.pbRemoveAuthor.Location = new System.Drawing.Point(226, 226);
            this.pbRemoveAuthor.Name = "pbRemoveAuthor";
            this.pbRemoveAuthor.Size = new System.Drawing.Size(42, 40);
            this.pbRemoveAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemoveAuthor.TabIndex = 42;
            this.pbRemoveAuthor.TabStop = false;
            this.pbRemoveAuthor.Click += new System.EventHandler(this.pbRemoveAuthor_Click);
            // 
            // dtgvAuthor
            // 
            this.dtgvAuthor.AllowUserToAddRows = false;
            this.dtgvAuthor.AllowUserToDeleteRows = false;
            this.dtgvAuthor.BackgroundColor = System.Drawing.Color.White;
            this.dtgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dtgvAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAuthor.Location = new System.Drawing.Point(0, 0);
            this.dtgvAuthor.Name = "dtgvAuthor";
            this.dtgvAuthor.ReadOnly = true;
            this.dtgvAuthor.RowHeadersVisible = false;
            this.dtgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAuthor.Size = new System.Drawing.Size(124, 150);
            this.dtgvAuthor.TabIndex = 43;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tác giả";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvAuthor);
            this.panel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(274, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 150);
            this.panel1.TabIndex = 44;
            // 
            // FUpdateBookTitle
            // 
            this.AcceptButton = this.btnUpdateBookTitle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(424, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbRemoveAuthor);
            this.Controls.Add(this.pbAddAuthor);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.lbManangeBook);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateBookTitle);
            this.Controls.Add(this.txbBookTitle);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FUpdateBookTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManangeBook";
            ((System.ComponentModel.ISupportInitialize)(this.pbAddAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbBookTitle;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbManangeBook;
        public System.Windows.Forms.Button btnUpdateBookTitle;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.PictureBox pbAddAuthor;
        private System.Windows.Forms.PictureBox pbRemoveAuthor;
        private System.Windows.Forms.DataGridView dtgvAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Panel panel1;
    }
}