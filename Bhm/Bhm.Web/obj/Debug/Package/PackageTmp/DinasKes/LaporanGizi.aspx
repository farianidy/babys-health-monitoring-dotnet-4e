<%@ Page Title="BHM - (Dinkes) Laporan" Language="C#" MasterPageFile="~/Dinkes.Master" AutoEventWireup="true"
    CodeBehind="LaporanGizi.aspx.cs" Inherits="Bhm.Web.DinasKes.LaporanGizi" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Laporan Gizi Balita</h2>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Pilih Kecamatan</legend>
            <p>
                <asp:DropDownList ID="KecamatanDropDown" runat="server" />
                <asp:Button ID="CariKecamatanButton" runat="server" Text="Cari" OnClick="Cari_Clicked" />
            </p>
        </fieldset>
    </div>
    <asp:Chart ID="ChartGizi" runat="server">
        <Series>
            <asp:Series Name="Series1" ChartType="Line">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
</asp:Content>
