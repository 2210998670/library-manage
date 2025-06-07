using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01studyBooks
{
    public class AutoClosingMessageBox : Form
    {
        private Timer timer;

        public AutoClosingMessageBox(string message, string title, int durationMilliseconds)
        {
            this.Text = title;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(300, 100);
            this.TopMost = true;

            Label lbl = new Label()
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10),
            };
            this.Controls.Add(lbl);

            timer = new Timer();
            timer.Interval = durationMilliseconds;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Close();
            };
        }

        public static void Show(string message, string title = "提示", int durationMilliseconds = 2000)
        {
            AutoClosingMessageBox msg = new AutoClosingMessageBox(message, title, durationMilliseconds);
            msg.Show();
            msg.timer.Start();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AutoClosingMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "AutoClosingMessageBox";
            this.Load += new System.EventHandler(this.AutoClosingMessageBox_Load);
            this.ResumeLayout(false);

        }

        private void AutoClosingMessageBox_Load(object sender, EventArgs e)
        {

        }
    }

}
