namespace _01studyBooks
{
    partial class AddBook
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
            this.bNameText = new System.Windows.Forms.Label();
            this.Bname = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.intorduce = new System.Windows.Forms.TextBox();
            this.text111 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addBooks = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.bookID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bNameText
            // 
            this.bNameText.AutoSize = true;
            this.bNameText.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bNameText.Location = new System.Drawing.Point(64, 77);
            this.bNameText.Name = "bNameText";
            this.bNameText.Size = new System.Drawing.Size(60, 31);
            this.bNameText.TabIndex = 0;
            this.bNameText.Text = "书名";
            this.bNameText.Click += new System.EventHandler(this.bName_Click);
            // 
            // Bname
            // 
            this.Bname.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bname.Location = new System.Drawing.Point(129, 80);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(340, 31);
            this.Bname.TabIndex = 1;
            this.Bname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Author
            // 
            this.Author.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Author.Location = new System.Drawing.Point(129, 139);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(340, 31);
            this.Author.TabIndex = 3;
            this.Author.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(64, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "作者";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "出版日期";
            // 
            // company
            // 
            this.company.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.company.Location = new System.Drawing.Point(129, 195);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(340, 31);
            this.company.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(41, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "出版社";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.price.Location = new System.Drawing.Point(129, 365);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(340, 31);
            this.price.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(64, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "价格";
            // 
            // bookType
            // 
            this.bookType.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookType.Location = new System.Drawing.Point(129, 306);
            this.bookType.Name = "bookType";
            this.bookType.Size = new System.Drawing.Size(340, 31);
            this.bookType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(63, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "类型";
            // 
            // intorduce
            // 
            this.intorduce.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intorduce.Location = new System.Drawing.Point(129, 479);
            this.intorduce.Name = "intorduce";
            this.intorduce.Size = new System.Drawing.Size(340, 31);
            this.intorduce.TabIndex = 15;
            // 
            // text111
            // 
            this.text111.AutoSize = true;
            this.text111.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text111.Location = new System.Drawing.Point(64, 476);
            this.text111.Name = "text111";
            this.text111.Size = new System.Drawing.Size(60, 31);
            this.text111.TabIndex = 14;
            this.text111.Text = "简介";
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num.Location = new System.Drawing.Point(129, 420);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(340, 31);
            this.num.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(63, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "库存";
            // 
            // addBooks
            // 
            this.addBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addBooks.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addBooks.Location = new System.Drawing.Point(201, 548);
            this.addBooks.Name = "addBooks";
            this.addBooks.Size = new System.Drawing.Size(135, 50);
            this.addBooks.TabIndex = 16;
            this.addBooks.Text = "确认";
            this.addBooks.UseCompatibleTextRendering = true;
            this.addBooks.UseVisualStyleBackColor = false;
            this.addBooks.Click += new System.EventHandler(this.addBooks_Click);
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTime.Location = new System.Drawing.Point(129, 254);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(340, 31);
            this.dateTime.TabIndex = 17;
            // 
            // bookID
            // 
            this.bookID.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookID.Location = new System.Drawing.Point(129, 27);
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(340, 31);
            this.bookID.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "图书编号";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 610);
            this.Controls.Add(this.bookID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.addBooks);
            this.Controls.Add(this.intorduce);
            this.Controls.Add(this.text111);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.company);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.bNameText);
            this.Name = "AddBook";
            this.Text = "添加图书";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bNameText;
        private System.Windows.Forms.TextBox Bname;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox company;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox intorduce;
        private System.Windows.Forms.Label text111;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBooks;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox bookID;
        private System.Windows.Forms.Label label6;
    }
}