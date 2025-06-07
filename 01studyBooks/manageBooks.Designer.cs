namespace _01studyBooks
{
    partial class manageBooks
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
            this.dataTables = new System.Windows.Forms.DataGridView();
            this.Seach = new System.Windows.Forms.Button();
            this.SeachText = new System.Windows.Forms.TextBox();
            this.DownBook = new System.Windows.Forms.Button();
            this.UpdataBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newSeach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTables
            // 
            this.dataTables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataTables.Location = new System.Drawing.Point(23, 130);
            this.dataTables.Name = "dataTables";
            this.dataTables.RowHeadersWidth = 51;
            this.dataTables.RowTemplate.Height = 27;
            this.dataTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTables.Size = new System.Drawing.Size(1304, 467);
            this.dataTables.TabIndex = 0;
            this.dataTables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTables_CellClick);
            this.dataTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Seach
            // 
            this.Seach.BackColor = System.Drawing.Color.Aqua;
            this.Seach.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Seach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Seach.Location = new System.Drawing.Point(1102, 78);
            this.Seach.Name = "Seach";
            this.Seach.Size = new System.Drawing.Size(100, 40);
            this.Seach.TabIndex = 1;
            this.Seach.Text = "搜索";
            this.Seach.UseVisualStyleBackColor = false;
            this.Seach.Click += new System.EventHandler(this.Seach_Click);
            // 
            // SeachText
            // 
            this.SeachText.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SeachText.Location = new System.Drawing.Point(830, 80);
            this.SeachText.Name = "SeachText";
            this.SeachText.Size = new System.Drawing.Size(255, 38);
            this.SeachText.TabIndex = 2;
            this.SeachText.TextChanged += new System.EventHandler(this.SeachText_TextChanged);
            // 
            // DownBook
            // 
            this.DownBook.BackColor = System.Drawing.Color.Red;
            this.DownBook.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DownBook.ForeColor = System.Drawing.Color.Transparent;
            this.DownBook.Location = new System.Drawing.Point(23, 603);
            this.DownBook.Name = "DownBook";
            this.DownBook.Size = new System.Drawing.Size(125, 40);
            this.DownBook.TabIndex = 3;
            this.DownBook.Text = "下架图书";
            this.DownBook.UseVisualStyleBackColor = false;
            this.DownBook.Click += new System.EventHandler(this.DownBook_Click);
            // 
            // UpdataBook
            // 
            this.UpdataBook.BackColor = System.Drawing.Color.Lime;
            this.UpdataBook.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UpdataBook.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdataBook.Location = new System.Drawing.Point(174, 603);
            this.UpdataBook.Name = "UpdataBook";
            this.UpdataBook.Size = new System.Drawing.Size(127, 40);
            this.UpdataBook.TabIndex = 4;
            this.UpdataBook.Text = "修改图书";
            this.UpdataBook.UseVisualStyleBackColor = false;
            this.UpdataBook.Click += new System.EventHandler(this.UpdataBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "图书编号";
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Location = new System.Drawing.Point(130, 75);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(19, 19);
            this.textName.TabIndex = 6;
            this.textName.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(52, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "选中书名";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textID
            // 
            this.textID.AutoSize = true;
            this.textID.Location = new System.Drawing.Point(130, 25);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(19, 19);
            this.textID.TabIndex = 8;
            this.textID.Text = " ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "图书编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "书名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "作者";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出版社";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "出版日期";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "图书类型";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "价格";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "库存";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "简介";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "租借次数";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // newSeach
            // 
            this.newSeach.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newSeach.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newSeach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newSeach.Location = new System.Drawing.Point(1227, 78);
            this.newSeach.Name = "newSeach";
            this.newSeach.Size = new System.Drawing.Size(100, 40);
            this.newSeach.TabIndex = 9;
            this.newSeach.Text = "重置";
            this.newSeach.UseVisualStyleBackColor = false;
            this.newSeach.Click += new System.EventHandler(this.newSeach_Click);
            // 
            // manageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 665);
            this.Controls.Add(this.newSeach);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdataBook);
            this.Controls.Add(this.DownBook);
            this.Controls.Add(this.SeachText);
            this.Controls.Add(this.Seach);
            this.Controls.Add(this.dataTables);
            this.Name = "manageBooks";
            this.Text = "manageBooks";
            this.Load += new System.EventHandler(this.manageBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTables;
        private System.Windows.Forms.Button Seach;
        private System.Windows.Forms.TextBox SeachText;
        private System.Windows.Forms.Button DownBook;
        private System.Windows.Forms.Button UpdataBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button newSeach;
    }
}