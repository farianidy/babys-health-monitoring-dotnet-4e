<%@ Page Title="BHM - (Posyandu) Balita" Language="C#" MasterPageFile="~/Posyandu.Master" AutoEventWireup="true"
    CodeBehind="IkutKegiatan.aspx.cs" Inherits="Bhm.Web.Pos.IkutKegiatan" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Kegiatan</h2>
    <table>
    <tr>
    <td>Nama Balita</td>
    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Tanggal Kegiatan</td>
    <td><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td>Berat Badan</td>
    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>kg</td>
    </tr>
    <tr>
    <td>Tinggi Badan</td>
    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>cm</td>
    </tr>
    <tr>
    <td></td>
    <td><asp:Button ID="Button1" runat="server" Text="Tambah" Width="64px" /></td>
    </tr>
    </table>
</asp:Content>
