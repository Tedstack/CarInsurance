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
    public partial class Register : Form
    {
        DataSet myDataSet;
        SqlConnection myConn;
        SqlDataAdapter myCommand;
        public Register()
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)13) && (e.KeyChar != (char)8)
                  && (!((((TextBox)sender).Text == "") && (e.KeyChar == (char)45))))
            {
                e.Handled = true;
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_id.Text = "";
            textBox_id.Font = new Font(textBox_id.Font, textBox_id.Font.Style ^ FontStyle.Italic);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Width = 739;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.Width = 410;
            this.Height = 524;
            dataGridView1.AutoGenerateColumns = true;
            try
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                string strCom = "select S_id,C_number from Saler order by C_number";
                myConn.Open();
                myCommand = new SqlDataAdapter(strCom, myConn);
                myDataSet = new DataSet();
                myCommand.Fill(myDataSet, "Saler");
                this.dataGridView1.DataSource = myDataSet.Tables["Saler"];
                myConn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("错误！" + x.ToString(), "error");
            }
        }

        private void button1_Click(object sender, EventArgs e)//登录
        {
            string ID = textBox_id.Text;
            string Name = textBox2.Text;
            string Phone= textBox3.Text;
            string Address = textBox4.Text;
            string Password = textBox_pass.Text;
            string Again = textBox_again.Text;
            string s_id = textBox_s.Text;
            if (ID == "" || Password == "" || Again == "" || s_id == "")
                MessageBox.Show("信息不完整！");
            else if (Password != Again)
                MessageBox.Show("密码输入有误！");
            else
            {
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    string strCom = "select Cu_id from Customer where Cu_id='"+ID+"'";
                    myConn.Open();
                    myCommand = new SqlDataAdapter(strCom, myConn);
                    myDataSet = new DataSet();
                    myCommand.Fill(myDataSet, "Table");
                    if (myDataSet.Tables["Table"].Rows.Count == 0)
                    {
                        strCom = "select S_id from Saler where S_id='" + s_id + "'";
                        myCommand = new SqlDataAdapter(strCom, myConn);
                        myDataSet.Clear();
                        myCommand.Fill(myDataSet, "Table");
                        if(myDataSet.Tables["Table"].Rows.Count == 0)
                            MessageBox.Show("该销售员不存在！");
                        else
                        {
                            SqlCommand insertcommand = new SqlCommand();
                            insertcommand.Connection = myConn;
                            strCon = "insert into Customer values('"+ID+"','"+Name+"','"+Phone+"','"+Address+"','"+Password+"','"+s_id+"')";
                            insertcommand.CommandText = strCon;
                            insertcommand.ExecuteNonQuery();
                            MessageBox.Show("注册成功");
                        }
                    }
                    else
                        MessageBox.Show("该用户已经存在！");
                    myConn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
        }

        private void textBox_pass_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_pass.Text = "";
            textBox_pass.PasswordChar = '*';
            textBox_pass.Font = new Font(textBox_id.Font, textBox_id.Font.Style ^ FontStyle.Italic);
        }
    }
}
