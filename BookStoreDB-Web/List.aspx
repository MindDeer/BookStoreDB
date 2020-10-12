<%@ Page Language="C#" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="List" %>
<!--#include file="header.inc"-->
<div align="center">
   <h2>书刊借阅记录</h2>
</div>
<p><asp:Label ID="lbMessage" runat="server" /></p>
<form id="form1" runat="server">
<p>
<asp:Button ID="btn1" Text="图书"  OnClick="btn1_Click" runat="server" />
<asp:Button ID="btn2" Text="期刊"  OnClick="btn2_Click" runat="server" />
</p>
   <asp:GridView id="gridView" runat="server"></asp:GridView>
</form>
<p><asp:Label ID="label1" runat="server" /></p>
<p><asp:Label ID="label2" runat="server" /></p>
<!--#include file="footer.inc"-->
</html>