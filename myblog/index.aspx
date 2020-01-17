<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="myblog.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
   
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableHeaderCell ColumnSpan="2">Posts</asp:TableHeaderCell>

        </asp:TableRow>
        
    </asp:Table>
</asp:Content>
