<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sachas_website.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <table style="border: 1px solid black; background-color:#CA85DB; width: 100%; font-size:25px; padding: 5px 5px 5px 5px; color:white; font-family:Verdana;">
    <tr>
        <td colspan="2" style="height: 28px">
            <b>Login</b>
        </td>
    </tr>
    <tr>
        <td style="width: 204px">User Name</td>    
        <td style="width: 396px">:<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>          
        </td>    
    </tr>
    <tr>
        <td style="width: 204px">
            Password
        </td>    
        <td style="width: 396px">
            :<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ></asp:TextBox>
        </td>    
    </tr>
    <tr>
        <td style="width: 204px; height: 25px">
            <asp:CheckBox ID="chkBoxRememberMe" runat="server" Text="Remember me" />
        </td>
        <td style="width: 396px; height: 25px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Height="29px" />
        </td>
    </tr>
    <tr>
        <td colspan="2" style="height: 119px">
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
    </tr>
    </table>
  
</asp:Content>
