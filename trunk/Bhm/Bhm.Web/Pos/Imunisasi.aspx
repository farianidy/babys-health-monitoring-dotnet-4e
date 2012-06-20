<%@ Page Title="BHM - (Posyandu) Imunisasi" Language="C#" MasterPageFile="~/_Posyandu.Master" AutoEventWireup="true"
    CodeBehind="Imunisasi.aspx.cs" Inherits="Bhm.Web.Pos.Imunisasi" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Data Imunisasi</h2>
    <asp:Panel id="successNotificatonPanel" runat="server">
        <p><span>Berhasil menambahkan.</span></p>
    </asp:Panel>
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="CariBalitaValidationSummary" runat="server" CssClass="failureNotification" 
        ValidationGroup="CariBalitaValidationGroup"/>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Balita</legend>
                <p>
                    <asp:Label ID="NameLabel" runat="server" AssociatedControlID="Name">Nama Balita:</asp:Label>
                    <asp:TextBox ID="Name" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NameRequired" runat="server" ControlToValidate="Name" 
                        CssClass="failureNotification" ErrorMessage="Nama Balita harus di isi." ToolTip="Nama Balita harus di isi." 
                        ValidationGroup="CariBalitaValidationGroup">*</asp:RequiredFieldValidator>
                </p>
        </fieldset>
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Imunisasi</legend>
                <p>
                    <asp:Label ID="HBOLabel" runat="server" AssociatedControlID="HBO">HBO :</asp:Label>
                    <asp:TextBox ID="HBO" runat="server" CssClass="textEntry"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender TargetControlID="HBO" ID="HBOCalendarExtender" Format="d/MM/yyyy" runat="server" />
                </p>
                <p>
                    <asp:Label ID="BCGLabel" runat="server" AssociatedControlID="BCG">BCG, Polio1 :</asp:Label>
                    <asp:TextBox ID="BCG" runat="server" CssClass="textEntry"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender TargetControlID="BCG" ID="BCGCalendarExtender" Format="d/MM/yyyy" runat="server" />
                </p>
                <p>
                    <asp:Label ID="DPTLabel" runat="server" AssociatedControlID="DPT">DPT/HBO1, Polio2 :</asp:Label>
                    <asp:TextBox ID="DPT" runat="server" CssClass="textEntry"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender TargetControlID="DPT" ID="DPTCalendarExtender" Format="d/MM/yyyy" runat="server" />
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
