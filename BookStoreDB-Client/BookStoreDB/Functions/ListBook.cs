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
    public partial class ListBook : Form
    {
        public ListBook()
        {
            InitializeComponent();
            //radioButton1.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            buttonOK.Click += buttonOK_Click;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            if (radioButton1.Checked)
            {
                cmd = new SqlCommand("p_allbooklist", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);
                //MainForm.conn.Close();
            }
            else if (radiobutton2.Checked)
            {
                cmd = new SqlCommand("p_namebooklist", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Char);
                cmd.Parameters["@id"].Value = textBox1.Text;
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);

            }
            else if (radioButton3.Checked)
            {
                cmd = new SqlCommand("p_authorbooklist", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Char);
                cmd.Parameters["@id"].Value = textBox2.Text;
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);

            }
            else if (radioButton4.Checked)
            {
                cmd = new SqlCommand("p_pressbooklist", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Char);
                cmd.Parameters["@id"].Value = textBox3.Text;
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);
            }
            else if (radioButton5.Checked)
            {
                cmd = new SqlCommand("p_typebooklist", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Char);
                cmd.Parameters["@id"].Value = textBox4.Text;
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);
            }

        }

        private void ShowTable(DataGridView DG, SqlCommand cmd)
        {
            SqlDataAdapter dpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            dpt.Fill(ds);
            DataTable dtb = ds.Tables[0];
            //DataGridViewTextBoxColumn mg = new DataGridViewTextBoxColumn();
            //DG.Columns.Add(mg);
            DG.DataSource = dtb;
            DG.AutoGenerateColumns = false;
            DG.Columns["Column1"].DataPropertyName = dtb.Columns["编号"].ToString();
            DG.Columns["Column2"].DataPropertyName = dtb.Columns["书名"].ToString();
            DG.Columns["Column3"].DataPropertyName = dtb.Columns["类别"].ToString();
            DG.Columns["Column4"].DataPropertyName = dtb.Columns["ISBN 编号"].ToString();
            DG.Columns["Column5"].DataPropertyName = dtb.Columns["作者"].ToString();
            DG.Columns["Column6"].DataPropertyName = dtb.Columns["出版社"].ToString();
            DG.Columns["Column7"].DataPropertyName = dtb.Columns["价钱"].ToString();
            DG.Columns["Column8"].DataPropertyName = dtb.Columns["在册数量"].ToString();
            DG.Columns["Column9"].DataPropertyName = dtb.Columns["可借数量"].ToString();

            DG.Columns["Column1"].Visible = false;
            DG.Columns["Column2"].Visible = false;
            DG.Columns["Column3"].Visible = false;
            DG.Columns["Column4"].Visible = false;
            DG.Columns["Column5"].Visible = false;
            DG.Columns["Column6"].Visible = false;
            DG.Columns["Column7"].Visible = false;
            DG.Columns["Column8"].Visible = false;
            DG.Columns["Column9"].Visible = false;
            DataTable dt = new DataTable();//或直接建表
            dpt.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            DG.DataSource = bs;

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(this.dataGridView1.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.dataGridView1.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
        }
    }
}
