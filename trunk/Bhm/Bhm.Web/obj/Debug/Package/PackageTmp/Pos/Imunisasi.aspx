<%@ Page Title="BHM - (Posyandu) Balita" Language="C#" MasterPageFile="~/Posyandu.Master" AutoEventWireup="true"
    CodeBehind="Imunisasi.aspx.cs" Inherits="Bhm.Web.Pos.Imunisasi" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Imunisasi</h2>
    <table>
    <tr>
    <td>Nama Balita</td>
    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td>HBO</td>
    <td><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td>BCG, Polio1</td>
    <td><asp:Calendar ID="Calendar2" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td>DPT/HBO1, Polio2</td>
    <td><asp:Calendar ID="Calendar3" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td>DPT/HBO2, Polio3</td>
    <td><asp:Calendar ID="Calendar4" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td>DPT/HBO3, Polio4</td>
    <td><asp:Calendar ID="Calendar5" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td>Campak</td>
    <td><asp:Calendar ID="Calendar6" runat="server"></asp:Calendar></td>
    </tr>
    <tr>
    <td></td>
    <td><asp:Button ID="Button1" runat="server" Text="Simpan" Width="64px" /></td>
    </tr>
    </table>
</asp:Content>
