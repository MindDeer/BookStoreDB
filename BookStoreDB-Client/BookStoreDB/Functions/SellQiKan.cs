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

namespace BookStoreDB.Functions
{
    public partial class SellQiKan : Form
    {
        private static long SellNumber = long.Parse(DateTime.Today.ToString("yyyyMMdd") + "0000");
        int count = 0;
        int tip = 0;
        public SellQiKan()
        {
            InitializeComponent();
            SellNumber++;
            textBoxID.Text = (SellNumber).ToString();
        }
        private void pictureBox刷新_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("p_listsellcopy2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();  //清单上列出刷新后的表
            ShowTable(dataGridView1, cmd);
            tip = dataGridView1.RowCount;

            textBox1.Text = "";

        }
        private void pictureBox清空_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("p_clearsellcopy2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();  //执行零时存储表的清空
            cmd = new SqlCommand("p_listsellcopy2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();  //清单上列出清空后的表
            ShowTable(dataGridView1, cmd);
            lbMessage.Text = "清除完毕";
        }

        private void button取消_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确认取消该订单吗？");
            SqlCommand cmd = new SqlCommand("p_clearsellcopy2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();  //执行零时存储表的清空
            cmd = new SqlCommand("p_listsellcopy2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();  //清单上列出清空后的表
            ShowTable(dataGridView1, cmd);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button售货_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("p_addsellcopy1", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Char);
            cmd.Parameters.Add("@copyid", SqlDbType.Char);
            cmd.Parameters.Add("@money", SqlDbType.Decimal);
            cmd.Parameters.Add("@admin", SqlDbType.Char);
            cmd.Parameters.Add("@tips", SqlDbType.Char);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                cmd.Parameters["@id"].Value = textBoxID.Text;
                cmd.Parameters["@copyid"].Value = dataGridView1.Rows[i].Cells[1].Value.ToString();
                cmd.Parameters["@money"].Value = dataGridView1.Rows[i].Cells[6].Value.ToString();
                cmd.Parameters["@admin"].Value = MainForm.getAccountId();
                cmd.Parameters["@tips"].Value = textBox5.Text;
                try
                {
                    cmd.ExecuteNonQuery();  //执行存储过程调用
                    lbMessage.Text = "提示：交易成功！";
                }
                catch (Exception ev)
                {
                    lbMessage.Text = "提示：服务器异常,交易失败";
                    MessageBox.Show(ev.Message);
                }

            }
            SqlCommand cmd1 = new SqlCommand("p_clearsellcopy2", MainForm.conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.ExecuteNonQuery();  //执行零时存储表的清空
            textBoxID.Text = (SellNumber + 1).ToString();

        }

        private void button修改_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("p_updatesellcopy2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@copyid", SqlDbType.Char);
            cmd.Parameters.Add("@tsmc", SqlDbType.Char);
            cmd.Parameters.Add("@code", SqlDbType.Char);
            cmd.Parameters.Add("@author", SqlDbType.Char);
            cmd.Parameters.Add("@press", SqlDbType.Char);
            cmd.Parameters.Add("@money", SqlDbType.Decimal);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True") //这里判断复选框是否选中
                {
                    count++;
                    DataGridViewRow row = dataGridView1.Rows[i];

                    cmd.Parameters["@copyid"].Value = row.Cells[1].Value.ToString();
                    cmd.Parameters["@tsmc"].Value = row.Cells[2].Value.ToString();
                    cmd.Parameters["@code"].Value = row.Cells[3].Value.ToString();
                    cmd.Parameters["@author"].Value = row.Cells[4].Value.ToString();
                    cmd.Parameters["@press"].Value = row.Cells[5].Value.ToString();
                    cmd.Parameters["@money"].Value = Decimal.Parse(row.Cells[6].Value.ToString());
                    try
                    {
                        cmd.ExecuteNonQuery();  //执行存储过程调用
                        lbMessage.Text = "提示：" + count + "条修改成功";
                    }
                    catch (Exception ev)
                    {
                        lbMessage.Text = "提示：服务器异常";
                        MessageBox.Show(ev.Message);
                    }

                    cmd = new SqlCommand("p_listsellcopy2", MainForm.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    ShowTable(dataGridView1, cmd);
                    AddMoney();
                }

            }
        }

        private void button删除_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = null;
            SqlCommand cmd = new SqlCommand("p_deletesellcopy2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True") //这里判断复选框是否选中
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    cmd.Parameters.Add("@copyid", SqlDbType.Char);
                    cmd.Parameters["@copyid"].Value = row.Cells[1].Value.ToString();
                    try
                    {
                        cmd.ExecuteNonQuery();  //执行存储过程调用,删除零时存储表中一条相关数据   
                        count++;
                    }
                    catch (Exception ev)
                    {
                        lbMessage.Text = "提示：服务器异常";
                        MessageBox.Show(ev.Message);
                    }

                    cmd2 = new SqlCommand("p_listsellcopy2", MainForm.conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                    AddMoney();
                }
            }

