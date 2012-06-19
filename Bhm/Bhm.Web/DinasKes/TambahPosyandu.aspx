<%@ Page Title="BHM - (Dinkes) Posyandu" Language="C#" MasterPageFile="~/Dinkes.Master" AutoEventWireup="true"
    CodeBehind="TambahPosyandu.aspx.cs" Inherits="Bhm.Web.DinasKes.TambahPosyandu" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Tambah Posyandu</h2>
    <asp:Panel id="successNotificatonPanel" runat="server">
        <p><span>Berhasil menambahkan</span></p>
    </asp:Panel>
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification" 
        ValidationGroup="RegisterUserValidationGroup"/>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Informasi Posyandu</legend>
                <p>
                    <asp:Label ID="NameLabel" runat="server" AssociatedControlID="Name">Nama Posyandu:</asp:Label>
                    <asp:TextBox ID="Name" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NameRequired" runat="server" ControlToValidate="Name" 
                        CssClass="failureNotification" ErrorMessage="Nama Posyandu harus di isi." ToolTip="Nama Posyandu harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="DesaLabel" runat="server" AssociatedControlID="Desa">Desa:</asp:Label>
                    <asp:TextBox ID="Desa" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DesaRequired" runat="server" ControlToValidate="Desa" 
                        CssClass="failureNotification" ErrorMessage="Desa harus di isi." ToolTip="Desa harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="KecamatanLabel" runat="server" AssociatedControlID="Kecamatan">Kecamatan:</asp:Label>
                    <asp:TextBox ID="Kecamatan" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="KecamatanRequired" runat="server" ControlToValidate="Kecamatan" 
                        CssClass="failureNotification" ErrorMessage="Kecamatan harus di isi." ToolTip="Kecamatan harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="KabupatenLabel" runat="server" AssociatedControlID="Kabupaten">Kabupaten:</asp:Label>
                    <asp:TextBox ID="Kabupaten" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="KabupatenRequired" runat="server" ControlToValidate="Kabupaten" 
                        CssClass="failureNotification" ErrorMessage="Kabupaten harus di isi." ToolTip="Kabupaten harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="ProvinsiLabel" runat="server" AssociatedControlID="Provinsi">Provinsi:</asp:Label>
                    <asp:TextBox ID="Provinsi" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ProvinsiRequired" runat="server" ControlToValidate="Provinsi" 
                        CssClass="failureNotification" ErrorMessage="Provinsi harus di isi." ToolTip="Provinsi harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
        </fieldset>
        <p class="submitButton">
            <asp:Button ID="CreatePosyanduButton" runat="server" CommandName="MoveNext" Text="Tambah" OnClick="Tambah_Clicked"
                ValidationGroup="RegisterUserValidationGroup"/>
        </p>
    </div>
</asp:Content>
