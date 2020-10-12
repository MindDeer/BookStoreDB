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
    public partial class Returning : Form
    {
        public Returning()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tscpId = textBox1.Text;

            SqlCommand cmd = new SqlCommand("p_returning", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.Add("@copyId", SqlDbType.Char);
            cmd.Parameters.Add("@staffId", SqlDbType.Int);           
            
            cmd.Parameters.Add("@code", SqlDbType.Char, 50);
            cmd.Parameters.Add("@title", SqlDbType.Char, 50);
            cmd.Parameters.Add("@account", SqlDbType.Char,20);

            //传入参数
            cmd.Parameters["@copyId"].Value = tscpId;
            cmd.Parameters["@staffId"].Value = MainForm.getAccountId();

            //传出参数
            cmd.Parameters["@code"].Direction = ParameterDirection.Output;
            cmd.Parameters["@title"].Direction = ParameterDirection.Output;
            cmd.Parameters["@account"].Direction = ParameterDirection.Output;

            try
            {
                cmd.ExecuteNonQuery();
                string code = cmd.Parameters["@code"].Value.ToString().Trim();
                string title = cmd.Parameters["@title"].Value.ToString().Trim();
                string account = cmd.Parameters["@account"].Value.ToString().Trim();

                if (code.Equals("OK"))
                {
                    lbMessage.Text = "提示：读者 "+account+" 成功归还图书《"+title+"》";
                }
                else
                {
                    lbMessage.Text = "提示：" + code;
                }

            }
            catch(Exception e1)
            {
                lbMessage.Text = "提示：服务器异常";
                MessageBox.Show(e1.Message);
            }
        }
    }
}
