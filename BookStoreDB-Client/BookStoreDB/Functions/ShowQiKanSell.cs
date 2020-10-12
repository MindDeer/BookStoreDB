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
    public partial class ShowQiKanSell : Form
    {
        public ShowQiKanSell()
        {
            InitializeComponent();
            SqlCommand cmd = new SqlCommand("p_allbookselllist2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            ShowTable(dataGridView1, cmd);
        }

        private void ShowTable(DataGridView DG, SqlCommand cmd)
        {
            SqlDataAdapter dpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dpt.Fill(ds);
            DataTable dtb = ds.Tables[0];

            DG.DataSource = dtb;
            DG.AutoGenerateColumns = false;
            DG.Columns["Column1"].DataPropertyName = dtb.Columns["销售单号"].ToString();
            DG.Columns["Column2"].DataPropertyName = dtb.Columns["期刊副本号"].ToString();
            DG.Columns["Column3"].DataPropertyName = dtb.Columns["价钱"].ToString();
            DG.Columns["Column4"].DataPropertyName = dtb.Columns["销售日期"].ToString();
            DG.Columns["Column5"].DataPropertyName = dtb.Columns["经手人"].ToString();
            DG.Columns["Column6"].DataPropertyName = dtb.Columns["备注"].ToString();

            DG.Columns["Column1"].Visible = false;
            DG.Columns["Column2"].Visible = false;
            DG.Columns["Column3"].Visible = false;
            DG.Columns["Column4"].Visible = false;
            DG.Columns["Column5"].Visible = false;
            DG.Columns["Column6"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("p_searchbooksell2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.Char);
            cmd.Parameters["@id"].Value = textBox1.Text;
            try
            {
                cmd.ExecuteNonQuery();
                ShowTable(dataGridView1, cmd);
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

       
    }
}
