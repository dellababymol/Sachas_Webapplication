<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Sachas_website.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" DataSourceID="odsProduct" Font-Bold="True" RepeatColumns="4"  BorderColor="Purple" BorderWidth="1mm" CellPadding="2" GridLines="Both" Width ="986px" >
                 <ItemStyle  Font-Bold="False"  Font-Names="Times New Roman"  Font-Size="Large" HorizontalAlign="Center" VerticalAlign="Middle" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
                    
                  <ItemTemplate>    
                         <table style ="text-align:center; width: 200px"  >
                             <tr>
                                 <%--OnItemCommand="DataList1_ItemCommand"--%>
                                 <td style="text-align: center" >
                         <asp:Image ID="Image2" runat="server" Width ="120px" ImageUrl='<%#Eval("ProductImage") %>' />

                        <br />
                        <br />
                                     </td>
                                 </tr>
                             <tr><td style="text-align: center">
                        <asp:Label ID="ProductNameLabel" runat="server" Text='<%# Eval("ProductName") %>' />
                        <br />   
                          </td></tr>
                             <tr><td style="text-align: center">$
                        <asp:Label ID="ProductPriceLabel" runat="server" Text= '<%# Eval("ProductPrice") %>' />
                        <br />
                         </td></tr>
                             <tr>
                                 <td style="text-align: center">
 Quantity :                       <asp:DropDownList ID="DropDownList1" runat="server">
                                     <asp:ListItem>1</asp:ListItem>
                                     <asp:ListItem>2</asp:ListItem>
                                     <asp:ListItem>3</asp:ListItem>
                                     <asp:ListItem>4</asp:ListItem>
                                     <asp:ListItem>5</asp:ListItem>
                                 </asp:DropDownList>
                                 </td>
                             </tr>
                             <tr><td style="text-align: center">
                                    <asp:LinkButton ID="LinkButton1"  ForeColor="#964B00" Font-Names="Verdana" Font-Size="10pt" runat="server" CommandArgument='<%# Bind("ProductID")%>' OnClick="LinkButton1_Click1"  >Add Cart</asp:LinkButton>
                                <%--OnClick="LinkButton1_Click"--%>
                                 </td></tr>
                            
                                 <br />
                                 <tr>
                                     <td>
                                         <asp:LinkButton ID="btnremove" runat="server" Font-Names="Verdana" Font-Size="10pt" ForeColor="#964B00" CommandArgument='<%# Bind("ProductID")%>' OnClick="btnremove_Click">RemoveCart</asp:LinkButton>
                                         <td style="text-align: center">&nbsp;</td>
                                     </td>
                                 </tr>
                             
                       </table>
                    </ItemTemplate>
            </asp:DataList>
            <asp:ObjectDataSource ID="odsProduct" runat="server" SelectMethod="GetData" TypeName="BO.ProductsBO"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
