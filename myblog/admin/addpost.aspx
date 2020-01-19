<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="addpost.aspx.cs" Inherits="myblog.admin.addpost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-content" align="center">
        <h1>Add New Post,
        </h1><br/><br/>
        <asp:Label ID="Label1" runat="server" class="post-list-head" Text="Label">Post Title:</asp:Label>
        <asp:TextBox ID="txtTitle" class="textbox post" placeholder="Title" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label" class="post-list-head">Post Content:</asp:Label><br><br>
        <asp:TextBox ID="txtContent" placeholder="Content" runat="server" 
            class="contentbox" TextMode="MultiLine" ></asp:TextBox>
        <br />
        <asp:Button ID="btnaddpost" class="loginbtn" runat="server" 
            Text="Add Post" onclick="btnaddpost_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br />
    </div>>
    
   
</asp:Content>
