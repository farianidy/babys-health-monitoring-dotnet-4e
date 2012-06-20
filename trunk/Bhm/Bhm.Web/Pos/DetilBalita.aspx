<%@ Page Title="BHM - (Posyandu) Balita" Language="C#" MasterPageFile="~/_Posyandu.Master" AutoEventWireup="true"
    CodeBehind="DetilBalita.aspx.cs" Inherits="Bhm.Web.Pos.DetilBalita" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Informasi Balita</h2>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Data Balita</legend>
            <p>
                <asp:Label ID="BalitaLabel" runat="server">Nama Balita:</asp:Label>
                <asp:TextBox ID="Balita" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="TglLahirLabel" runat="server">Tangal Lahir:</asp:Label>
                <asp:TextBox ID="TglLahir" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="AlamatLabel" runat="server">Alamat:</asp:Label>
                <asp:TextBox ID="Alamat" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="AnakKeLabel" runat="server">Anak Ke:</asp:Label>
                <asp:TextBox ID="AnakKe" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="JKLabel" runat="server">Jenis Kelamin:</asp:Label><br />
                <asp:RadioButton ID="LakiRadioButton" runat="server" Text="Laki-Laki" GroupName="JK" Enabled="false" />
                <asp:RadioButton ID="PerempuanRadioButton" runat="server" Text="Perempuan" GroupName="JK" Enabled="false" />
            </p>
            <p>
                <asp:Label ID="BBLLabel" runat="server">Berat Badan Lahir (kg):</asp:Label>
                <asp:TextBox ID="BBL" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="TBLLabel" runat="server">Tinggi Badan Lahir (cm):</asp:Label>
                <asp:TextBox ID="TBL" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
        </fieldset>
    </div>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Data Ayah</legend>
            <p>
                <asp:Label ID="AyahLabel" runat="server">Nama Ayah:</asp:Label>
                <asp:TextBox ID="Ayah" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="PkjAyahLabel" runat="server">Pekerjaan:</asp:Label>
                <asp:TextBox ID="PkjAyah" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="TglLahirAyahLabel1" runat="server">Tangal Lahir:</asp:Label>
                <asp:TextBox ID="TglLahirAyah" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="AlamatAyahLabel" runat="server">Alamat:</asp:Label>
                <asp:TextBox ID="AlamatAyah" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
        </fieldset>
    </div>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Data Ibu</legend>
            <p>
                <asp:Label ID="IbuLabel" runat="server">Nama Ibu:</asp:Label>
                <asp:TextBox ID="Ibu" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="PkjIbuLabel" runat="server">Pekerjaan:</asp:Label>
                <asp:TextBox ID="PkjIbu" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="TglLahirIbuLabel" runat="server">Tangal Lahir:</asp:Label>
                <asp:TextBox ID="TglLahirIbu" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="AlamatIbuLabel" runat="server">Alamat:</asp:Label>
                <asp:TextBox ID="AlamatIbu" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
            </p>
        </fieldset>
    </div>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Kartu Menuju Sehat</legend>
        </fieldset>
    </div>
</asp:Content>