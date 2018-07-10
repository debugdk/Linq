<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestInfo.aspx.cs" Inherits="TestProject.RequestInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script>
        function get() {
            var ipinfo;
            $.getJSON('http://gd.geobytes.com/GetCityDetails?callback=?', function (data) {
                $("#info").html(data.geobytesinternet);
                console.log(JSON.stringify(data, null, 2));
            });
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <table width="100%">
            <tr>
                <td>
                    <input type="button" value="Geo" onclick="get()" />
                </td>
                <td>
                     <p>Client's information:</p>        
                             <p id="info"></p>
                </td>
            </tr>
        </table>

      
    </form>
</body>
</html>
