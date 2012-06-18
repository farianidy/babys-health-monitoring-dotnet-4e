<%@ Page Title="BHM - (Posyandu) Balita" Language="C#" MasterPageFile="~/Posyandu.Master" AutoEventWireup="true"
    CodeBehind="Vitamin.aspx.cs" Inherits="Bhm.Web.Pos.Vitamin" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Vitamin</h2>
    <table>
    <tr>
    <td>Nama Balita</td>
    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Kapsul Biru</td>
    <td><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td>Kapsul Merah1</td>
    <td><asp:Calendar ID="Calendar2" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td>Kapsul Merah2</td>
    <td><asp:Calendar ID="Calendar3" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td>Kapsul Merah3</td>
    <td><asp:Calendar ID="Calendar4" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td>Kapsul Merah4</td>
    <td><asp:Calendar ID="Calendar5" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td></td>
    <td><asp:Button ID="Simpan" runat="server" Text="Simpan" Width="64px" /></td>
    </tr>
    </table>
</asp:Content>
