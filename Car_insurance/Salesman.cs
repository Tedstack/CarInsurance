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
    public partial class Salesman : Form
    {
        private string S_id;
        DataSet myDataSet;
        SqlConnection myConn;
        SqlDataAdapter myCommand;
        private int i;
        public Salesman()
        {
            InitializeComponent();
        }
        public Salesman(string ID)
        {
            InitializeComponent();
            S_id = ID;
            this.ControlBox = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.FlatStyle = FlatStyle.Flat;  
            button1.ForeColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;

        }

        private void Salesman_Load(object sender, EventArgs e)
        {

        }

        private void 年度最佳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            try
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                string strCom = "select S_id from Saler where C_number>=10";
                myConn.Open();
                myCommand = new SqlDataAdapter(strCom, myConn);
                myDataSet = new DataSet();
                myCommand.Fill(myDataSet, "table");
                this.dataGridView1.DataSource = myDataSet.Tables["table"];
                myConn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("错误！" + x.ToString(), "error");
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 密码更改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 1;
            reset();
            label1.Text = "原始密码:";
            label2.Text = "新的密码:";
            textBox1.PasswordChar = '*';
            textBox2.PasswordChar = '*';
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                string old_pass = textBox1.Text;
                string new_pass = textBox2.Text;
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    string strCom = "select S_password from Saler where S_password='" + old_pass + "'";
                    myConn.Open();
                    myCommand = new SqlDataAdapter(strCom, myConn);
                    myDataSet = new DataSet();
                    myCommand.Fill(myDataSet, "table");
                    if (myDataSet.Tables["table"].Rows.Count == 0)
                        MessageBox.Show("原始密码不对");
                    else
                    {
                        SqlCommand updatecommand = new SqlCommand();
                        updatecommand.Connection = myConn;
                        string strcom = "update Saler set S_password='" + new_pass + "' where S_password='" + old_pass + "'";
                        updatecommand.CommandText = strcom;
                        updatecommand.ExecuteNonQuery();
                        MessageBox.Show("密码修改正确");

                    }
                    myConn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
                textBox1.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
            }
            else if (i == 2)//插入用户
            {
                string id = textBox1.Text;
                string name = textBox2.Text;
                string phone = textBox3.Text;
                string address = textBox4.Text;
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    string strCom = "select Cu_id from Customer where Cu_id='" + id + "'";
                    myConn.Open();
                    myCommand = new SqlDataAdapter(strCom, myConn);
                    myDataSet = new DataSet();
                    myCommand.Fill(myDataSet, "table");
                    if (myDataSet.Tables["table"].Rows.Count != 0)
                        MessageBox.Show("该ID已经存在");
                    else
                    {
                        SqlCommand updatecommand = new SqlCommand();
                        updatecommand.Connection = myConn;
                        string strcom = "insert into Customer values('" + id + "','" + name + "','" + phone + "','" + address + "','123456','" + S_id + "','')";
                        updatecommand.CommandText = strcom;
                        updatecommand.ExecuteNonQuery();
                        MessageBox.Show("添加成功");
                    }
                    myConn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
            else if (i == 3)
            {
                string id = textBox1.Text;
                string name = textBox2.Text;
                string limit = textBox3.Text;
                string price = textBox4.Text;
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    string strCom = "select P_id from Policy where P_id='" + id + "'";
                    myConn.Open();
                    myCommand = new SqlDataAdapter(strCom, myConn);
                    myDataSet = new DataSet();
                    myCommand.Fill(myDataSet, "table");
                    if (myDataSet.Tables["table"].Rows.Count != 0)
                        MessageBox.Show("该ID已经存在");
                    else
                    {
                        SqlCommand updatecommand = new SqlCommand();
                        updatecommand.Connection = myConn;
                        string strcom = "insert into Policy values('" + id + "','" + name + "','" + limit + "','" + price + "')";
                        updatecommand.CommandText = strcom;
                        updatecommand.ExecuteNonQuery();
                        MessageBox.Show("添加成功");
                    }
                    myConn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
            else if (i == 4)
            {
                string A_id = textBox1.Text;
                string Car_id = textBox2.Text;
                string Damage = textBox3.Text;
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    SqlCommand updatecommand = new SqlCommand();
                    updatecommand.Connection = myConn;
                    string strcom = "insert into Accident values('" + Car_id + "','" + A_id + "','" + Damage + "')";
                    updatecommand.CommandText = strcom;
                    updatecommand.ExecuteNonQuery();
                    MessageBox.Show("添加成功");
                    myConn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
            else if (i == 5)
            {
                string key = comboBox1.Text;
                dataGridView1.AutoGenerateColumns = true;
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    string strCom;
                    if (key == "ID")
                        strCom = "select Cu_id,Cu_name,Cu_phone,Cu_address from Customer where S_id='" + S_id + "' and Cu_id='" + textBox1.Text + "'";
                    else if (key == "姓名")
                        strCom = "select Cu_id,Cu_name,Cu_phone,Cu_address from Customer where S_id='" + S_id + "' and Cu_name like '%" + textBox1.Text + "%'";
                    else if (key == "电话")
                        strCom = "select Cu_id,Cu_name,Cu_phone,Cu_address from Customer where S_id='" + S_id + "' and Cu_phone like '%" + textBox1.Text + "%'";
                    else if (key == "住址")
                        strCom = "select Cu_id,Cu_name,Cu_phone,Cu_address from Customer where S_id='" + S_id + "' and Cu_address like '%" + textBox1.Text + "%'";
                    else
                        strCom = "select Cu_id,Cu_name,Cu_phone,Cu_address from Customer where S_id='" + S_id + "'";
                    myConn.Open();
                    myCommand = new SqlDataAdapter(strCom, myConn);
                    myDataSet = new DataSet();
                    myCommand.Fill(myDataSet, "table");
                    if (myDataSet.Tables["table"].Rows.Count == 0)
                        MessageBox.Show("该用户不存在");
                    else
                        this.dataGridView1.DataSource = myDataSet.Tables["table"];
                    myConn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
            else if (i == 6)
            {
                string key = comboBox1.Text;
                dataGridView1.AutoGenerateColumns = true;
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    string strCom;
                    if (key == "车辆编号")
                        strCom = "select A_id,Car_id,Damage_report from Accident where Car_id='" + textBox1.Text + "'";
                    else
                        strCom = "select A_id,Car_id,Damage_report from Accident where Accident='" + textBox1.Text + "'";
                    myConn.Open();
                    myCommand = new SqlDataAdapter(strCom, myConn);
                    myDataSet = new DataSet();
                    myCommand.Fill(myDataSet, "table");
                    if (myDataSet.Tables["table"].Rows.Count == 0)
                        MessageBox.Show("该用户不存在");
                    else
                        this.dataGridView1.DataSource = myDataSet.Tables["table"];
                    myConn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
            else if (i == 7)
            {
                string key = comboBox1.Text;
                dataGridView1.AutoGenerateColumns = true;
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    string strCom;
                    if (key == "保险编号")
                        strCom = "select P_id,P_name,P_price from Policy where P_id='" + textBox1.Text + "'";
                    else
                        strCom = "select P_id,P_name,P_price from Policy where P_name like '%" + textBox1.Text + "%'";
                    myConn.Open();
                    myCommand = new SqlDataAdapter(strCom, myConn);
                    myDataSet = new DataSet();
                    myCommand.Fill(myDataSet, "table");
                    if (myDataSet.Tables["table"].Rows.Count == 0)
                        MessageBox.Show("该保险不存在");
                    else
                        this.dataGridView1.DataSource = myDataSet.Tables["table"];
                    myConn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
            else
                MessageBox.Show("请选择功能");
        }
        public void reset()
        {
            i = 0;
            comboBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void 插入用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            label1.Text = "用户编号";
            label2.Text = "用户姓名";
            label3.Text = "用户电话";
            label4.Text = "用户地址";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            i = 2;
        }

        private void 插入保险ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            label1.Text = "保险编号";
            label2.Text = "保险名称";
            label3.Text = "保险额度";
            label4.Text = "保险价格";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            i = 3;
        }

        private void 插入事故ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            label1.Text = "车辆编号"; 
            label2.Text = "事故编号";
            label3.Text = "损害报告";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            i = 4;
        }

        private void 客户查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            textBox1.Text = "";
            textBox1.Visible = true;
            comboBox1.Visible = true;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("ID");
            comboBox1.Items.Add("姓名");
            comboBox1.Items.Add("电话");
            comboBox1.Items.Add("住址");
            comboBox1.Items.Add("全部查询");
            i = 5;
        }

        private void 事故查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            comboBox1.Visible = true;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("车辆编号");
            comboBox1.Items.Add("事故编号");
            textBox1.Visible = true;
            i = 6;
        }

        private void 保险查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            comboBox1.Visible = true;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("保险编号");
            comboBox1.Items.Add("保险名称");
            textBox1.Visible = true;
            i = 7;
        }
    }
}
