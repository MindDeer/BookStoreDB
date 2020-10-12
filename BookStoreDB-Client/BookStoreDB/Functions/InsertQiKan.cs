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
    public partial class InsertQiKan : Form
    {
        SqlCommand cmd = null;
        public InsertQiKan()
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


            cmd = new SqlCommand("p_listQK", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();  //执行存储过程调用
            ShowTable(dataGridView1, cmd);

            // MainForm.conn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns["Column9"].Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns["Column9"].Visible = true;
            label2.Text = "提示：编号列涉及主键约束，请勿对其进行修改";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns["Column9"].Visible = true;
            label2.Text = "提示：已建立副本关系的期刊不可删除";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SqlCommand cmd = new SqlCommand("p_insertQiKan", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@qkId", SqlDbType.Int);
                cmd.Parameters.Add("@qkmc", SqlDbType.Char);
                cmd.Parameters.Add("@type", SqlDbType.Char);
                cmd.Parameters.Add("@code", SqlDbType.Char);
                cmd.Parameters.Add("@author", SqlDbType.Char);
                cmd.Parameters.Add("@press", SqlDbType.Char);
                cmd.Parameters.Add("@frequency", SqlDbType.Char);
                cmd.Parameters.Add("@grade", SqlDbType.Char);
                cmd.Parameters.Add("@money", SqlDbType.Decimal);
                cmd.Parameters.Add("@cbdate", SqlDbType.Date);

                DataGridViewRow row = dataGridView1.Rows[dataGridView1.Rows.Count - 2];

                cmd.Parameters["@qkId"].Value = int.Parse(row.Cells[1].Value.ToString());
                cmd.Parameters["@qkmc"].Value = row.Cells[2].Value.ToString();
                cmd.Parameters["@type"].Value = row.Cells[3].Value.ToString();
                cmd.Parameters["@code"].Value = row.Cells[4].Value.ToString();
                cmd.Parameters["@author"].Value = row.Cells[5].Value.ToString();
                cmd.Parameters["@press"].Value = row.Cells[6].Value.ToString();
                cmd.Parameters["@frequency"].Value = row.Cells[7].Value.ToString();
                cmd.Parameters["@grade"].Value = row.Cells[8].Value.ToString();
                cmd.Parameters["@money"].Value = Decimal.Parse(row.Cells[9].Value.ToString());
                cmd.Parameters["@cbdate"].Value = DateTime.Parse(row.Cells[10].Value.ToString());

                try
                {
                    cmd.ExecuteNonQuery();  //执行存储过程调用
                    label2.Text = "提示：期刊信息录入成功！" ;
                }
                catch (Exception ev)
                {
                    label2.Text = "提示：服务器异常";
                    MessageBox.Show(ev.Message);
                }

            }
            else if (radioButton2.Checked)
            {
                SqlCommand cmd = new SqlCommand("p_updateQiKan", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@qkId", SqlDbType.Int);
                cmd.Parameters.Add("@qkmc", SqlDbType.Char);
                cmd.Parameters.Add("@type", SqlDbType.Char);
                cmd.Parameters.Add("@code", SqlDbType.Char);
                cmd.Parameters.Add("@author", SqlDbType.Char);
                cmd.Parameters.Add("@press", SqlDbType.Char);
                cmd.Parameters.Add("@frequency", SqlDbType.Char);
                cmd.Parameters.Add("@grade", SqlDbType.Char);
                cmd.Parameters.Add("@money", SqlDbType.Decimal);
                cmd.Parameters.Add("@cbdate", SqlDbType.Date);

                int count = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")//这里判断复选框是否选中
                    {
                        count++;
                        DataGridViewRow row = dataGridView1.Rows[i];

                        cmd.Parameters["@qkId"].Value = int.Parse(row.Cells[1].Value.ToString());
                        cmd.Parameters["@qkmc"].Value = row.Cells[2].Value.ToString();
                        cmd.Parameters["@type"].Value = row.Cells[3].Value.ToString();
                        cmd.Parameters["@code"].Value = row.Cells[4].Value.ToString();
                        cmd.Parameters["@author"].Value = row.Cells[5].Value.ToString();
                        cmd.Parameters["@press"].Value = row.Cells[6].Value.ToString();
                        cmd.Parameters["@frequency"].Value = row.Cells[7].Value.ToString();
                        cmd.Parameters["@grade"].Value = row.Cells[8].Value.ToString();
                        cmd.Parameters["@money"].Value = Decimal.Parse(row.Cells[9].Value.ToString());
                        cmd.Parameters["@cbdate"].Value = DateTime.Parse(row.Cells[10].Value.ToString());

                        try
                        {
                            cmd.ExecuteNonQuery();  //执行存储过程调用
                            label2.Text = "提示：成功修改 " + count + " 本期刊信息！";
                        }
                        catch (Exception ev)
                        {
                            label2.Text = "提示：服务器异常";
                            MessageBox.Show(ev.Message);
                        }
                    }
                }
                //for (int i = 0; i < dataGridView1.RowCount; i++)
                //{
                //    for (int j = 0; j < dataGridView1.RowCount; j++)
                //    {
                //        if (dataGridView1.Rows[i].Cells[1].Value == dataGridView1.Rows[j].Cells[1].Value)
                //        {
                //            label2.Text = "违反主键或外键约束，期刊编号不可修改！";
                //        }
                //    }
                //}
            }
            else if (radioButton3.Checked)
            {
                SqlCommand cmd = new SqlCommand("p_deleteQiKan", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@qkId", SqlDbType.Int);
                cmd.Parameters.Add("@qkmc", SqlDbType.Char);
                cmd.Parameters.Add("@type", SqlDbType.Char);
                cmd.Parameters.Add("@code", SqlDbType.Char);
                cmd.Parameters.Add("@author", SqlDbType.Char);
                cmd.Parameters.Add("@press", SqlDbType.Char);
                cmd.Parameters.Add("@frequency", SqlDbType.Char);
                cmd.Parameters.Add("@grade", SqlDbType.Char);
                cmd.Parameters.Add("@money", SqlDbType.Decimal);
                cmd.Parameters.Add("@cbdate", SqlDbType.Date);

                int count = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")//这里判断复选框是否选中
                    {
                        count++;
                        DataGridViewRow row = dataGridView1.Rows[i];

                        cmd.Parameters["@qkId"].Value = int.Parse(row.Cells[1].Value.ToString());
                        cmd.Parameters["@qkmc"].Value = row.Cells[2].Value.ToString();
                        cmd.Parameters["@type"].Value = row.Cells[3].Value.ToString();
                        cmd.Parameters["@code"].Value = row.Cells[4].Value.ToString();
                        cmd.Parameters["@author"].Value = row.Cells[5].Value.ToString();
                        cmd.Parameters["@press"].Value = row.Cells[6].Value.ToString();
                        cmd.Parameters["@frequency"].Value = row.Cells[7].Value.ToString();
                        cmd.Parameters["@grade"].Value = row.Cells[8].Value.ToString();
                        cmd.Parameters["@money"].Value = Decimal.Parse(row.Cells[9].Value.ToString());
                        cmd.Parameters["@cbdate"].Value = DateTime.Parse(row.Cells[10].Value.ToString());

                        try
                        {
                            cmd.ExecuteNonQuery();  //执行存储过程调用
                            label2.Text = "提示：成功删除 " + count + " 本期刊信息！";
                        }
                        catch (Exception ev)
                        {
                            label2.Text = "提示：服务器异常";
                            MessageBox.Show(ev.Message);
                        }
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
            DG.Columns["Column1"].DataPropertyName = dtb.Columns["编号"].ToString();
            DG.Columns["Column2"].DataPropertyName = dtb.Columns["期刊名"].ToString();
            DG.Columns["Column3"].DataPropertyName = dtb.Columns["类别号"].ToString();
            DG.Columns["Column4"].DataPropertyName = dtb.Columns["ISSN 编号"].ToString();
            DG.Columns["Column5"].DataPropertyName = dtb.Columns["主办单位"].ToString();
            DG.Columns["Column6"].DataPropertyName = dtb.Columns["主管单位"].ToString();
            DG.Columns["Column7"].DataPropertyName = dtb.Columns["刊期"].ToString();
            DG.Columns["Column8"].DataPropertyName = dtb.Columns["级别"].ToString();
            DG.Columns["Column10"].DataPropertyName = dtb.Columns["价钱"].ToString();
            DG.Columns["Column11"].DataPropertyName = dtb.Columns["出版日期"].ToString();

            DG.Columns["Column1"].Visible = false;
            DG.Columns["Column2"].Visible = false;
            DG.Columns["Column3"].Visible = false;
            DG.Columns["Column4"].Visible = false;
            DG.Columns["Column5"].Visible = false;
            DG.Columns["Column6"].Visible = false;
            DG.Columns["Column7"].Visible = false;
            DG.Columns["Column8"].Visible = false;
            DG.Columns["Column10"].Visible = false;
            DG.Columns["Column11"].Visible = false;

            DataTable dt = new DataTable();//或直接建表
            dpt.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            DG.DataSource = bs;

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("p_listQK", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();  //执行存储过程调用
            ShowTable(dataGridView1, cmd);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }
            label2.Text = null;
        }
    }
}
