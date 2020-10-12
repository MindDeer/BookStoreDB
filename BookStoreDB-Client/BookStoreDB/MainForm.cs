/* *************************************************************************
 * C#项目代码：
 * 文件名：MainForm.cs
 * 功能：项目初始化设置（数据库连接字符串）
 *       启动时建立数据库连接（在构造方法中）
 *       登录过程的后台出处理（在btnLogin_Click()方法中）
 *       结束时关闭数据库连接
 *       菜单项窗体的打开
 *************************************************************************** */

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
using BookStoreDB.Functions;

namespace BookStoreDB
{
    public partial class MainForm : Form
    {
        //服务器名字
        public static string dataSource = "LAPTOP-RENGLMMN";
        //登录名
        public static string user = "admin";
        //登录密码
        public static string password = "123456";
        //数据库名称
        public static string database = "BookStoreDB";

        //根据前面参数，返回数据库连接字符串
        public static string getConnectionString()
        {
            return "Integrated Security=False;Initial Catalog=" + database
                + ";Data Source=" + dataSource
                + ";User ID=" + user
                + ";Password=" + password;
        }

        //公用的静态的数据库连接，被其他窗体引用
        public static SqlConnection conn;

        //保存登录账号的主键值，如果为0表示还未登录或登录失败
        private static int accountId = 0;

        //根据返回值可以判断是否登录，如果为0表示还未登录
        public static int getAccountId()
        {
            return accountId;
        }

        public MainForm()
        {
            InitializeComponent();

            //禁用菜单，登录成功后才启用
            menuStrip1.Enabled = false;
            try
            {
                //启用程序时首先建立数据库连接，在程序结束时关闭该连接
                conn = new SqlConnection(getConnectionString());
                conn.Open();
                lbMessage.Text = "提示：数据库连接成功！";
            }
            catch(Exception e)
            {
                lbMessage.Text = "提示：数据库连接失败！";
                MessageBox.Show(e.Message);
            }
        }

        //单击登录按钮的事件处理程序
        private void btLogin_Click(object sender, EventArgs e)
        {
            //获取用户输入的账号和密码
            string account = tbAccount.Text;
            string password = tbPassword.Text;

            //调用登录存储过程，进行登录验证
            SqlCommand cmd = new SqlCommand("p_login", conn);  //存储过程名
            cmd.CommandType = CommandType.StoredProcedure;  //类型为存储过程

            cmd.Parameters.Add("@account", SqlDbType.Char);  //指定参数
            cmd.Parameters.Add("@password", SqlDbType.Char);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters.Add("@type", SqlDbType.Int);

            cmd.Parameters["@account"].Value = account;  //传入参数
            cmd.Parameters["@password"].Value = password;
            cmd.Parameters["@id"].Direction = ParameterDirection.Output;  //输出型参数
            cmd.Parameters["@type"].Value = 1;  //1表示只有管理人员可以登录

            //禁用菜单，登录成功后才再启动
            menuStrip1.Enabled = false;
            try
            {
                cmd.ExecuteNonQuery();  //执行存储过程调用
                string id = cmd.Parameters["@id"].Value.ToString().Trim();  //获得返回信息

                accountId = int.Parse(id);
                if (accountId == 0)
                {
                    lbMessage.Text = "提示：登录失败！";
                }
                else
                {
                    //登陆成功后可启用菜单
                    menuStrip1.Enabled = true;
                    lbMessage.Text = "提示：登录成功！ID=" + id;
                }
            }
            catch (Exception e1)
            {
                lbMessage.Text = "提示：服务器异常";
                MessageBox.Show(e1.Message);
            }

        }

        private void MainForm_FormClosing(Object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            //程序结束时关闭数据库连接
            conn.Close();
        }

        private void 图书租出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Lending().Show();
        }

        private void 图书还入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Returning().Show();
        }

        private void 期刊租出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Lending2().Show();
        }

        private void 期刊还入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Returning2().Show();
        }

        private void 图书借还情况查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LendBook().Show();
        }

        private void 期刊借还情况查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LendQiKan().Show();
        }

        private void 图书信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertBook().Show();
        }

        private void 期刊信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertQiKan().Show();
        }

        private void 读者信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertUser().Show();
        }

        private void 现有图书查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ListBook().Show();
        }

        private void 现有期刊查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListQiKan().Show();
        }

        private void 读者信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListReader().Show();
        }

        private void 图书副本管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertBookCP().Show();
        }

        private void 期刊副本管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertQiKanCP().Show();
        }

        private void 图书售出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SellBook().Show();
        }

        private void 期刊售出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SellQiKan().Show();
        }

        private void 图书销售情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowBookSell().Show();
        }

        private void 期刊销售情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowQiKanSell().Show();
        }
    }
}
