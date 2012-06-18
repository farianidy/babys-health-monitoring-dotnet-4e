<%@ Page Title="BHM - (Posyandu) Balita" Language="C#" MasterPageFile="~/Posyandu.Master" AutoEventWireup="true"
    CodeBehind="Balita.aspx.cs" Inherits="Bhm.Web.Pos.Balita" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Balita</h2>
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
    </table><br />
    <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
</asp:Content>
