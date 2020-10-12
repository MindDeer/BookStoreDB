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
    public partial class InsertUser : Form
    {
        SqlCommand cmd = null;
        public InsertUser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //radioButton1.Checked = true;--将执行两次插入，导致与主键冲突
            textBox1.Text = MainForm.getAccountId().ToString();
            dataGridView1.Columns["Column9"].Visible = false;
            buttonOK.Click += buttonOK_Click;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;           

            cmd = new SqlCommand("p_listDZ", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();  //执行存储过程调用
            ShowTable(dataGridView1, cmd);
            if (MainForm.getAccountId() == 14001 || MainForm.getAccountId() == 14002)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[5].ReadOnly = true;
                    dataGridView1.Rows[i].Cells[5].Value = "******";
                }
            }

            // MainForm.conn.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns["Column9"].Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns["Column9"].Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns["Column9"].Visible = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {                
                SqlCommand cmd = new SqlCommand("p_insertDuZhe", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@dzId", SqlDbType.Char);
                cmd.Parameters.Add("@name", SqlDbType.Char);
                cmd.Parameters.Add("@sex", SqlDbType.Char);
                cmd.Parameters.Add("@idcard", SqlDbType.Char);
                cmd.Parameters.Add("@password", SqlDbType.Char);
                cmd.Parameters.Add("@phone", SqlDbType.Char);
                cmd.Parameters.Add("@type", SqlDbType.Int);
                cmd.Parameters.Add("@djdate", SqlDbType.Date);

                DataGridViewRow row = dataGridView1.Rows[dataGridView1.Rows.Count - 2];

                cmd.Parameters["@dzId"].Value = row.Cells[1].Value.ToString();
                cmd.Parameters["@name"].Value = row.Cells[2].Value.ToString();
                cmd.Parameters["@sex"].Value = row.Cells[3].Value.ToString();
                cmd.Parameters["@idcard"].Value = row.Cells[4].Value.ToString();
                cmd.Parameters["@password"].Value = row.Cells[5].Value.ToString();
                cmd.Parameters["@phone"].Value = row.Cells[6].Value.ToString();
                cmd.Parameters["@type"].Value = int.Parse(row.Cells[7].Value.ToString());
                cmd.Parameters["@djdate"].Value = DateTime.Parse(row.Cells[8].Value.ToString());

                try
                {
                    cmd.ExecuteNonQuery();  //执行存储过程调用
                    label2.Text = "提示：读者信息录入成功！";
                }
                catch (Exception ev)
                {
                    label2.Text = "提示：服务器异常";
                    MessageBox.Show(ev.Message);
                }
                if (MainForm.getAccountId() == 14001 || MainForm.getAccountId() == 14002)
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Cells[5].ReadOnly = true;
                        dataGridView1.Rows[i].Cells[5].Value = "******";
                    }
                }


            }
            else if (radioButton2.Checked)
            {
                
                SqlCommand cmd = new SqlCommand("p_updateDuZhe", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@dzId", SqlDbType.Char);
                cmd.Parameters.Add("@name", SqlDbType.Char);
                cmd.Parameters.Add("@sex", SqlDbType.Char);
                cmd.Parameters.Add("@idcard", SqlDbType.Char);
                cmd.Parameters.Add("@password", SqlDbType.Char);
                cmd.Parameters.Add("@phone", SqlDbType.Char);
                cmd.Parameters.Add("@type", SqlDbType.Int);
                cmd.Parameters.Add("@djdate", SqlDbType.Date);

                int count = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")//这里判断复选框是否选中
                    {
                        count++;
                        DataGridViewRow row = dataGridView1.Rows[i];

                        cmd.Parameters["@dzId"].Value = row.Cells[1].Value.ToString();
                        cmd.Parameters["@name"].Value = row.Cells[2].Value.ToString();
                        cmd.Parameters["@sex"].Value = row.Cells[3].Value.ToString();
                        cmd.Parameters["@idcard"].Value = row.Cells[4].Value.ToString();
                        cmd.Parameters["@password"].Value = row.Cells[5].Value.ToString();
                        cmd.Parameters["@phone"].Value = row.Cells[6].Value.ToString();
                        cmd.Parameters["@type"].Value = int.Parse(row.Cells[7].Value.ToString());
                        cmd.Parameters["@djdate"].Value = DateTime.Parse(row.Cells[8].Value.ToString());

                        try
                        {
                            cmd.ExecuteNonQuery();  //执行存储过程调用
                            label2.Text = "提示：成功修改 " + count + " 条读者信息！";
                        }
                        catch (Exception ev)
                        {
                            label2.Text = "提示：服务器异常";
                            MessageBox.Show(ev.Message);
                        }
                    }
                }
                if (MainForm.getAccountId() == 14001 || MainForm.getAccountId() == 14002)
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Cells[5].ReadOnly = true;
                        dataGridView1.Rows[i].Cells[5].Value = "******";
                    }
                }

            }
            else if (radioButton3.Checked)
            {
                SqlCommand cmd = new SqlCommand("p_deleteBook", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@dzId", SqlDbType.Char);
                cmd.Parameters.Add("@name", SqlDbType.Char);
                cmd.Parameters.Add("@sex", SqlDbType.Char);
                cmd.Parameters.Add("@idcard", SqlDbType.Char);
                cmd.Parameters.Add("@password", SqlDbType.Char);
                cmd.Parameters.Add("@phone", SqlDbType.Char);
                cmd.Parameters.Add("@type", SqlDbType.Int);
                cmd.Parameters.Add("@djdate", SqlDbType.Date);

                int count = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")//这里判断复选框是否选中
                    {
                        count++;
                        DataGridViewRow row = dataGridView1.Rows[i];

                        cmd.Parameters["@dzId"].Value = row.Cells[1].Value.ToString();
                        cmd.Parameters["@name"].Value = row.Cells[2].Value.ToString();
                        cmd.Parameters["@sex"].Value = row.Cells[3].Value.ToString();
                        cmd.Parameters["@idcard"].Value = row.Cells[4].Value.ToString();
                        cmd.Parameters["@password"].Value = row.Cells[5].Value.ToString();
                        cmd.Parameters["@phone"].Value = row.Cells[6].Value.ToString();
                        cmd.Parameters["@type"].Value = int.Parse(row.Cells[7].Value.ToString());
                        cmd.Parameters["@djdate"].Value = DateTime.Parse(row.Cells[8].Value.ToString());

                        try
                        {
                            cmd.ExecuteNonQuery();  //执行存储过程调用
                            label2.Text = "提示：成功删除 " + count + " 条读者信息！";
                        }
                        catch (Exception ev)
                        {
                            label2.Text = "提示：服务器异常";
                            MessageBox.Show(ev.Message);
                        }
                    }
                }

                if (MainForm.getAccountId() == 14001 || MainForm.getAccountId() == 14002)
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Cells[5].ReadOnly = true;
                        dataGridView1.Rows[i].Cells[5].Value = "******";
                    }
                }
            }           

        }

        private void ShowTable(DataGridView DG, SqlCommand cmd)
        {
            SqlDataAdapter dpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dpt.Fill(ds);
            DataTable dtb = ds.Tables[0];

            DG.DataSource = dtb;
            DG.AutoGenerateColumns = false;
            DG.Columns["Column1"].DataPropertyName = dtb.Columns["借书证号"].ToString();
            DG.Columns["Column2"].DataPropertyName = dtb.Columns["姓名"].ToString();
            DG.Columns["Column3"].DataPropertyName = dtb.Columns["性别"].ToString();
            DG.Columns["Column4"].DataPropertyName = dtb.Columns["身份证号"].ToString();
            DG.Columns["Column5"].DataPropertyName = dtb.Columns["密码"].ToString();
            DG.Columns["Column6"].DataPropertyName = dtb.Columns["联系电话"].ToString();
            DG.Columns["Column7"].DataPropertyName = dtb.Columns["用户类型"].ToString();
            DG.Columns["Column8"].DataPropertyName = dtb.Columns["登记日期"].ToString();          

            DG.Columns["Column1"].Visible = false;
            DG.Columns["Column2"].Visible = false;
            DG.Columns["Column3"].Visible = false;
            DG.Columns["Column4"].Visible = false;
            DG.Columns["Column5"].Visible = false;
            DG.Columns["Column6"].Visible = false;
            DG.Columns["Column7"].Visible = false;
            DG.Columns["Column8"].Visible = false;

            DataTable dt = new DataTable();//或直接建表
            dpt.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            DG.DataSource = bs;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("p_listDZ", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();  //执行存储过程调用
            ShowTable(dataGridView1, cmd);
            label2.Text = null;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }
            if (MainForm.getAccountId() == 14001 || MainForm.getAccountId() == 14002)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[5].ReadOnly = true;
                    dataGridView1.Rows[i].Cells[5].Value = "******";
                }
            }
        }
    }
}
