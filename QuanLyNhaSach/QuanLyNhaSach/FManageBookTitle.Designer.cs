﻿namespace QuanLyNhaSach
{
    partial class FManageBookTitle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvManageBookTitle = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddBookTitle = new System.Windows.Forms.Button();
            this.btnUpdateBookTitle = new System.Windows.Forms.Button();
            this.btnRemoveBookTitle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageBookTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 72);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(290, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "QUẢN LÝ ĐẦU SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnRemoveBookTitle);
            this.groupBox1.Controls.Add(this.btnUpdateBookTitle);
            this.groupBox1.Controls.Add(this.btnAddBookTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 502);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 50);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvManageBookTitle);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 430);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đầu sách";
            // 
            // dtgvManageBookTitle
            // 
            this.dtgvManageBookTitle.AllowUserToAddRows = false;
            this.dtgvManageBookTitle.AllowUserToDeleteRows = false;
            this.dtgvManageBookTitle.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvManageBookTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageBookTitle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.nameBook,
            this.category,
            this.author,
            this.countVersion,
            this.totalCount});
            this.dtgvManageBookTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvManageBookTitle.Location = new System.Drawing.Point(3, 19);
            this.dtgvManageBookTitle.Name = "dtgvManageBookTitle";
            this.dtgvManageBookTitle.ReadOnly = true;
            this.dtgvManageBookTitle.RowHeadersVisible = false;
            this.dtgvManageBookTitle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvManageBookTitle.Size = new System.Drawing.Size(958, 408);
            this.dtgvManageBookTitle.TabIndex = 3;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "Mã  đầu sách";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nameBook
            // 
            this.nameBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameBook.DataPropertyName = "name";
            this.nameBook.HeaderText = "Tên đầu sách";
            this.nameBook.Name = "nameBook";
            this.nameBook.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Thể loại sách";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "Tác giả";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // countVersion
            // 
            this.countVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countVersion.DataPropertyName = "countVersion";
            this.countVersion.HeaderText = "Số phiên bản";
            this.countVersion.Name = "countVersion";
            this.countVersion.ReadOnly = true;
            // 
            // totalCount
            // 
            this.totalCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalCount.DataPropertyName = "totalCount";
            this.totalCount.HeaderText = "Tổng lượng tồn";
            this.totalCount.Name = "totalCount";
            this.totalCount.ReadOnly = true;
            // 
            // btnAddBookTitle
            // 
            this.btnAddBookTitle.Location = new System.Drawing.Point(54, 15);
            this.btnAddBookTitle.Name = "btnAddBookTitle";
            this.btnAddBookTitle.Size = new System.Drawing.Size(75, 23);
            this.btnAddBookTitle.TabIndex = 0;
            this.btnAddBookTitle.Text = "Thêm";
            this.btnAddBookTitle.UseVisualStyleBackColor = true;
            this.btnAddBookTitle.Click += new System.EventHandler(this.btnAddBookTitle_Click);
            // 
            // btnUpdateBookTitle
            // 
            this.btnUpdateBookTitle.Location = new System.Drawing.Point(161, 15);
            this.btnUpdateBookTitle.Name = "btnUpdateBookTitle";
            this.btnUpdateBookTitle.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBookTitle.TabIndex = 0;
            this.btnUpdateBookTitle.Text = "Cập nhật";
            this.btnUpdateBookTitle.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBookTitle
            // 
            this.btnRemoveBookTitle.Location = new System.Drawing.Point(275, 15);
            this.btnRemoveBookTitle.Name = "btnRemoveBookTitle";
            this.btnRemoveBookTitle.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveBookTitle.TabIndex = 0;
            this.btnRemoveBookTitle.Text = "Xóa";
            this.btnRemoveBookTitle.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(868, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FManageBookTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 552);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FManageBookTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đầu sách";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageBookTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveBookTitle;
        private System.Windows.Forms.Button btnUpdateBookTitle;
        private System.Windows.Forms.Button btnAddBookTitle;
        private System.Windows.Forms.DataGridView dtgvManageBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn countVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCount;
    }
}