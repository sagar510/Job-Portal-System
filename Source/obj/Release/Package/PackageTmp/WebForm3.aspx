<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Source.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</body>
<asp:ChangePassword runat="server"></asp:ChangePassword>
    <asp:Login ID="Login1" runat="server">
    </asp:Login>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>

</html>
