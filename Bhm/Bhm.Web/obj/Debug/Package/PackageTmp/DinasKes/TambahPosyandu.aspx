<%@ Page Title="BHM - (Dinkes) Posyandu" Language="C#" MasterPageFile="~/Dinkes.Master" AutoEventWireup="true"
    CodeBehind="TambahPosyandu.aspx.cs" Inherits="Bhm.Web.DinasKes.TambahPosyandu" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Tambah Posyandu</h2>
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
                    <asp:Label ID="DesaLabel" runat="server" AssociatedControlID="Desa">Desa Posyandu:</asp:Label>
                    <asp:TextBox ID="Desa" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DesaRequired" runat="server" ControlToValidate="Desa" 
                        CssClass="failureNotification" ErrorMessage="Desa Posyandu harus di isi." ToolTip="Desa Posyandu harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="KecamatanLabel" runat="server" AssociatedControlID="Kecamatan">Kecamatan Posyandu:</asp:Label>
                    <asp:TextBox ID="Kecamatan" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="KecamatanRequired" runat="server" ControlToValidate="Kecamatan" 
                        CssClass="failureNotification" ErrorMessage="Kecamatan Posyandu harus di isi." ToolTip="Kecamatan Posyandu harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="KabupatenLabel" runat="server" AssociatedControlID="Kabupaten">Kabupaten Posyandu:</asp:Label>
                    <asp:TextBox ID="Kabupaten" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="KabupatenRequired" runat="server" ControlToValidate="Kabupaten" 
                        CssClass="failureNotification" ErrorMessage="Kabupaten Posyandu harus di isi." ToolTip="Kabupaten Posyandu harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="ProvinsiLabel" runat="server" AssociatedControlID="Provinsi">Provinsi Posyandu:</asp:Label>
                    <asp:TextBox ID="Provinsi" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ProvinsiRequired" runat="server" ControlToValidate="Provinsi" 
                        CssClass="failureNotification" ErrorMessage="Provinsi Posyandu harus di isi." ToolTip="Provinsi Posyandu harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
        </fieldset>
        <p class="submitButton">
            <asp:Button ID="CreatePosyanduButton" runat="server" CommandName="MoveNext" Text="Tambah Posyandu" 
                ValidationGroup="RegisterUserValidationGroup"/>
        </p>
    </div>
</asp:Content>
