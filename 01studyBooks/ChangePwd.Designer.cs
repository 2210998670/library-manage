﻿namespace _01studyBooks
{
    partial class ChangePwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.oldPwd = new System.Windows.Forms.TextBox();
            this.newPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enterNewPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码";
            // 
            // oldPwd
            // 
            this.oldPwd.Location = new System.Drawing.Point(104, 91);
            this.oldPwd.Name = "oldPwd";
            this.oldPwd.Size = new System.Drawing.Size(214, 25);
            this.oldPwd.TabIndex = 1;
            // 
            // newPwd
            // 
            this.newPwd.Location = new System.Drawing.Point(104, 166);
            this.newPwd.Name = "newPwd";
            this.newPwd.Size = new System.Drawing.Size(214, 25);
            this.newPwd.TabIndex = 3;
            this.newPwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(30, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码";
            // 
            // enterNewPwd
            // 
            this.enterNewPwd.Location = new System.Drawing.Point(104, 248);
            this.enterNewPwd.Name = "enterNewPwd";
            this.enterNewPwd.Size = new System.Drawing.Size(214, 25);
            this.enterNewPwd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(133, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enterNewPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPwd);
            this.Controls.Add(this.label1);
            this.Name = "ChangePwd";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.ChangePwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPwd;
        private System.Windows.Forms.TextBox newPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enterNewPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}