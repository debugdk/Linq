<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="TestProject.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type ="text/javascript">
        window.onload = window.history.forward(0);
</script> 
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnClick" OnClick="btnClick_Click" Text="Go to Second page" runat="server" />
    </div>
    </form>
</body>
</html>
