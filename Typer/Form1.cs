using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tmrNewMsg.Enabled == true)
            {
                tmrNewMsg.Stop();
                lblTypingIndicator.Text = "Not Typing";
            }
            else
            {
                tmrNewMsg.Start();
                lblTypingIndicator.Text = "Typing...";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.AppendText("{ENTER}");
        }
    }
}
