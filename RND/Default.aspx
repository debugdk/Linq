<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RND._Default" %>
<%@ MasterType VirtualPath="~/Site.Master" %> 
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
      function ShowProgressBar() {
        document.getElementById('dvProgressBar').style.visibility = 'visible';
      }

      function HideProgressBar() {
        document.getElementById('dvProgressBar').style.visibility = "hidden";
      }
    </script>
    <div onload="javascript:HideProgressBar()">
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" OnClientClick="javascript:ShowProgressBar()" />
    <div ID="dvProgressBar" style="float:left;visibility: hidden;" >
        <img src="progress_bar.gif" /> resolving address, please wait...
  </div>
</div>
  <br style="clear:both" />
</asp:Content>
