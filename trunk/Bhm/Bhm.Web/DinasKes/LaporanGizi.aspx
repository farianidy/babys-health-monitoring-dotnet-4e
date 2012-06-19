<%@ Page Title="BHM - (Dinkes) Laporan" Language="C#" MasterPageFile="~/Dinkes.Master" AutoEventWireup="true"
    CodeBehind="LaporanGizi.aspx.cs" Inherits="Bhm.Web.DinasKes.LaporanGizi" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Laporan Gizi Balita</h2>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Pilih Kecamatan</legend>
            <p>
                <asp:DropDownList ID="KecamatanDropDown" runat="server" />
                <asp:Button ID="FindKecamatanButton" runat="server" Text="Cari" />
            </p>
        </fieldset>
    </div>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server">
    </rsweb:ReportViewer>
</asp:Content>
