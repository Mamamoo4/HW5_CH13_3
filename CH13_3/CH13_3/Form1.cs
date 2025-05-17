using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Red;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    label1.BackColor = Color.Yellow;
                    break;
                case MouseButtons.Right:
                    label1.BackColor = Color.Green;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }
    }
}
