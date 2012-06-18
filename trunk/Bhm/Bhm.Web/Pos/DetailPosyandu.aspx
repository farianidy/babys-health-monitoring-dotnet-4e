<%@ Page Title="BHM - (Posyandu) Posyandu" Language="C#" MasterPageFile="~/Posyandu.Master" AutoEventWireup="true"
    CodeBehind="DetailPosyandu.aspx.cs" Inherits="Bhm.Web.Pos.DetailPosyandu" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Detil Posyandu</h2>
    <table>
    <tr>
    <td>ID Posyandu</td>
    <td><asp:TextBox ID="TextBox1" runat="server" Enabled="false"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Nama Posyandu</td>
    <td><asp:TextBox ID="TextBox2" runat="server" Enabled="false"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Desa</td>
    <td><asp:TextBox ID="TextBox3" runat="server" Enabled="false"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Kecamatan</td>
    <td><asp:TextBox ID="TextBox4" runat="server" Enabled="false"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Kabupaten</td>
    <td><asp:TextBox ID="TextBox5" runat="server" Enabled="false"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Propinsi</td>
    <td><asp:TextBox ID="TextBox6" runat="server" Enabled="false"></asp:TextBox></td>
    </tr>
    <tr>
    <td></td>
    <td><asp:Button ID="Button1" runat="server" Text="Back" Width="64px" /></td>
    </tr>
    </table>
</asp:Content>
