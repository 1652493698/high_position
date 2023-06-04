using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();//想要打开的窗体界面
            this.Hide();//隐藏当前窗体 
            form1.ShowDialog();
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String userid = textBox1.Text.Trim();
            String userpaw = textBox3.Text.Trim();
            String userpawd = textBox2.Text.Trim();
            if (userid.Equals("") || userpaw.Equals(""))
            {
                MessageBox.Show("账号或密码不能为空！");
            }
            else if (userpaw.Equals("") || userpaw != userpawd)
            {
                MessageBox.Show("请重新输入确认密码！");
            }
            else
            {
                string connStr = "Data Source=星月;Initial Catalog=Db;User ID = sa;Password=123456";
                SqlConnection con = new SqlConnection(connStr);
                con.Open();
                String sqlCheck = "select username from [User] where username='" + userid + "'";
                SqlCommand checkcommand = new SqlCommand(sqlCheck, con);
                checkcommand.CommandType = CommandType.Text;
                SqlDataReader reader;
                reader = checkcommand.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("该用户名已存在，请重新输入");

                }
                else {
                    reader.Close();
                    string s1 = "insert into [User](username,userpaw) values ('" + userid + "','" + userpaw + "')";
                    SqlCommand insertCommand = new SqlCommand(s1, con); //初始化命令
                    insertCommand.ExecuteNonQuery(); //执行命令
                    
                    MessageBox.Show("注册成功");
                    //关闭数据库的连接
                    con.Close();
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.ShowDialog();

                }
               
            }
        }
    }
}
