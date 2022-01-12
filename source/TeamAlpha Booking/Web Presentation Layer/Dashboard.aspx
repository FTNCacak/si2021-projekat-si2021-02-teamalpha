<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Web_Presentation_Layer.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="labelUserID" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="labelUserEmail" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="labelUserFirstname" runat="server" Text="Label"></asp:Label>
        </div>       
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
