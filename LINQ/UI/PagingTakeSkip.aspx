<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagingTakeSkip.aspx.cs" Inherits="LINQ.UI.PagingTakeSkip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Enter Page No:
        <asp:TextBox ID="txtPageNo" runat="server" AutoPostBack="true" OnTextChanged="txtPageNo_TextChanged"></asp:TextBox>
    </div>
    </form>
</body>
</html>
