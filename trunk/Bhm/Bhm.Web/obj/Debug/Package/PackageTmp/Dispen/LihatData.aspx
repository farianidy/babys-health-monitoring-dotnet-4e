<%@ Page Title="BHM - (Dispencapil) Kelahiran Anak" Language="C#" MasterPageFile="~/Dispencapil.Master" AutoEventWireup="true"
    CodeBehind="LihatData.aspx.cs" Inherits="Bhm.Web.Dispen.LihatData" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Lihat Data Kelahiran Anak</h2>
    <asp:GridView ID="GridViewBalita" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
        DataKeyNames="idBalita" DataSourceID="SqlDataSourceBalita" ForeColor="#333333" 
        GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="idBalita" HeaderText="ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="idBalita" />
            <asp:BoundField DataField="namaBalita" HeaderText="Balita" 
                SortExpression="namaBalita" />
            <asp:BoundField DataField="tlBalita" HeaderText="Tanggal Lahir" 
                SortExpression="tlBalita" />
            <asp:BoundField DataField="alamatBalita" HeaderText="Alamat" 
                SortExpression="alamatBalita" />
            <asp:BoundField DataField="anakKe" HeaderText="Anak Ke-" 
                SortExpression="anakKe" />
            <asp:BoundField DataField="jnsKelamin" HeaderText="JK" 
                SortExpression="jnsKelamin" />
            <asp:BoundField DataField="bbl" HeaderText="BBL" SortExpression="bbl" />
            <asp:BoundField DataField="tbl" HeaderText="TBL" SortExpression="tbl" />
            <asp:BoundField DataField="namaAyah" HeaderText="Ayah" 
                SortExpression="namaAyah" />
            <asp:BoundField DataField="pkjAyah" HeaderText="Pekerjaan" 
                SortExpression="pkjAyah" />
            <asp:BoundField DataField="tlAyah" HeaderText="Tanggal Lahir" 
                SortExpression="tlAyah" />
            <asp:BoundField DataField="alamatAyah" HeaderText="Alamat" 
                SortExpression="alamatAyah" />
            <asp:BoundField DataField="namaIbu" HeaderText="Ibu" SortExpression="namaIbu" />
            <asp:BoundField DataField="pkjIbu" HeaderText="Pekerjaan" 
                SortExpression="pkjIbu" />
            <asp:BoundField DataField="tlIbu" HeaderText="Tanggal Lahir" 
                SortExpression="tlIbu" />
            <asp:BoundField DataField="alamatIbu" HeaderText="Alamat" 
                SortExpression="alamatIbu" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceBalita" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DbBhmConnectionString %>" 
        SelectCommand="SELECT Balita.idBalita, Balita.namaBalita, CONVERT(VARCHAR(10),tlBalita,111) as tlBalita,
            Balita.alamatBalita, Balita.anakKe, Balita.jnsKelamin, Balita.bbl, Balita.tbl,
            Ayah.namaAyah, Ayah.pkjAyah, CONVERT(VARCHAR(10),tlAyah,111) as tlAyah, Ayah.alamatAyah,
            Ibu.namaIbu, Ibu.pkjIbu, CONVERT(VARCHAR(10),tlIbu,111) as tlIbu, Ibu.alamatIbu
            FROM Balita INNER JOIN Ayah ON Balita.idAyah = Ayah.idAyah INNER JOIN Ibu ON Balita.idIbu = Ibu.idIbu">
    </asp:SqlDataSource>
</asp:Content>
