<%@ Page Title="BHM - (Dispencapil) Kelahiran Anak" Language="C#" MasterPageFile="~/Dispencapil.Master" AutoEventWireup="true"
    CodeBehind="Pendaftaran.aspx.cs" Inherits="Bhm.Web.Dispen.Pendaftaran" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Pendaftaran Kelahiran Anak</h2>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Panel id="successNotificatonPanel" runat="server">
        <p><span>Berhasil menambahkan.</span></p>
    </asp:Panel>
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="TambahBalitaValidationSummary" runat="server" CssClass="failureNotification" 
            ValidationGroup="TambahBalitaValidationGroup"/>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Data Ayah</legend>
            <p>
                <asp:Label ID="AyahLabel" runat="server" AssociatedControlID="Ayah">Nama Ayah:</asp:Label>
                <asp:TextBox ID="Ayah" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="AyahRequired" runat="server" ControlToValidate="Ayah" 
                        CssClass="failureNotification" ErrorMessage="Nama Ayah harus di isi." ToolTip="Nama Ayah harus di isi." 
                        ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="PkjAyahLabel" runat="server" AssociatedControlID="PkjAyah">Pekerjaan:</asp:Label>
                <asp:TextBox ID="PkjAyah" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PkjAyahRequired" runat="server" ControlToValidate="PkjAyah" 
                        CssClass="failureNotification" ErrorMessage="Pekerjaan Ayah harus di isi." ToolTip="Pekerjaan Ayah harus di isi." 
                        ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="TglLahirAyahLabel" runat="server" AssociatedControlID="TglLahirAyah">Tangal Lahir:</asp:Label>
                <asp:TextBox ID="TglLahirAyah" runat="server" CssClass="textEntry"></asp:TextBox>
                <ajaxToolkit:CalendarExtender TargetControlID="TglLahirAyah" ID="AyahCalendarExtender" Format="d/MM/yyyy" runat="server" />
                <asp:RequiredFieldValidator ID="TglLahirAyahRequired" runat="server" ControlToValidate="TglLahirAyah" 
                        CssClass="failureNotification" ErrorMessage="Tanggal Lahir Ayah harus di isi." ToolTip="Tanggal Lahir Ayah harus di isi." 
                        ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="AlamatAyahLabel" runat="server" AssociatedControlID="AlamatAyah">Alamat:</asp:Label>
                <asp:TextBox ID="AlamatAyah" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="AlamatAyahRequired" runat="server" ControlToValidate="AlamatAyah" 
                        CssClass="failureNotification" ErrorMessage="Alamat Ayah harus di isi." ToolTip="Alamat Ayah harus di isi." 
                        ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
        </fieldset>
    </div>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Data Ibu</legend>
            <p>
                <asp:Label ID="IbuLabel" runat="server" AssociatedControlID="Ibu">Nama Ibu:</asp:Label>
                <asp:TextBox ID="Ibu" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="IbuRequired" runat="server" ControlToValidate="Ibu" 
                        CssClass="failureNotification" ErrorMessage="Nama Ibu harus di isi." ToolTip="Nama Ibu harus di isi." 
                        ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="PkjIbuLabel" runat="server" AssociatedControlID="PkjIbu">Pekerjaan:</asp:Label>
                <asp:TextBox ID="PkjIbu" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PkjIbuRequired" runat="server" ControlToValidate="PkjIbu" 
                        CssClass="failureNotification" ErrorMessage="Pekerjaan Ibu harus di isi." ToolTip="Pekerjaan Ibu harus di isi." 
                        ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="TglLahirIbuLabel" runat="server" AssociatedControlID="TglLahirIbu">Tangal Lahir:</asp:Label>
                <asp:TextBox ID="TglLahirIbu" runat="server" CssClass="textEntry"></asp:TextBox>
                <ajaxToolkit:CalendarExtender TargetControlID="TglLahirIbu" ID="IbuCalendarExtender" Format="d/MM/yyyy" runat="server" />
                <asp:RequiredFieldValidator ID="TglLahirIbuRequired" runat="server" ControlToValidate="TglLahirIbu" 
                        CssClass="failureNotification" ErrorMessage="Tanggal Lahir Ibu harus di isi." ToolTip="Tanggal Lahir Ibu harus di isi." 
                        ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="AlamatIbuLabel" runat="server" AssociatedControlID="AlamatIbu">Alamat:</asp:Label>
                <asp:TextBox ID="AlamatIbu" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="AlamatIbuRequired" runat="server" ControlToValidate="AlamatIbu" 
                        CssClass="failureNotification" ErrorMessage="Alamat Ibu harus di isi." ToolTip="Alamat Ibu harus di isi." 
                        ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
        </fieldset>
    </div>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Data Balita</legend>
            <p>
                <asp:Label ID="BalitaLabel" runat="server" AssociatedControlID="Balita">Nama Balita:</asp:Label>
                <asp:TextBox ID="Balita" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="BalitaRequired" runat="server" ControlToValidate="Balita" 
                        CssClass="failureNotification" ErrorMessage="Nama Balita harus di isi." ToolTip="Nama Balita harus di isi." 
                        ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="TglLahirBalitaLabel" runat="server" AssociatedControlID="TglLahirBalita">Tangal Lahir:</asp:Label>
                <asp:TextBox ID="TglLahirBalita" runat="server" CssClass="textEntry"></asp:TextBox>
                <ajaxToolkit:CalendarExtender TargetControlID="TglLahirBalita" ID="BalitaCalendarExtender" Format="d/MM/yyyy" runat="server" />
                <asp:RequiredFieldValidator ID="TglLahirBalitaRequired" runat="server" ControlToValidate="TglLahirBalita" 
                        CssClass="failureNotification" ErrorMessage="Tanggal Lahir Balita harus di isi." ToolTip="Tanggal Lahir Balita harus di isi." 
                        ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="AlamatBalitaLabel" runat="server" AssociatedControlID="AlamatBalita">Alamat:</asp:Label>
                <asp:TextBox ID="AlamatBalita" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="AlamatBalitaRequired" runat="server" ControlToValidate="AlamatBalita" 
                        CssClass="failureNotification" ErrorMessage="Alamat Balita harus di isi." ToolTip="Alamat Balita harus di isi." 
                        ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="AnakKeLabel" runat="server" AssociatedControlID="AnakKe">Anak Ke:</asp:Label>
                <asp:TextBox ID="AnakKe" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="AnakKeRequired" runat="server" ControlToValidate="AnakKe" 
                    CssClass="failureNotification" ErrorMessage="Anak ke- harus di isi." ToolTip="Anak ke- harus di isi." 
                    ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="JKLabel" runat="server" AssociatedControlID="LakiRadioButton">Jenis Kelamin:</asp:Label>
                <asp:RadioButton ID="LakiRadioButton" runat="server" Text="Laki-Laki" GroupName="JK" Checked="true" />
                <asp:RadioButton ID="PerempuanRadioButton" runat="server" Text="Perempuan" GroupName="JK" />
                <asp:RequiredFieldValidator ID="JKRequired" runat="server" ControlToValidate="JK" 
                    CssClass="failureNotification" ErrorMessage="Jenis Kelamin harus di isi." ToolTip="Jenis Kelamin harus di isi." 
                    ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="BBLLabel" runat="server" AssociatedControlID="BBL">Berat Badan Lahir (kg):</asp:Label>
                <asp:TextBox ID="BBL" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="BBLRequired" runat="server" ControlToValidate="BBL" 
                    CssClass="failureNotification" ErrorMessage="Berat Badan Lahir harus di isi." ToolTip="Berat Badan Lahir harus di isi." 
                    ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
                <asp:CompareValidator id="BBLValidator" runat="server"
                        ErrorMessage="Yang dimasukkan harus berupa angka."
                        ControlToValidate="BBL" Type="Integer"
                        Operator="DataTypeCheck"></asp:CompareValidator>
            </p>
            <p>
                <asp:Label ID="TBLLabel" runat="server">Tinggi Badan Lahir (cm):</asp:Label>
                <asp:TextBox ID="TBL" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="TBLRequired" runat="server" ControlToValidate="TBL" 
                    CssClass="failureNotification" ErrorMessage="Tinggi Badan Lahir harus di isi." ToolTip="Tinggi Badan Lahir harus di isi." 
                    ValidationGroup="TambahBalitaValidationGroup">*</asp:RequiredFieldValidator>
                <asp:CompareValidator id="TBLValidator" runat="server"
                        ErrorMessage="Yang dimasukkan harus berupa angka."
                        ControlToValidate="TBL" Type="Integer" ValidationGroup="RegisterUserValidationGroup"
                        Operator="DataTypeCheck"></asp:CompareValidator>
            </p>
        </fieldset>
        <p class="submitButton">
            <asp:Button ID="TambahButton" runat="server" CommandName="MoveNext" Text="Tambah Akun"  OnClick="Tambah_Clicked"
                    ValidationGroup="TambahBalitaValidationGroup"/>
        </p>
    </div>
</asp:Content>
