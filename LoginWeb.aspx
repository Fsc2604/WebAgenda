<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWeb.aspx.cs" Inherits="WebAgenda.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="e-mail"></asp:Label>
            <br />
            <asp:TextBox ID="txb_Email" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" Text="senha"></asp:Label>
        <br />
        <asp:TextBox ID="txb_Senha" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="bt_Login" runat="server" Height="26px" OnClick="bt_Login_Click" Text="Login" Width="45px" />
        <br />
<asp:Label ID="Lmsg" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    </form>
</body>
</html>
