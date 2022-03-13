<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ckennedy8728_A1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Vlarg Interface V1443234566</h1>
        <p class="lead">Enter some text here: </p>
        <asp:TextBox ID="txtEntry" runat="server" Width="517px" TabIndex="1" Height="25px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" Width="114px" Height="29px" />
        <br />
        <br />
        <asp:Button ID="btnGreen" BackColor="#00CC00" runat="server" Text="Change Colour" OnClick="btnGreen_Click" Font-Bold="True" ForeColor="#990033" TabIndex="2" Width="118px" Height="31px" />
        &nbsp;&nbsp;<asp:Button ID="btnReverse" runat="server" OnClick="btnReverse_Click" Text="esreveR" Width="86px" Height="31px" />
        &nbsp;&nbsp;<asp:Button ID="btnBold" runat="server" OnClick="btnBold_Click" Text="Bold" Width="115px" Height="31px" Font-Bold="True" />
        &nbsp;<asp:Button ID="btnItalic" runat="server" OnClick="btnItalic_Click" Text="Italicized" Width="119px" Height="31px" Font-Italic="True" />
        &nbsp;<asp:Button ID="btnApplyAll" runat="server" OnClick="btnApplyAll_Click" Text="Apply All!" Width="134px" Height="33px" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="lblEntry" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
    <div class="jumbotron">
        <h3>Convert D2B</h3>
        <p>Enter a whole number to convert to binary: </p>
        <p>
            <asp:TextBox ID="txtIntToBinary" runat="server" Height="28px" Width="271px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBinarySubmit" runat="server" Height="31px" OnClick="btnBinarySubmit_Click" Text="Convert" Width="129px" />
        </p>
        <p>
            <asp:Label ID="lblBinaryOutput" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblIntErrors" runat="server" Text="Label"></asp:Label>
        </p>
        <h3>Convert B2D</h3>
        <p>Enter binary number to convert to decimal</p>
        <p>
            <asp:TextBox ID="txtBinaryToInt" runat="server" Height="27px" Width="278px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnIntSubmit" runat="server" Height="31px" OnClick="btnIntSubmit_Click" Text="Convert" Width="129px" />
        </p>
        <p>
            <asp:Label ID="lblIntOutput" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblBinaryErrors" runat="server" Text="Label"></asp:Label>
        </p>

    </div>

   

</asp:Content>
