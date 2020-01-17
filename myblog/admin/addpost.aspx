<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="addpost.aspx.cs" Inherits="myblog.admin.addpost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-content addpost">
        <asp:TextBox ID="txtTitle" class="textbox post" placeholder="Title" runat="server" 
            Width="500px"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtContent" placeholder="Content" runat="server" 
            class="textbox post" Height="103px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        <br />
        <asp:Button ID="btnaddpost" class="loginbtn post" runat="server" 
            Text="Add Post" onclick="btnaddpost_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
    </div>
</asp:Content>
