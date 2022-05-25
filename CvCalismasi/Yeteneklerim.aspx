<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="CvCalismasi.Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>YETENEK</th>
            <th>GÜNCELLE</th>
            <th>SİL</th>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID")  %></td>
                        <td><%# Eval("Yetenekler")  %></td>
                        <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#  "YetenekGuncelle.aspx?ID=" + Eval("ID") %>' CssClass="btn btn-primary">Güncelle</asp:HyperLink> </td>
                        <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "YetenekSil.aspx?ID="+Eval("ID")%>' CssClass="btn btn-danger">Sil</asp:HyperLink> </td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tr>

    </table>
    <a href="YeniYetenek.aspx" class="btn btn-danger">Yeni yetenek  ekle</a>
</asp:Content>
