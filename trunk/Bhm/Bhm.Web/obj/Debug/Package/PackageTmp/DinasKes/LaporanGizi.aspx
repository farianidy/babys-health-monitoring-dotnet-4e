<%@ Page Title="BHM - (Dinkes) Laporan" Language="C#" MasterPageFile="~/Dinkes.Master" AutoEventWireup="true"
    CodeBehind="LaporanGizi.aspx.cs" Inherits="Bhm.Web.DinasKes.LaporanGizi" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Laporan Gizi Balita</h2>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Pilih Kecamatan</legend>
            <p>
                <asp:DropDownList ID="KecamatanDropDown" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="FindKecamatanButton" runat="server" Text="Cari" />
            </p>
        </fieldset>
    </div>
    <table>
    <tr>
    <td>Kecamatan</td>
    <td><asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="169px"></asp:DropDownList></td>
    </tr>
    <tr>
    <td><asp:Button ID="Button2" runat="server" Text="Back" Width="64px" /></td>
    <td><asp:Button ID="Button1" runat="server" Text="Lihat" Width="64px" /></td>
    </tr>
    </table>
</asp:Content>
