<%@ Page Title="BHM - (Dinkes) Posyandu" Language="C#" MasterPageFile="~/Dinkes.Master" AutoEventWireup="true"
    CodeBehind="LihatPosyandu.aspx.cs" Inherits="Bhm.Web.DinasKes.LihatPosyandu" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Lihat Posyandu</h2>
    <asp:GridView ID="GridViewPosyandu" runat="server" AllowPaging="True" 
    AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
    DataKeyNames="idPosyandu" DataSourceID="SqlDataSourcePosyandu" 
        BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
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
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#000000" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourcePosyandu" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DbBhmConnectionString %>" 
        SelectCommand="SELECT * FROM [Posyandu] ORDER BY [idPosyandu]"
        UpdateCommand="UPDATE [Posyandu] SET [namaPosyandu] = @namaPosyandu, [desaPosyandu] = @desaPosyandu,
            [kecPosyandu] = @kecPosyandu, [kabPosyandu] = @kabPosyandu, [provPosyandu] = @provPosyandu
            WHERE [idPosyandu] = @idPosyandu">
    </asp:SqlDataSource>
</asp:Content>
