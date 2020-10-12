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
    public partial class Lending2 : Form
    {
        public Lending2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dzId = tbDZID.Text;
            string qkId = tbQKID.Text;

            //调用借书存储过程
            SqlCommand cmd = new SqlCommand("p_lending2", MainForm.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@dzId", SqlDbType.Int);
            cmd.Parameters.Add("@adminId", SqlDbType.Int);
            cmd.Parameters.Add("@barcode", SqlDbType.Char);

            cmd.Parameters.Add("@code", SqlDbType.Char, 50);  //返回信息
            cmd.Parameters.Add("@account", SqlDbType.Char, 20);  //读者登录名
            cmd.Parameters.Add("@title", SqlDbType.Char, 50);  //书名

            //传入值
            cmd.Parameters["@dzId"].Value = int.Parse(dzId);  
            cmd.Parameters["@adminId"].Value = MainForm.getAccountId();  //经办人ID
            cmd.Parameters["@barcode"].Value = qkId;

            //一下三个为输出型参数
            cmd.Parameters["@code"].Direction = ParameterDirection.Output;
            cmd.Parameters["@account"].Direction = ParameterDirection.Output;
            cmd.Parameters["@title"].Direction = ParameterDirection.Output;

            try
            {
                cmd.ExecuteNonQuery();  //执行存储过程调用

                //获得返回信息
                string code = cmd.Parameters["@code"].Value.ToString().Trim();  
                string account = cmd.Parameters["@account"].Value.ToString().Trim();
                string title = cmd.Parameters["@title"].Value.ToString().Trim();

                if (code.Equals("OK"))
                {
                    lbMessage.Text = "提示：读者 " + account + " 成功借阅期刊" + title;
                }
                else
                {
                    lbMessage.Text = "提示：" + code;
                }
            }
            catch (Exception e1)
            {
                lbMessage.Text = "提示：服务器异常";
                MessageBox.Show(e1.Message);
            }

        }

    }
}
