<%@ Page Title="BHM - (Posyandu) Balita" Language="C#" MasterPageFile="~/Posyandu.Master" AutoEventWireup="true"
    CodeBehind="KMS.aspx.cs" Inherits="Bhm.Web.Pos.KMS" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Laporan Balita</h2>
    <table>
    <tr>
    <td>Nama Balita</td>
    <td><asp:TextBox ID="TextBox1" runat="server" Enabled="false"></asp:TextBox></td>
    </tr>
    <tr>
    <td></td>
    <td><asp:Button ID="Button1" runat="server" Text="Back" Width="64px" /></td>
    </tr>
    </table>
</asp:Content>
