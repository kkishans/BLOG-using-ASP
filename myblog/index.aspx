<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="myblog.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="post">
        
        <div class="post-head">
            This is post Head   
        </div>
        <div class="post-body">
            this is about the post.
        </div>
        <div class="post-footer">
            written by Kishan Khant.
        </div>
    </div>
</asp:Content>
