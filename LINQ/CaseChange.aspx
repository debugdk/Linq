<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CaseChange.aspx.cs" Inherits="LINQ.CaseChange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtInput" runat="server" AutoPostBack="true" OnTextChanged="txtInput_TextChanged"></asp:TextBox><br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
