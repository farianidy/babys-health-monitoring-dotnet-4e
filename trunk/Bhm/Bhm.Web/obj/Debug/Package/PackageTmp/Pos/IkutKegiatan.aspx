<%@ Page Title="BHM - (Posyandu) Kegiatam" Language="C#" MasterPageFile="~/_Posyandu.Master" AutoEventWireup="true"
    CodeBehind="IkutKegiatan.aspx.cs" Inherits="Bhm.Web.Pos.IkutKegiatan" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Posyandu</h2>
    <asp:Panel id="successNotificatonPanel" runat="server">
        <p><span>Berhasil menambahkan.</span></p>
    </asp:Panel>
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="IkutKegiatanValidationSummary" runat="server" CssClass="failureNotification" 
        ValidationGroup="IkutKegiatanValidationGroup"/>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Kegiatan Posyandu</legend>
                <p>
                    <asp:Label ID="NameLabel" runat="server" AssociatedControlID="Balita">Nama Balita:</asp:Label>
                    <asp:TextBox ID="Balita" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NameRequired" runat="server" ControlToValidate="Balita" 
                        CssClass="failureNotification" ErrorMessage="Nama Balita harus di isi." ToolTip="Nama Balita harus di isi." 
                        ValidationGroup="IkutKegiatanValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="PosyanduLabel" runat="server" AssociatedControlID="Posyandu">Nama Posyandu:</asp:Label>
                    <asp:TextBox ID="Posyandu" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="PosyanduRequired" runat="server" ControlToValidate="Posyandu" 
                        CssClass="failureNotification" ErrorMessage="Nama Posyandu harus di isi." ToolTip="Nama Posyandu harus di isi." 
                        ValidationGroup="IkutKegiatanValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="TanggalLabel" runat="server" AssociatedControlID="Tanggal">Tanggal :</asp:Label>
                    <asp:TextBox ID="Tanggal" runat="server" CssClass="textEntry" Enabled="false"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="BeratLabel" runat="server" AssociatedControlID="Berat">Berat Badan (kg):</asp:Label>
                    <asp:TextBox ID="Berat" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="BeratRequired" runat="server" ControlToValidate="Berat" 
                        CssClass="failureNotification" ErrorMessage="Berat Badan harus di isi." ToolTip="Berat Badan harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator id="BeratValidator" runat="server"
                        ErrorMessage="Data harus berupa angka."
                        ControlToValidate="Berat" Type="Double" ValidationGroup="IkutKegiatanValidationGroup"
                        Operator="DataTypeCheck"></asp:CompareValidator>
                </p>
                <p>
                    <asp:Label ID="TinggiLabel" runat="server" AssociatedControlID="Tinggi">Tinggi Badan (cm):</asp:Label>
                    <asp:TextBox ID="Tinggi" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="TinggiRequired" runat="server" ControlToValidate="Tinggi" 
                        CssClass="failureNotification" ErrorMessage="Tinggi Badan harus di isi." ToolTip="Tinggi Badan harus di isi." 
                        ValidationGroup="IkutKegiatanValidationGroup">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator id="TinggiValidator" runat="server"
                        ErrorMessage="Data harus berupa angka."
                        ControlToValidate="Tinggi" Type="Double" ValidationGroup="IkutKegiatanValidationGroup"
                        Operator="DataTypeCheck"></asp:CompareValidator>
                </p>
        </fieldset>
        <p class="submitButton">
            <asp:Button ID="IkutKegiatanButton" runat="server" CommandName="MoveNext" Text="Tambah" OnClick="Tambah_Clicked" 
                ValidationGroup="IkutKegiatanValidationGroup"/>
        </p>
    </div>
</asp:Content>