            ShowTable(dataGridView1, cmd2);   //显示出删除后的列表剩余书目 
            //ShowMoney();
            lbMessage.Text = "提示：" + count + "条删除成功";
            count = 0;
        }

        private void button添加_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("p_insertsellcopy2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@copyid", SqlDbType.Char);
            cmd.Parameters["@copyid"].Value = textBox1.Text;
            try
            {
                cmd.ExecuteNonQuery();  //执行存储过程调用  
                tip = dataGridView1.RowCount;
                lbMessage.Text = "成功添加" + tip + "项";
            }
            catch (Exception ev)
            {
                lbMessage.Text = "添加失败";
                MessageBox.Show(ev.Message);
            }

            SqlCommand cmd2 = new SqlCommand("p_listsellcopy2", MainForm.conn);
            cmd2.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd2.ExecuteNonQuery();
                ShowTable(dataGridView1, cmd2);
                textBox1.Text = "";
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
            AddMoney();
        }

        private void ShowTable(DataGridView DG, SqlCommand cmd)
        {
            SqlDataAdapter dpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dpt.Fill(ds);
            DataTable dtb = ds.Tables[0];

            DG.DataSource = dtb;
            DG.AutoGenerateColumns = false;
            DG.Columns["Column1"].DataPropertyName = dtb.Columns["期刊副本号"].ToString();
            DG.Columns["Column2"].DataPropertyName = dtb.Columns["期刊名称"].ToString();
            DG.Columns["Column3"].DataPropertyName = dtb.Columns["ISSN编号"].ToString();
            DG.Columns["Column4"].DataPropertyName = dtb.Columns["主管单位"].ToString();
            DG.Columns["Column5"].DataPropertyName = dtb.Columns["主办单位"].ToString();
            DG.Columns["Column6"].DataPropertyName = dtb.Columns["价钱"].ToString();

            DG.Columns["Column1"].Visible = false;
            DG.Columns["Column2"].Visible = false;
            DG.Columns["Column3"].Visible = false;
            DG.Columns["Column4"].Visible = false;
            DG.Columns["Column5"].Visible = false;
            DG.Columns["Column6"].Visible = false;

            //DataTable dt = new DataTable();//或直接建表
            //dpt.Fill(dt);
            //BindingSource bs = new BindingSource();
            //bs.DataSource = dt;
            //DG.DataSource = bs;
        }

        private void AddMoney()
        {
            double sum = 0;
            SqlCommand cmd = new SqlCommand("p_sumsellcopy2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sum", SqlDbType.Money);     //输出型参数
            cmd.Parameters["@sum"].Direction = ParameterDirection.Output;
            try
            {
                cmd.ExecuteNonQuery();
                sum = double.Parse(cmd.Parameters["@sum"].Value.ToString());
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
            textBox2.Text = sum.ToString("0.00");
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            double a = double.Parse(textBox3.Text.ToString()) - double.Parse(textBox2.Text.ToString());
            textBox4.Text = a.ToString("0.00");
        }

       
    }
}
