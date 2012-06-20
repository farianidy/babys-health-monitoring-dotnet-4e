<%@ Page Title="" Language="C#" MasterPageFile="~/_Posyandu.Master" AutoEventWireup="true"
    CodeBehind="TambahPegawaiPosyandu.aspx.cs" Inherits="Bhm.Web.Pos.TambahPegawaiPosyandu" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Tambah Akun Pegawai
    </h2>
    <asp:Panel id="successNotificatonPanel" runat="server">
        <p><span>Berhasil menambahkan.</span></p>
    </asp:Panel>
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="TambahAkunValidationSummary" runat="server" CssClass="failureNotification" 
            ValidationGroup="TambahAkunValidationGroup"/>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Informasi Akun</legend>
            <p>
                <asp:Label ID="NameLabel" runat="server" AssociatedControlID="Name">Nama Lengkap:</asp:Label>
                <asp:TextBox ID="Name" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="NameRequired" runat="server" ControlToValidate="Name" 
                        CssClass="failureNotification" ErrorMessage="Nama Lengkap harus di isi." ToolTip="Nama Lengkap harus di isi." 
                        ValidationGroup="TambahAkunValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="InstanceLabel" runat="server">Instansi:</asp:Label>
                <asp:TextBox ID="Instance" runat="server" CssClass="textEntry" Enabled="false" Text="Posyandu"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                        CssClass="failureNotification" ErrorMessage="User Name harus di isi." ToolTip="User Name harus di isi." 
                        ValidationGroup="TambahAkunValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                        CssClass="failureNotification" ErrorMessage="Password harus di isi." ToolTip="Password harus di isi." 
                        ValidationGroup="TambahAkunValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Konfirmasi Password:</asp:Label>
                <asp:TextBox ID="ConfirmPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="ConfirmPassword" CssClass="failureNotification" Display="Dynamic" 
                        ErrorMessage="Confirm Password harus di isi." ID="ConfirmPasswordRequired" runat="server" 
                        ToolTip="Confirm Password harus di isi." ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" 
                        CssClass="failureNotification" Display="Dynamic" ErrorMessage="Password and Konfirmasi Password harus sama."
                        ValidationGroup="TambahAkunValidationGroup">*</asp:CompareValidator>
            </p>
            <p>
                <asp:Label ID="AdminLabel" runat="server">Administrator:</asp:Label><br />
                <asp:RadioButton ID="AdminYa" runat="server" Text="Ya" GroupName="Admin"  />
                <asp:RadioButton ID="AdminTidak" runat="server" Text="Tidak" GroupName="Admin" Checked="true" />
            </p>
        </fieldset>
        <p class="submitButton">
            <asp:Button ID="TambahButton" runat="server" CommandName="MoveNext" Text="Tambah Akun"  OnClick="Tambah_Clicked"
                    ValidationGroup="TambahAkunValidationGroup"/>
        </p>
    </div>
</asp:Content>
