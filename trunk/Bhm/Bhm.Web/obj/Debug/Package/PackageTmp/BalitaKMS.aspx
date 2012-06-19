<%@ Page Title="BHM - Balita" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BalitaKMS.aspx.cs" Inherits="Bhm.Web.BalitaKMS" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Kartu Menuju Sehat</h2>
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="FindBalitaValidationSummary" runat="server" CssClass="failureNotification" 
            ValidationGroup="FindBalitaValidationGroup"/>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Lihat KMS Balita</legend>
            <p>
                <asp:DropDownList ID="CriteriaDropDown" runat="server">
                    <asp:ListItem Selected="True">ID Balita</asp:ListItem>
                    <asp:ListItem>Nama Balita</asp:ListItem>
                    <asp:ListItem>ID Ayah</asp:ListItem>
                    <asp:ListItem>Nama Ayah</asp:ListItem>
                    <asp:ListItem>ID Ibu</asp:ListItem>
                    <asp:ListItem>Nama Ibu</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="Criteria" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CriteriaRequired" runat="server" ControlToValidate="Criteria" 
                        CssClass="failureNotification" ErrorMessage="Kriteria harus di isi." ToolTip="Kriteria harus di isi." 
                        ValidationGroup="FindBalitaValidationGroup">*</asp:RequiredFieldValidator>
            </p>
        </fieldset>
        <p class="submitButton">
            <asp:Button ID="FindBalitaButton" runat="server" CommandName="MoveNext" Text="Cari" 
                    ValidationGroup="FindBalitaValidationGroup"/>
        </p>
    </div>
</asp:Content>
