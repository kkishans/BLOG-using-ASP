<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="myblog.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="login-content" align="center">
        <h1>Log in here,
        </h1><br/><br/>
        <asp:TextBox ID="txtUname" class="textbox" runat="server" placeholder="user name"></asp:TextBox><br />
        <br />

        <asp:TextBox ID="txtpass" class="textbox" runat="server" TextMode="password" placeholder="password"></asp:TextBox><br/><br/>
        
        <asp:Button ID="btnAdminsubmit" class="loginbtn" runat="server" 
            Text="Log In " onclick="btnAdminsubmit_Click"  />
    </div>

    <asp:Label ID="Label1" runat="server" Text="Label" Visible="false" style="color:Red; text-align:center;" align="center"></asp:Label>
</asp:Content>
