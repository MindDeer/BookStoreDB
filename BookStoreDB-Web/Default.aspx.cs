using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    public static string dataSource = "LAPTOP-RENGLMMN";
    public static string user = "admin";
    public static string password = "123456";
    public static string database = "BookStoreDB";

    public static string getConnectionString()
    {
        return "Integrated Security=False;Initial Catalog=" + database
            + ";Data Source=" + dataSource
            + ";User ID=" + user
            + ";Password=" + password;
    }
    public static SqlConnection conn;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["op"] == "logout")
        {
            Session["userId"] = null;
        }
        else if (Session["userId"] != null)
        {
            Response.Redirect("List.aspx");
        }
    }

    protected void Login_Click(object sender, EventArgs e)
    {
        string account = fldAccount.Text;
        string password = fldPassword.Text;

        if (account != null && password != null)
        {
            conn = new SqlConnection(getConnectionString());
            conn.Open();


            SqlCommand cmd = new SqlCommand("p_login", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@account", SqlDbType.Char);  //指定参数
            cmd.Parameters.Add("@password", SqlDbType.Char);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters.Add("@type", SqlDbType.Int);

            cmd.Parameters["@account"].Value = account;  //传入参数
            cmd.Parameters["@password"].Value = password;
            cmd.Parameters["@id"].Direction = ParameterDirection.Output;  //输出型参数
            cmd.Parameters["@type"].Value = 0;  //0表示读者可以登录

            try
            {
                cmd.ExecuteNonQuery();  //执行存储过程调用
                string id = cmd.Parameters["@id"].Value.ToString();  //获得返回信息

                int accountId = int.Parse(id);

                if (accountId == 0)
                {
                    lbMessage.Text = "提示：账号或密码错误，登录失败！";
                }
                else
                {
                    Session["account"] = account;
                    Session["userId"] = id;
                    
                    Response.Redirect("List.aspx");
                }
            }
            catch (Exception e1)
            {
                lbMessage.Text = "提示：服务器异常";
                Response.Write(e1.Message);
            }
            conn.Close();
        }
        else
        {
            lbMessage.Text = "提示：请输入用户名和密码";
        }
    }

}
