using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using MySqlConnector;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        public static string Id;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text.Trim();
            String USerpaw = textBox2.Text.Trim();
            if (Username.Equals("") || USerpaw.Equals(""))
            {
                MessageBox.Show("账号密码不能为空！");
            }
            else
            {
                string connStr = "Data Source=星月;Initial Catalog=Db;User ID = sa;Password=123456";
                SqlConnection con = new SqlConnection(connStr);
                con.Open();
                string sql = "select * from [user] where username ='" + Username + "'and userpaw ='" + USerpaw + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("登录成功！");
                    Form3 f3 = new Form3();
                    Id = Username;
                    this.Hide();
                    f3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("登录失败！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }






            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();//想要打开的窗体界面
            this.Hide();//隐藏当前窗体 
            form2.ShowDialog();
            Application.ExitThread();

        }
    }
}