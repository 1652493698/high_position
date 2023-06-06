using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public static int zm=0;
        public static string zmID = "";
        public Form4()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (zm == 0) {
                MessageBox.Show("恭喜加入烈火宗！");
                Form3 f3 = new Form3();
                zmID = "烈火宗";
                zm = 1;
                this.Hide();
                f3.ShowDialog();
            }
            
        }
    }
}
