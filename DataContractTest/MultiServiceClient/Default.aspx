<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MultiServiceClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
    </p>
    <p>
        <asp:Button ID="dateBtn" runat="server" OnClick="dateBtn_Click" Text="GetDate" />
        <asp:Label ID="dateLabel" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Button ID="nameBtn" runat="server" OnClick="nameBtn_Click" Text="GetPerson" />
        <asp:TextBox ID="firstNameTxtBox" runat="server"></asp:TextBox>
        <asp:TextBox ID="lastNameTxtBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="personLabel" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>

</asp:Content>
