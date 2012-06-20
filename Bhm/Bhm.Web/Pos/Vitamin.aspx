<%@ Page Title="BHM - (Posyandu) Vitamin" Language="C#" MasterPageFile="~/_Posyandu.Master" AutoEventWireup="true"
    CodeBehind="Vitamin.aspx.cs" Inherits="Bhm.Web.Pos.Vitamin" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Data Vitamin</h2>
    <asp:Panel id="successNotificatonPanel" runat="server">
        <p><span>Berhasil menambahkan.</span></p>
    </asp:Panel>
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification" 
        ValidationGroup="RegisterUserValidationGroup"/>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Vitamin</legend>
                <p>
                    <asp:Label ID="NameLabel" runat="server" AssociatedControlID="Name">Nama Balita:</asp:Label>
                    <asp:TextBox ID="Name" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NameRequired" runat="server" ControlToValidate="Name" 
                        CssClass="failureNotification" ErrorMessage="Nama Balita harus di isi." ToolTip="Nama Balita harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="BiruLabel" runat="server" AssociatedControlID="Biru">Kapsul Biru :</asp:Label>
                    <asp:Calendar ID="Biru" runat="server"></asp:Calendar>
                </p>
                <p>
                    <asp:Label ID="Merah1Label" runat="server" AssociatedControlID="Merah1">Kapsul Merah 1 :</asp:Label>
                    <asp:Calendar ID="Merah1" runat="server"></asp:Calendar>
                </p>
                <p>
                    <asp:Label ID="Merah2Label" runat="server" AssociatedControlID="Merah2">Kapsul Merah 2 :</asp:Label>
                    <asp:Calendar ID="Merah2" runat="server"></asp:Calendar>
                </p>
                <p>
                    <asp:Label ID="Merah3Label" runat="server" AssociatedControlID="Merah3">Kapsul Merah 3 :</asp:Label>
                    <asp:Calendar ID="Merah3" runat="server"></asp:Calendar>
                </p>
                <p>
                    <asp:Label ID="Merah4Label" runat="server" AssociatedControlID="Merah4">Kapsul Merah 4 :</asp:Label>
                    <asp:Calendar ID="Merah4" runat="server"></asp:Calendar>
                </p>
        </fieldset>
        <p class="submitButton">
            <asp:Button ID="ImunisasiButton" runat="server" CommandName="MoveNext" Text="Simpan" 
                ValidationGroup="RegisterUserValidationGroup"/>
        </p>
    </div>
</asp:Content>
