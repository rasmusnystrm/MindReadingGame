using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alex
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            new Form9().ShowDialog();
        }
    }
}
