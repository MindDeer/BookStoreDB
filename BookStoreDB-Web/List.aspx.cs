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

public partial class List : System.Web.UI.Page
{
    private SqlConnection conn;
    //string account = (string)Session["userId"];

    protected void Page_Load(object sender, EventArgs e)
    {
        //string account = (string)Session["userId"];

        if ((string)Session["userId"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        lbMessage.Text = "读者" + Session["account"] + "，您好，请选择您要查看记录的类型：";
        //lbMessage.Text = "读者" + Session["account"] + "，您好，您的图书借阅记录如下：";

        //conn = new SqlConnection(_Default.getConnectionString());
        //conn.Open();

        //SqlCommand cmd = new SqlCommand("p_list", conn);
        //cmd.CommandType = CommandType.StoredProcedure;  //类型为存储过程
        //cmd.Parameters.Add("@id", SqlDbType.Char);
        //cmd.Parameters["@id"].Value = int.Parse(account);

        //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //DataSet dataSet = new DataSet();
        //adapter.Fill(dataSet,"图书");
        //gridView.DataSource = dataSet;
        //gridView.DataBind();

        //conn.Close();
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        lbMessage.Text = "读者" + Session["account"] + "，您好，您的图书借阅记录如下：";

        conn = new SqlConnection(_Default.getConnectionString());
        conn.Open();

        SqlCommand cmd = new SqlCommand("p_list", conn);
        cmd.CommandType = CommandType.StoredProcedure;  //类型为存储过程
        //cmd.Parameters.Add("@id", SqlDbType.Char);
        //cmd.Parameters["@id"].Value = int.Parse((string)Session["userId"]);

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet,"图书");
        gridView.DataSource = dataSet;
        gridView.DataBind();

        conn.Close();
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        lbMessage.Text = "读者" + Session["account"] + "，您好，您的期刊借阅记录如下：";

        conn = new SqlConnection(_Default.getConnectionString());
        conn.Open();

        SqlCommand cmd = new SqlCommand("p_list2", conn);
        cmd.CommandType = CommandType.StoredProcedure;  //类型为存储过程
        //cmd.Parameters.Add("@id", SqlDbType.Char);
        //cmd.Parameters["@id"].Value = int.Parse((string)Session["userId"]);

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet,"期刊");
        gridView.DataSource = dataSet;
        gridView.DataBind();

        conn.Close();
    }

}