<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ckennedy8728_A1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Vlarg Interface V1443234566</h1>
        <p class="lead">Enter some text here: </p>
        <asp:TextBox ID="txtEntry" runat="server" Width="542px" TabIndex="1"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" Width="135px" />
        <br />
        <br />
        <asp:Button ID="btnGreen" BackColor="#00CC00" runat="server" Text="Change Colour" OnClick="btnGreen_Click" Font-Bold="True" ForeColor="#990033" TabIndex="2" Width="132px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnApplyAll" runat="server" OnClick="btnApplyAll_Click" Text="Apply All!" Width="146px" />
        <br />
        <br />
        <asp:Button ID="btnReverse" runat="server" OnClick="btnReverse_Click" Text="esreveR" Width="134px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblEntry" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="btnBold" runat="server" OnClick="btnBold_Click" Text="Bold" Width="135px" />
        <br />
        <br />
        <asp:Button ID="btnItalic" runat="server" OnClick="btnItalic_Click" Text="Italicized" Width="135px" />
        <br />
        <br />
        <br />
    </div>

   

</asp:Content>
