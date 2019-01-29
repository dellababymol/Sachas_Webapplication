<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Sachas_website.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>  Welcome to Sachas Cake</h1>
<h2>A Matter of Taste</h2>
    <div style="color:indigo; font:400; font-family:Calibri; text-align:justify">
         Baking since 1975, we produce various types of cakes every single day. 
        We are constantly driven by the passion of giving you a great tasting, nutrition packed product.     
         </div>       
    <div style="align-content:center">
        <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1"  Width="50%" Height="50%" CssClass="adrotatordisplay"/>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/file/image.xml"></asp:XmlDataSource>

    </div>
</asp:Content>
