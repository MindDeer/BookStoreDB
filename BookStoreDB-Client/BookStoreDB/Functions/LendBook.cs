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
    public partial class LendBook : Form
    {
        public LendBook()
        {
            InitializeComponent();
            rbAll.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            buttonOK.Click += buttonOK_Click;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            if (rbAll.Checked)
            {
                cmd = new SqlCommand("p_Alllist", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);

                //MainForm.conn.Close();
            }
            else if (rbDZ.Checked)
            {
                cmd = new SqlCommand("p_dzlist", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Char);
                cmd.Parameters["@id"].Value = textBox1.Text;
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);
                
            }
            else if (rbTS.Checked)
            {
                cmd = new SqlCommand("p_tslist", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Char);
                cmd.Parameters["@id"].Value = textBox2.Text;
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);
                
            }
            else if (rbDate.Checked)
            {
                cmd = new SqlCommand("p_datelist", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Date);
                cmd.Parameters["@id"].Value = DateTime.Parse(textBox3.Text);
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);                
            }
            else if (rbAdmin.Checked)
            {
                cmd = new SqlCommand("p_adminlist", MainForm.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = int.Parse(textBox4.Text);
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
            DG.Columns["Column1"].DataPropertyName = dtb.Columns["书名"].ToString();
            DG.Columns["Column2"].DataPropertyName = dtb.Columns["副本条码"].ToString();
            DG.Columns["Column3"].DataPropertyName = dtb.Columns["借书日期"].ToString();
            DG.Columns["Column4"].DataPropertyName = dtb.Columns["还书日期"].ToString();
            DG.Columns["Column5"].DataPropertyName = dtb.Columns["读者"].ToString();
            DG.Columns["Column6"].DataPropertyName = dtb.Columns["经办人"].ToString();
            DG.Columns["Column1"].Visible = false;
            DG.Columns["Column2"].Visible = false;
            DG.Columns["Column3"].Visible = false;
            DG.Columns["Column4"].Visible = false;
            DG.Columns["Column5"].Visible = false;
            DG.Columns["Column6"].Visible = false;
            DataTable dt = new DataTable();//或直接建表
            dpt.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            DG.DataSource = bs;

        }
    }
    
}
