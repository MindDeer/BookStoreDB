<%@ Page  Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

    <!--#include file="header.inc"-->
    <p>请登录您的账号</p>
    <form id="form1" runat="server">
    <div>
        <p>账号：<asp:TextBox ID="fldAccount" runat="server" Text="韶雨通" /></p>
        <p>密码：<asp:TextBox ID="fldPassword" runat="server" Text="204927" /></p>
        <p><asp:Button ID="btnSubmit" Text="登录"  OnClick="Login_Click" runat="server" /></p>
        <p><asp:Label ID="lbMessage" runat="server" /></p>
    </div>
    </form>

    <!--#include file="footer.inc"-->