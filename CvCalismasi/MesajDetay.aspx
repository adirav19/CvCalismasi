<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="CvCalismasi.MesajDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Mesaj Detayları</h4>
    <asp:TextBox ID="TextAdsoyad" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextMail" runat="server" CssClass="form-control" Enabled ="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextKonu" runat="server" CssClass="form-control" Enabled =" false"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextMesaj" runat="server" CssClass="form-control" TextMode="MultiLine" Enabled="false"></asp:TextBox>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Iletisim.aspx" CssClass="btn btn-info">Geri Dön</asp:HyperLink>
</asp:Content>
