<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="CvCalismasi.Iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
    <tr>
            <th>ID</th>
            <th>Ad Soyad</th>
            <th>Mail</th>
            <th>Konu</th>
            <th>Mesajo Gör</th>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID")  %></td>
                        <td><%# Eval("Adsoyad")  %></td>
                        <td><%# Eval("Mail")  %></td>
                        <td><%# Eval("Konu")  %></td>
                        <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "MesajDetay.aspx?ID="+Eval("ID")%>' CssClass="btn btn-danger">Mesajı Gör</asp:HyperLink> </td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tr>

    </table>
</asp:Content>
