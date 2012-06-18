<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomeMain.aspx.cs" Inherits="Bhm.Web.HomeMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label ID="Label1" runat="server" Text="Selamat Datang di Baby`s Health Monitoring" 
        style="font-size: xx-large; font-weight: 700"></asp:Label><br />
        <span class="style2"><strong>Login</strong></span><br />
    <table>
    <tr>
    <td>Username</td>
    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Password</td>
    <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td></td>
    <td><asp:Button ID="Button2" runat="server" Text="Login" Width="64px" /></td>
    </tr>
    </table><br />
        <span class="style2"><strong>Cari Balita</strong></span><br />
    <table>
    <tr>
    <td>Nama Balita</td>
    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Nama Ayah</td>
    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Nama Ibu</td>
    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td></td>
    <td><asp:Button ID="Button1" runat="server" Text="Cari" Width="64px" /></td>
    </tr>
    </table>
</asp:Content>
