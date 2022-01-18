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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void backToForm1Button_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            this.Visible = false;
            f1.Visible = true;
        }
    }
}
