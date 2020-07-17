using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Car_insurance
{
    public partial class Login : Form
    {
        DataSet myDataSet;
        SqlConnection myConn;
        SqlDataAdapter myCommand;
        public Login()
        {
            InitializeComponent();
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.BackColor = Color.Transparent; 
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string role;
            string tablename;
            string str;
            role = comboBox1.Text;
            if (role == "")
                MessageBox.Show("请选择身份");
            else
            {
                if (role == "Customer")
                {
                    tablename = "Customer";
                    role = "Cu";
                }
                else
                {
                    tablename = "Saler";
                    role = "S";
                }
                if (textBox1.Text == "" || textBox2.Text == "")
                    MessageBox.Show("信息输入不完整");
                else
                {
                    string ID;
                    ID = textBox1.Text;
                    string Password;
                    Password = textBox2.Text;
                    try
                    {
                        string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                        myConn = new SqlConnection(strCon);
                        string strCom = "select * from "+tablename+" where "+role+"_id='" + ID + "'";
                        myConn.Open();
                        myCommand = new SqlDataAdapter(strCom, myConn);
                        myDataSet = new DataSet();
                        myCommand.Fill(myDataSet, "Login");
                        if (myDataSet.Tables["Login"].Rows.Count == 0)
                            MessageBox.Show("该用户不存在。");                      
                        else
                        {
                            str = myDataSet.Tables["Login"].Rows[0][0].ToString();
                            str = str.Substring(0, ID.Length);
                            strCom = "select "+role+ "_password from " + tablename + "  where " + role + "_id='" + ID + "'";
                            myCommand = new SqlDataAdapter(strCom, myConn);
                            myDataSet = new DataSet();
                            myCommand.Fill(myDataSet, "Login");
                            str = myDataSet.Tables["Login"].Rows[0][0].ToString();
                            str = str.Trim();
                            if (str != Password)
                                MessageBox.Show("密码错误。");
                            else
                            {
                                if(role=="Cu")
                                {
                                    Customer C = new Customer(ID);
                                    this.Hide();
                                    C.Show();
                                }
                                else
                                {
                                    Salesman S = new Salesman(ID);
                                    this.Hide();
                                    S.Show();
                                }
                            }
                        }
                        myConn.Close();
                    }
                    catch (Exception x)
                    {
                        //MessageBox.Show("错误！" + x.ToString(), "error");
                    }
                }
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Customer")
                pictureBox2.Image = Image.FromFile(@"D:\Study\大二学习资料\数据库\Car_insurance\picture\02.jpg");
            else
                pictureBox2.Image = Image.FromFile(@"D:\Study\大二学习资料\数据库\Car_insurance\picture\01.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register R1 = new Register();
            R1.Show();
        }
    }
}
