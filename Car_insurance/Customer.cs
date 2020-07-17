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
    public partial class Customer : Form
    {
        DataSet myDataSet;
        SqlConnection myConn;
        SqlDataAdapter myCommand;
        private string Cu_id;
        private int i;
        public Customer()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public Customer(string Cu_id)
        {
            InitializeComponent();
            this.Cu_id = Cu_id;
            this.ControlBox = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.ForeColor = Color.Transparent;
            button_search.BackColor = Color.Transparent;
            button_search.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            textBox_ID.Text = Cu_id;
            try
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                SqlConnection myConn = new SqlConnection(strCon);
                string strCom = "SELECT * FROM Customer where Cu_id ='" + this.Cu_id + "'";
                myConn.Open();
                myCommand = new SqlDataAdapter(strCom, myConn);
                myDataSet = new DataSet();
                myCommand.Fill(myDataSet, "table");
                textBox_Name.Text = myDataSet.Tables["table"].Rows[0][1].ToString();
                textBox_Phone.Text= myDataSet.Tables["table"].Rows[0][2].ToString();
                textBox_Address.Text= myDataSet.Tables["table"].Rows[0][3].ToString();
                textBox_password.Text= myDataSet.Tables["table"].Rows[0][4].ToString().Substring(0,6);
                textBox_Saler.Text= myDataSet.Tables["table"].Rows[0][5].ToString();
                myConn.Close();
            }
            catch (Exception x)
            { MessageBox.Show("错误！" + x.ToString(), "error"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                SqlCommand updatecommand = new SqlCommand();
                updatecommand.Connection = myConn;
                myConn.Open();
                string strcom = "update Customer set Avatar='" + openFileDialog1.FileName + "'where Cu_id='" + Cu_id + "'";
                updatecommand.CommandText = strcom;
                updatecommand.ExecuteNonQuery();
                myConn.Close();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text=="Modify")
            {
                button2.Text = "Confirm";
                textBox_Name.Enabled = true;
                textBox_Address.Enabled = true;
                textBox_Phone.Enabled = true;
                textBox_password.Enabled = true;
                textBox_password.PasswordChar = '\0';
            }
            else
            {
                button2.Text = "Modify";
                textBox_Name.Enabled = false;
                textBox_Address.Enabled = false;
                textBox_Phone.Enabled = false;
                textBox_password.Enabled = false;
                textBox_password.PasswordChar = '*';
                //..............................................
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                SqlCommand updatecommand = new SqlCommand();
                updatecommand.Connection = myConn;
                myConn.Open();
                string strcom = "update Customer set Cu_name='"+textBox_Name.Text+"',Cu_phone='"+textBox_Phone.Text+"',Cu_address='"+textBox_Address.Text+"',Cu_password='"+textBox_password.Text+"'where Cu_id = '"+ Cu_id+"'";
                updatecommand.CommandText = strcom;
                updatecommand.ExecuteNonQuery();
                myConn.Close();
            }
        }

        private void 全部车辆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.AutoGenerateColumns = true;
            try
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                string strCom = "select Car_id,Cu_id,Damage_number from Car where Cu_id='"+Cu_id+"'";
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

        private void 添加车辆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Car.Text = "";
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            label7.Visible = true;
            label8.Visible = false;
            comboBox1.Visible = false;
            button3.Visible = true;
            button_search.Visible = false;
            i = 3;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string lie,table;
            string Name = comboBox1.Text;
            if (Name == "车牌编号")
                lie = "Car_id";
            else
                lie = "A_id";
            if (i == 0)
                table = "Accident";
            else
                table = "Payment";
            dataGridView1.AutoGenerateColumns = true;
            try
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                string strCom = "select * from "+table+" where "+lie+"='" + textBox_Car.Text + "'";
                myConn.Open();
                myCommand = new SqlDataAdapter(strCom, myConn);
                myDataSet = new DataSet();
                myCommand.Fill(myDataSet, "table");
                if (myDataSet.Tables["table"].Rows.Count == 0)
                    MessageBox.Show("该事故不存在");
                else
                    this.dataGridView1.DataSource = myDataSet.Tables["table"];              
                myConn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("错误！" + x.ToString(), "error");
            }
            dataGridView1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i == 3)
            {
                string Car_id = textBox_Car.Text;
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);

                    SqlCommand updatecommand = new SqlCommand();
                    updatecommand.Connection = myConn;
                    myConn.Open();
                    string strcom = "insert into Car values('" + Car_id + "','" + Cu_id + "',0)";
                    updatecommand.CommandText = strcom;
                    updatecommand.ExecuteNonQuery();
                    MessageBox.Show("添加成功。");
                    myConn.Close();
                    dataGridView1.Visible = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
            else if (i == 4)
            {
                string P_id = textBox_Car.Text;
                string Car_id = textBox1.Text;
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    SqlCommand updatecommand = new SqlCommand();
                    updatecommand.Connection = myConn;
                    string strcom = "insert into Taking values('" + P_id + "','" + Car_id + "',dateadd(year,1,GETDATE()))";
                    updatecommand.CommandText = strcom;
                    updatecommand.ExecuteNonQuery();
                    MessageBox.Show("添加成功。");
                    myConn.Close();
                    label8.Visible = false;
                    textBox1.Visible = false;
                    dataGridView1.Visible = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
            else if (i == 5)
            {
                string P_id = textBox_Car.Text;
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    SqlCommand updatecommand = new SqlCommand();
                    updatecommand.Connection = myConn;
                    myConn.Open();
                    string strcom = "update  Taking set End_time=dateadd(year,1,End_time) where P_id='" + P_id + "'";
                    updatecommand.CommandText = strcom;
                    updatecommand.ExecuteNonQuery();
                    MessageBox.Show("续费成功。");
                    myConn.Close();
                    label8.Visible = false;
                    textBox1.Visible = false;
                    dataGridView1.Visible = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
            else if (i == 6)
            {
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    string namepro = "D_Car";
                    SqlCommand com = new SqlCommand(namepro, myConn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Car_id", textBox_Car.Text);
                    myConn.Open();
                    com.ExecuteNonQuery();
                    myConn.Close();
                    label8.Visible = false;
                    textBox1.Visible = false;
                    dataGridView1.Visible = true;
                    MessageBox.Show("删除成功");
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
            else if (i == 7)
            {
                try
                {
                    string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                    myConn = new SqlConnection(strCon);
                    string namepro = "D_Policy";
                    SqlCommand com = new SqlCommand(namepro, myConn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@P_id", textBox_Car.Text);
                    myConn.Open();
                    com.ExecuteNonQuery();
                    myConn.Close();
                    label8.Visible = false;
                    textBox1.Visible = false;
                    dataGridView1.Visible = true;
                    MessageBox.Show("删除成功");
                }
                catch (Exception x)
                {
                    MessageBox.Show("错误！" + x.ToString(), "error");
                }
            }
        }

        private void 已经购买ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.AutoGenerateColumns = true;
            try
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                string strCom = "select Policy.P_id,P_name,P_price,Limit_compensation from Taking, Policy, Car where Car.Cu_id = '"+
                    Cu_id+"'and Taking.Car_id = Car.Car_id and Policy.P_id = Taking.P_id";
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

        private void 全部种类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.AutoGenerateColumns = true;
            try
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                string strCom = "select distinct P_name,p_price,Limit_compensation from Policy";
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

        private void 即将过期ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.AutoGenerateColumns = true;
            try
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                string namepro = "Policy_P";
                myConn.Open();
                SqlCommand com = new SqlCommand(namepro, myConn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Cu_id", Cu_id);
                myCommand = new SqlDataAdapter();
                myCommand.SelectCommand = com;
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

        private void 事故查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Car.Text = "";
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox1.Visible = false;
            comboBox1.Visible = true;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("车牌编号");
            comboBox1.Items.Add("事故编号");
            button3.Visible = false;
            button_search.Visible = true;
            i = 0;
        }

        private void 查询赔偿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Car.Text = "";
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox1.Visible = false;
            comboBox1.Visible = true;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("车牌编号");
            comboBox1.Items.Add("事故编号");
            button3.Visible = false;
            button_search.Visible = true;
            i = 1;
        }

        private void 新的保险ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 4;
            comboBox1.Visible = false;
            label7.Visible = true;
            label8.Visible = true;
            textBox1.Visible = true;
            dataGridView1.Visible=false;
            label7.Text = "保险单号";
            dataGridView2.AutoGenerateColumns = true;
            try
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                string strCom = "select  P_id,P_name,p_price,Limit_compensation from Policy where P_id not in(select P_id from Taking)";
                myConn.Open();
                myCommand = new SqlDataAdapter(strCom, myConn);
                myDataSet = new DataSet();
                myCommand.Fill(myDataSet, "table");
                this.dataGridView2.DataSource = myDataSet.Tables["table"];
                myConn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("错误！" + x.ToString(), "error");
            }
        }

        private void 保险续费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 5;
            comboBox1.Visible = false;
            label7.Visible = true;
            label8.Visible = false;
            textBox1.Visible = false;
            textBox_Car.Text = "";
            dataGridView1.Visible = false;
            label7.Text = "保险单号";
            dataGridView2.AutoGenerateColumns = true;
            try
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                string strCom = "select  Car.Car_id,P_id,P_name,p_price,Limit_compensation from Policy where P_id in(select P_id from Taking)";
                myConn.Open();
                myCommand = new SqlDataAdapter(strCom, myConn);
                myDataSet = new DataSet();
                myCommand.Fill(myDataSet, "table");
                this.dataGridView2.DataSource = myDataSet.Tables["table"];
                myConn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("错误！" + x.ToString(), "error");
            }
        }

        private void 删除车辆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            textBox_Car.Text = "";
            label7.Visible = true;
            label8.Visible = false;
            comboBox1.Visible = false;
            button3.Visible = true;
            button_search.Visible = false;
            i = 6;
        }

        private void 更改保险ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 7;
            comboBox1.Visible = false;
            label7.Visible = true;
            label8.Visible = false;
            textBox1.Visible = false;
            dataGridView1.Visible = false;
            label7.Text = "保险单号";
            dataGridView2.Visible = true;
            dataGridView2.AutoGenerateColumns = true;
            try
            {
                string strCon = "Data Source=DESKTOP-MMB6R67;Initial Catalog=Car_insurance;User ID=sa;Password=123456";
                myConn = new SqlConnection(strCon);
                string strCom = "select Car.Car_id,Policy.P_id,P_name,P_price,Limit_compensation from Taking, Policy, Car where Car.Cu_id = '" +
                    Cu_id + "'and Taking.Car_id = Car.Car_id and Policy.P_id = Taking.P_id";
                myConn.Open();
                myCommand = new SqlDataAdapter(strCom, myConn);
                myDataSet = new DataSet();
                myCommand.Fill(myDataSet, "table");
                this.dataGridView2.DataSource = myDataSet.Tables["table"];
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
    }
}
