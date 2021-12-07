<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Source.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>

    <link href="Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Bootstrap/jss/bootstrap.bundle.min.js"></script>
    <style type="text/css">
        .heading {
  text-align: center;
  margin: 24px 0 12px 0;
}

        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <center><h1 class="h1">All Resumes</h1></center>
            <br />
            
            <br />
        </div>
        <asp:GridView ID="GridView1" class="table table-striped" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Resume">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("File") %>' CommandName="Download" Text='<%# Eval("File") %>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Size" HeaderText="Size in Bytes" />
                <asp:BoundField DataField="Type" HeaderText="File Type" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
    </form>
</body>
</html>
