using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L12GUI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(string.Format("You pressed {0} key ", e.KeyChar.ToString()), "Key Pressed");
        }
    }
}
