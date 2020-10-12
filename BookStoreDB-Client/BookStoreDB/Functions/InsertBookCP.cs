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
    public partial class InsertBookCP : Form
    {
        SqlCommand cmd = null;

        public InsertBookCP()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //label4.Text = DateTime.Now.ToString("yyyy-m-d");
        }

        private void 所有副本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("p_allbookcopy", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);
                label5.Text = "提示：查询成功";
            }
            catch (Exception ev)
            {
                label5.Text = "提示：服务器异常";
                MessageBox.Show(ev.Message);
            }
        }

        private void 按图书名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("p_namebookcopy", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.Char);
            cmd.Parameters["@id"].Value = textBox4.Text;
            try
            {
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);
                if (textBox4.Text == "")
                    label5.Text = "提示：查询关键字为空";
                else
                    label5.Text = "提示：查询成功";
            }
            catch (Exception ev)
            {
                label5.Text = "提示：服务器异常";
                MessageBox.Show(ev.Message);
            }
        }

        private void 按副本编号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("p_cpidbookcopy", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.Char);
            cmd.Parameters["@id"].Value = textBox4.Text;
            try
            {
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);
                if (textBox4.Text == "")
                    label5.Text = "提示：查询关键字为空";
                else
                    label5.Text = "提示：查询成功";
            }
            catch (Exception ev)
            {
                label5.Text = "提示：服务器异常";
                MessageBox.Show(ev.Message);
            }
        }

        private void 按副本状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("p_statusbookcopy", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.Char);
            cmd.Parameters["@id"].Value = textBox3.Text;
            try
            {
                cmd.ExecuteNonQuery();  //执行存储过程调用
                ShowTable(dataGridView1, cmd);
                if(textBox4.Text=="")
                    label5.Text = "提示：查询关键字为空";
                else
                    label5.Text = "提示：查询成功";
            }
            catch (Exception ev)
            {
                label5.Text = "提示：服务器异常";
                MessageBox.Show(ev.Message);
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
            DG.Columns["Column1"].DataPropertyName = dtb.Columns["副本编号"].ToString();
            DG.Columns["Column2"].DataPropertyName = dtb.Columns["图书名称"].ToString();
            DG.Columns["Column3"].DataPropertyName = dtb.Columns["图书编号"].ToString();
            DG.Columns["Column4"].DataPropertyName = dtb.Columns["副本状态"].ToString();

            DG.Columns["Column1"].Visible = false;
            DG.Columns["Column2"].Visible = false;
            DG.Columns["Column3"].Visible = false;
            DG.Columns["Column4"].Visible = false;

            DataTable dt = new DataTable();//或直接建表
            dpt.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            DG.DataSource = bs;

        }

        private void 录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("p_insertBookcopy", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@tsid", SqlDbType.Int);
            cmd.Parameters.Add("@copyid", SqlDbType.Char);
            cmd.Parameters.Add("@status", SqlDbType.Int);
            cmd.Parameters["@tsid"].Value = textBox1.Text;
            cmd.Parameters["@copyid"].Value = textBox2.Text;
            cmd.Parameters["@status"].Value = textBox3.Text;

            try
            {
                cmd.ExecuteNonQuery();  //执行存储过程调用
                label5.Text = "副本录入成功";
            }
            catch (Exception ev)
            {
                label5.Text = "提示：服务器异常";
                MessageBox.Show(ev.Message);
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("p_updateBookcopy", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@tsid", SqlDbType.Int);
            cmd.Parameters.Add("@copyid", SqlDbType.Char);
            cmd.Parameters.Add("@status", SqlDbType.Char);
            cmd.Parameters["@tsid"].Value = textBox1.Text;
            cmd.Parameters["@copyid"].Value = textBox2.Text;
            cmd.Parameters["@status"].Value = textBox3.Text;

            try
            {
                cmd.ExecuteNonQuery();  //执行存储过程调用
                label5.Text = "副本修改成功";
            }
            catch (Exception ev)
            {
                label5.Text = "提示：服务器异常";
                MessageBox.Show(ev.Message);
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textBox1.ReadOnly = true;
            //textBox3.ReadOnly = true;
            SqlCommand cmd = new SqlCommand("p_deleteBookcopy", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@copyid", SqlDbType.Char);
            cmd.Parameters["@copyid"].Value = textBox2.Text;

            try
            {
                cmd.ExecuteNonQuery();  //执行存储过程调用
                label5.Text = "副本删除成功";
            }
            catch (Exception ev)
            {
                label5.Text = "提示：服务器异常";
                MessageBox.Show(ev.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label5.Text = "";
        }
    }
}
