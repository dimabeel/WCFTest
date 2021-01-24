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
                <td><asp:Label ID="IdLabel" runat="server" Text="Id:"></asp:Label></td>
                <td><asp:TextBox ID="IdTxtBx" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="MarkLabel" runat="server" Text="Mark:"></asp:Label></td>
                <td><asp:TextBox ID="MarkTxtBx" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="ModelLabel" runat="server" Text="Model:"></asp:Label></td>
                <td><asp:TextBox ID="ModelTxtBx" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="YearLabel" runat="server" Text="Year:"></asp:Label></td>
                <td><asp:TextBox ID="YearTxtBx" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="EngineTypeLabel" runat="server" Text="Engine type:"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="EngineTypeDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EngineTypeDropDownList_SelectedIndexChanged">
                    <asp:ListItem>Select engine type</asp:ListItem>
                    <asp:ListItem>Электрический</asp:ListItem>
                    <asp:ListItem>ДВС</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="EngineCCLabel" runat="server" Text="EngineCC:"></asp:Label></td>
                <td><asp:TextBox ID="EngineCCTxtBx" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="EnginePowerLabel" runat="server" Text="Engine Power:"></asp:Label></td>
                <td><asp:TextBox ID="EnginePowerTxtBx" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="RangeLabel" runat="server" Text="Range:"></asp:Label></td>
                <td>
                    <asp:TextBox ID="RangeTxtBx" runat="server"></asp:TextBox>
                    <asp:Label ID="RangeMeterLabel" runat="server" Text="kilometers"></asp:Label>
                </td>
            </tr>
        </table>                  
        <hr style="height: 0px" />
        <asp:Button ID="GetCarBtn" runat="server" Text="GetCar" OnClick="GetCarBtn_Click" />
        <asp:Button ID="SaveCarBtn" runat="server" Text="SaveCar" OnClick="SaveCarBtn_Click" />
        <asp:Button ID="CleatBtn" runat="server" OnClick="CleatBtn_Click" Text="Clear" />
        <hr style="height: -12px" />
        <asp:Label ID="ResultLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
