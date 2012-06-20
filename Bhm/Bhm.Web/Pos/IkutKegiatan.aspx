<%@ Page Title="BHM - (Posyandu) Kegiatam" Language="C#" MasterPageFile="~/Posyandu.Master" AutoEventWireup="true"
    CodeBehind="IkutKegiatan.aspx.cs" Inherits="Bhm.Web.Posyandu.IkutKegiatan" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Posyandu</h2>
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification" 
        ValidationGroup="RegisterUserValidationGroup"/>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Kegiatan Posyandu</legend>
                <p>
                    <asp:Label ID="NameLabel" runat="server" AssociatedControlID="Name">Nama Balita:</asp:Label>
                    <asp:TextBox ID="Name" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NameRequired" runat="server" ControlToValidate="Name" 
                        CssClass="failureNotification" ErrorMessage="Nama Balita harus di isi." ToolTip="Nama Balita harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="TanggalLabel" runat="server" AssociatedControlID="Tanggal">Tanggal :</asp:Label>
                    <asp:TextBox ID="TglLahirBalita" runat="server" CssClass="textEntry"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender TargetControlID="TglLahirBalita" ID="BalitaCalendarExtender" Format="d/MM/yyyy" runat="server" />
                    <asp:RequiredFieldValidator ID="TanggalRequired" runat="server" ControlToValidate="Tanggal" 
                        CssClass="failureNotification" ErrorMessage="Tanggal kegiatan harus di masukkan." ToolTip="Tanggal Kegiatan harus di masukkan." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="BeratLabel" runat="server" AssociatedControlID="Kecamatan">Berat Badan:</asp:Label>
                    <asp:TextBox ID="Berat" runat="server" CssClass="textEntry"></asp:TextBox> Kg
                    <asp:RequiredFieldValidator ID="BeratRequired" runat="server" ControlToValidate="Berat" 
                        CssClass="failureNotification" ErrorMessage="Berat badan harus di isi." ToolTip="Berat badan harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator id="BeratValidator" runat="server"
                        ErrorMessage="Yang dimasukkan harus berupa angka."
                        ControlToValidate="Berat" Type="Integer" ValidationGroup="RegisterUserValidationGroup"
                        Operator="DataTypeCheck"></asp:CompareValidator>
                </p>
                <p>
                    <asp:Label ID="TinggiLabel" runat="server" AssociatedControlID="Kabupaten">Tinggi Badan:</asp:Label>
                    <asp:TextBox ID="Tinggi" runat="server" CssClass="textEntry"></asp:TextBox> Cm
                    <asp:RequiredFieldValidator ID="TinggiRequired" runat="server" ControlToValidate="Tinggi" 
                        CssClass="failureNotification" ErrorMessage="Tinggi Badan harus di isi." ToolTip="Tinggi Badan harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator id="TinggiValidator" runat="server"
                        ErrorMessage="Yang dimasukkan harus berupa angka."
                        ControlToValidate="Tinggi" Type="Integer" ValidationGroup="RegisterUserValidationGroup"
                        Operator="DataTypeCheck"></asp:CompareValidator>
                </p>
        </fieldset>
        <p class="submitButton">
            <asp:Button ID="IkutKegiatanButton" runat="server" CommandName="MoveNext" Text="Tambah" 
                ValidationGroup="RegisterUserValidationGroup"/>
        </p>
    </div>
</asp:Content>
