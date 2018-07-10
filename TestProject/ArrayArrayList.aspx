<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArrayArrayList.aspx.cs" Inherits="TestProject.ArrayArrayList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />
        <br />
        Array:<asp:Label ID="lblArray" runat="server"></asp:Label>
        <br />
        ArrayList:<asp:Label ID="lblArrayLiat" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
