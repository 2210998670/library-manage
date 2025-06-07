namespace _01studyBooks
{
    partial class Index
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
            this.newName = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newName
            // 
            this.newName.AutoSize = true;
            this.newName.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newName.ForeColor = System.Drawing.Color.SandyBrown;
            this.newName.Location = new System.Drawing.Point(175, 89);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(164, 46);
            this.newName.TabIndex = 0;
            this.newName.Text = "label1";
            this.newName.Click += new System.EventHandler(this.newName_Click);
            // 
            // newPass
            // 
            this.newPass.AutoSize = true;
            this.newPass.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPass.ForeColor = System.Drawing.Color.SpringGreen;
            this.newPass.Location = new System.Drawing.Point(270, 225);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(164, 46);
            this.newPass.TabIndex = 1;
            this.newPass.Text = "label1";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.newName);
            this.Name = "Index";
            this.Text = "Index";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Index_FormClosing);
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newName;
        private System.Windows.Forms.Label newPass;
    }
}