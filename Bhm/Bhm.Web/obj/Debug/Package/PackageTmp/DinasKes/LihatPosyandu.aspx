<%@ Page Title="BHM - (Dinkes) Posyandu" Language="C#" MasterPageFile="~/Dinkes.Master" AutoEventWireup="true"
    CodeBehind="LihatPosyandu.aspx.cs" Inherits="Bhm.Web.DinasKes.LihatPosyandu" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Lihat Posyandu</h2>
    <asp:GridView ID="GridViewPosyandu" runat="server" AllowPaging="True" 
    AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
    DataKeyNames="idPosyandu" DataSourceID="SqlDataSourcePosyandu"
    ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="idPosyandu" HeaderText="ID" 
                InsertVisible="False" ReadOnly="True" SortExpression="idPosyandu" />
            <asp:BoundField DataField="namaPosyandu" HeaderText="Nama Posyandu" 
                SortExpression="namaPosyandu" />
            <asp:BoundField DataField="desaPosyandu" HeaderText="Desa" 
                SortExpression="desaPosyandu" />
            <asp:BoundField DataField="kecPosyandu" HeaderText="Kecamatan" 
                SortExpression="kecPosyandu" />
            <asp:BoundField DataField="kabPosyandu" HeaderText="Kabupaten" 
                SortExpression="kabPosyandu" />
            <asp:BoundField DataField="provPosyandu" HeaderText="Provinsi" 
                SortExpression="provPosyandu" />
            <asp:CommandField ShowEditButton="True" />
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
    <asp:SqlDataSource ID="SqlDataSourcePosyandu" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DbBhmConnectionString %>" 
        SelectCommand="SELECT * FROM [Posyandu] ORDER BY [idPosyandu]"
        UpdateCommand="UPDATE [Posyandu] SET [namaPosyandu] = @namaPosyandu, [desaPosyandu] = @desaPosyandu,
            [kecPosyandu] = @kecPosyandu, [kabPosyandu] = @kabPosyandu, [provPosyandu] = @provPosyandu
            WHERE [idPosyandu] = @idPosyandu">
    </asp:SqlDataSource>
</asp:Content>
