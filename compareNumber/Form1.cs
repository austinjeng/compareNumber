using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compareNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            this.Visible = false;
            f2.Visible = true;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            this.Visible = false;
            f3.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感謝遊玩!");
            Application.Exit();
        }
    }
}
