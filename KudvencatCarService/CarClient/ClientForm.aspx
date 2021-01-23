<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientForm.aspx.cs" Inherits="CarClient.ClientForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td><asp:Label ID="IdLabel" runat="server" Text="Id"></asp:Label></td>
                <td><asp:TextBox ID="IdTxtBx" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="MarkLabel" runat="server" Text="Mark"></asp:Label></td>
                <td><asp:TextBox ID="MarkTxtBx" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="ModelLabel" runat="server" Text="Model"></asp:Label></td>
                <td><asp:TextBox ID="ModelTxtBx" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="YearLabel" runat="server" Text="Year"></asp:Label></td>
                <td><asp:TextBox ID="YearTxtBx" runat="server"></asp:TextBox></td>
            </tr>
        </table>                  
        <hr style="height: 0px" />
        </div>
        <asp:Button ID="GetCarBtn" runat="server" Text="GetCar" OnClick="GetCarBtn_Click" />
        <asp:Button ID="SaveCarBtn" runat="server" Text="SaveCar" OnClick="SaveCarBtn_Click" />
        <hr style="height: -12px" />
        <asp:Label ID="ResultLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
