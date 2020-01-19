<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="myblog.admin.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
   <asp:Table ID="Table1" runat="server" CssClass="post-table" 
        CellPadding="2" CellSpacing="2" >
        <asp:TableRow>
            <asp:TableHeaderCell ColumnSpan="4"><h1>All Posts by <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> </h1></asp:TableHeaderCell>

        </asp:TableRow>

        <asp:TableRow>
            <asp:TableHeaderCell CssClass="post-list-head">Post Id</asp:TableHeaderCell>
            <asp:TableHeaderCell  CssClass="post-list-head">Post Title</asp:TableHeaderCell>
            <asp:TableHeaderCell  CssClass="post-list-head">Update</asp:TableHeaderCell>
            <asp:TableHeaderCell  CssClass="post-list-head">Delete</asp:TableHeaderCell>
        </asp:TableRow>
        
    </asp:Table>
    

</asp:Content>
