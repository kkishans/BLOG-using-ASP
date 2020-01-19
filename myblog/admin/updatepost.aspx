<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="updatepost.aspx.cs" Inherits="myblog.admin.updatepost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="login-content" align="center">
        <h1>Update your Post,
        </h1><br/><br/>
        <asp:Label ID="Label2" runat="server" class="post-list-head" Text="Label">Post Title:</asp:Label>
        <asp:TextBox ID="txtTitle" class="textbox post" placeholder="Title" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label" class="post-list-head">Post Content:</asp:Label><br><br>
        <asp:TextBox ID="txtContent" placeholder="Content" runat="server" 
            class="contentbox" TextMode="MultiLine" ></asp:TextBox>
        <br />
        <asp:Button ID="btnupdatepost" class="loginbtn" runat="server" 
            Text="Update Post" onclick="btnupdatepost_Click"   />
        <br />
         <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
  
</asp:Content>
