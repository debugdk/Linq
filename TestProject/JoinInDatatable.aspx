<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JoinInDatatable.aspx.cs" Inherits="TestProject.JoinInDatatable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <div class="panel panel-info col-lg-6">
                <div class="panel-heading">Country</div>
                <div class="panel-body">
                    <asp:GridView ID="gvCountry" runat="server">
                    </asp:GridView>
                </div>
            </div>
            <div class="panel panel-info col-lg-6">
                <div class="panel-heading">State</div>
                <div class="panel-body">
                    <asp:GridView ID="gvState" runat="server">
                    </asp:GridView>
                </div>
            </div>
        <div class="panel panel-info col-lg-6">
                <div class="panel-heading">City</div>
                <div class="panel-body">
                    <asp:GridView ID="gvCity" runat="server">
                    </asp:GridView>
                </div>
            </div>
        <div class="panel panel-info col-lg-6">
                <div class="panel-heading">Join Result</div>
                <div class="panel-body">
                    <asp:GridView ID="grv" runat="server">
                    </asp:GridView>
                </div>
            
            </div>
    </div>
    </form>
</body>
</html>
