<%@ Page Title="BHM - (Posyandu) Imunisasi" Language="C#" MasterPageFile="~/Posyandu.Master" AutoEventWireup="true"
    CodeBehind="Imunisasi.aspx.cs" Inherits="Bhm.Web.Posyandu.Imunisasi" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification" 
        ValidationGroup="RegisterUserValidationGroup"/>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Imunisasi</legend>
                <p>
                    <asp:Label ID="NameLabel" runat="server" AssociatedControlID="Name">Nama Balita:</asp:Label>
                    <asp:TextBox ID="Name" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NameRequired" runat="server" ControlToValidate="Name" 
                        CssClass="failureNotification" ErrorMessage="Nama Balita harus di isi." ToolTip="Nama Balita harus di isi." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="HBOLabel" runat="server" AssociatedControlID="HBO">HBO :</asp:Label>
                    <asp:Calendar ID="HBO" runat="server"></asp:Calendar>
                </p>
                <p>
                    <asp:Label ID="Imun1Label" runat="server" AssociatedControlID="Imun1">BCG, Polio1 :</asp:Label>
                    <asp:Calendar ID="Imun1" runat="server"></asp:Calendar>
                </p>
                <p>
                    <asp:Label ID="Imun2Label" runat="server" AssociatedControlID="Imun2">DPT/HBO1, Polio2 :</asp:Label>
                    <asp:Calendar ID="Imun2" runat="server"></asp:Calendar>
                </p>
                <p>
                    <asp:Label ID="Imun3Label" runat="server" AssociatedControlID="Imun3">DPT/HBO2, Polio3 :</asp:Label>
                    <asp:Calendar ID="Imun3" runat="server"></asp:Calendar>
                </p>
                <p>
                    <asp:Label ID="Imun4Label" runat="server" AssociatedControlID="Imun4">DPT/HBO3, Polio4 :</asp:Label>
                    <asp:Calendar ID="Imun4" runat="server"></asp:Calendar>
                </p>
                <p>
                    <asp:Label ID="Imun5Label" runat="server" AssociatedControlID="Imun5">Campak :</asp:Label>
                    <asp:Calendar ID="Imun5" runat="server"></asp:Calendar>
                </p>
        </fieldset>
        <p class="submitButton">
            <asp:Button ID="ImunisasiButton" runat="server" CommandName="MoveNext" Text="Simpan" 
                ValidationGroup="RegisterUserValidationGroup"/>
        </p>
    </div>

</asp:Content>
