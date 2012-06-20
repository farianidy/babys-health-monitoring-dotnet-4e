<%@ Page Title="BHM - Balita" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Balita.aspx.cs" Inherits="Bhm.Web.Balita" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Balita</h2>
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="BalitaValidationSummary" runat="server" CssClass="failureNotification" 
            ValidationGroup="BalitaValidationGroup"/>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Data Balita</legend>
            <p>
                <asp:Label ID="BalitaLabel" runat="server" AssociatedControlID="BalitaTb">Nama Balita:</asp:Label>
                <asp:TextBox ID="BalitaTb" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="BalitaRequired" runat="server" ControlToValidate="BalitaTb" 
                        CssClass="failureNotification" ErrorMessage="Nama Balita harus di isi." ToolTip="Nama Balita harus di isi." 
                        ValidationGroup="BalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="AyahLabel" runat="server" AssociatedControlID="Ayah">Nama Ayah:</asp:Label>
                <asp:TextBox ID="Ayah" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="AyahRequired" runat="server" ControlToValidate="Ayah" 
                        CssClass="failureNotification" ErrorMessage="Nama Ayah harus di isi." ToolTip="Nama Ayah harus di isi." 
                        ValidationGroup="BalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="IbuLabel" runat="server" AssociatedControlID="Ibu">Nama Ibu:</asp:Label>
                <asp:TextBox ID="Ibu" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="IbuRequired" runat="server" ControlToValidate="Ibu" 
                        CssClass="failureNotification" ErrorMessage="Nama Ibu harus di isi." ToolTip="Nama Ibu harus di isi." 
                        ValidationGroup="BalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p class="submitButton">
                <asp:Button ID="LihatButton" runat="server" CommandName="MoveNext" Text="Lihat"  OnClick="Lihat_Clicked"
                        ValidationGroup="BalitaValidationGroup"/>
            </p>
        </fieldset>
    </div>
</asp:Content>
