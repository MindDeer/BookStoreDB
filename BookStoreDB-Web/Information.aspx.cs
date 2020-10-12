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

public partial class Information : System.Web.UI.Page
{
    private SqlConnection conn;

    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["userId"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        lbMessage.Text = "请选择您要查看信息的类型：";
        
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        lbMessage.Text = "您好，当前图书状态信息如下：";

        conn = new SqlConnection(_Default.getConnectionString());
        conn.Open();

        SqlCommand cmd = new SqlCommand("p_tsStatus", conn);
        cmd.CommandType = CommandType.StoredProcedure;  //类型为存储过程
        //cmd.Parameters.Add("@id", SqlDbType.Char);
        //cmd.Parameters["@id"].Value = int.Parse((string)Session["userId"]);

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet, "图书");
        gridView.DataSource = dataSet;
        gridView.DataBind();

        conn.Close();
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        lbMessage.Text = "您好，当前期刊状态信息如下：";

        conn = new SqlConnection(_Default.getConnectionString());
        conn.Open();

        SqlCommand cmd = new SqlCommand("p_qkStatus", conn);
        cmd.CommandType = CommandType.StoredProcedure;  //类型为存储过程
        //cmd.Parameters.Add("@id", SqlDbType.Char);
        //cmd.Parameters["@id"].Value = int.Parse((string)Session["userId"]);

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet, "期刊");
        gridView.DataSource = dataSet;
        gridView.DataBind();

        conn.Close();
    }
}