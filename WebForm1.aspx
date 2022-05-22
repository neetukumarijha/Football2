<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Football.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Japan Data" Width="201px" />
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Win" Width="203px" />
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Draw" Width="206px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
