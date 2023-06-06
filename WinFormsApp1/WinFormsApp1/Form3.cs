using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public static int t=0;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.Id;
           
            if (Form4.zmID == "")
            {
                label5.Text = "无";
            }
            else
            {
                label5.Text = Form4.zmID;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            if (openfile.ShowDialog() == DialogResult.OK && (openFileDialog1.FileName != "")) ;
            {
                pictureBox1.ImageLocation = openfile.FileName;

            }

            openfile.Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //灵根模块
        private static int count = 0;//标识
        private void button1_Click(object sender, EventArgs e)
        {


            if (count == 0)
            {
                Random ran = new Random();
                int n = ran.Next(1, 10);
                switch (n)
                {
                    case 1:
                        MessageBox.Show("鉴定成功，您的灵根为：木灵根！");
                        label11.Text = "木";
                        break;
                    case 2:
                        MessageBox.Show("鉴定成功，您的灵根为：金灵根！");
                        label11.Text = "金";
                        break;
                    case 3:
                        MessageBox.Show("鉴定成功，您的灵根为：水灵根！");
                        label11.Text = "水";
                        break;
                    case 4:
                        MessageBox.Show("鉴定成功，您的灵根为：火灵根！");
                        label11.Text = "火";
                        break;
                    case 5:
                        MessageBox.Show("鉴定成功，您的灵根为：土灵根！");
                        label11.Text = "土";
                        break;


                }


                count++;


            }
            else
            {
                MessageBox.Show("已鉴定，无法重新鉴定");
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //充值
        private void button2_Click(object sender, EventArgs e)
        {
            string xs = label13.Text;
            int ys = Convert.ToInt32(xs);
            ys = ys + 648;
            label13.Text = Convert.ToString(ys);
        }

        //加入宗门
        private void button3_Click(object sender, EventArgs e)
        {
            if (Form4.zm == 0)
            {
                Form4 f4 = new Form4();
                this.Hide();
                f4.ShowDialog();
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //宗门管理页面
        private void button4_Click(object sender, EventArgs e)
        {
            if (Form4.zm == 1) {
                Form5 f5 = new Form5();
                this.Hide();
                f5.ShowDialog();
            }
        }
    }
}
