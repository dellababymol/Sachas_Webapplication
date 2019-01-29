<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Sachas_website.Products.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 
        <h1>  
            <asp:Label ID="Label1" runat="server" ForeColor="#CC00FF" Text="Your Cart is empty"></asp:Label>
        </h1>
         <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
                 <table style="width:100%; table-layout:fixed">
                     <tr>
                     <td>                         
                 <asp:DataList ID="DataList1"  runat="server" OnDeleteCommand ="Delete_Command"
                     RepeatDirection="Vertical" RepeatLayout="Table" Width="100%">
                     <AlternatingItemStyle BackColor="White" />
                     <FooterStyle BackColor="#c268cc" Font-Bold="True" ForeColor="White" Font-Size ="40px" />
                     <HeaderStyle BackColor="#c268cc" Font-Bold="True" ForeColor="White" HorizontalAlign="Left"/>
                     <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                     <HeaderTemplate>                   
                      <table style="width:100%; table-layout:fixed;">   
                     <tr>
                       <th style="width: 180px; text-align:left">Product</th>
                       <th style="width: 180px; text-align:left">Product Name</th> 
                       <th style="width: 180px; text-align:left">Product Price</th>
                        <th style="width: 180px; text-align:left">Product Quantity</th>
                       <th style="width: 180px;text-align:left">Remove Cart</th>
                      </tr>
                          </table >
                     </HeaderTemplate>
                     <ItemTemplate>       
                         <table style="width:100% ; table-layout:fixed; text-align:left"> 
                      <tr>                    
                     
                        <td style="width: 192px">  <asp:Image ID="Image2" runat="server" Width ="120px" Height ="160px" ImageUrl='<%#Eval("ImageUrl") %>' />   </td>                      
                                                   
                       <td style="width: 192px"><asp:Label ID="ProductNameLabel" runat="server" Text='<%# Eval("Name") %>' /> </td>                  
                          
                             <td style="width: 192px">$
                        <asp:Label ID="ProductPriceLabel" runat="server" Text= '<%# Eval("Price") %>' />
                        <br />
                         </td>
                             <td style="width: 192px">                
                               
                                 <asp:Label ID="ProductQuantity" runat="server" Text= '<%# Eval("Quantity") %>' />                             
                                                             
                                   </td>                               
                                 <td style="width: 192px">
                                     <asp:Button ID="Button1" runat="server"  Text="Delete" CommandName="delete" />
                                 </td>
                                </tr>                          
                       </table>
                         </ItemTemplate>
                     <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />                    
                 </asp:DataList>                 
                 </td>
                     </tr> 
                     <tr>
                         <td style ="text-align:right; background-color:#c268cc; font-size:40px">
                         <asp:Label ID="lblPrice" runat="server" Text="Label" Visible="False" ForeColor="White" ></asp:Label>
                         </td>
                         </tr>
                     <tr>
                         <td style ="text-align:right; background-color:#c268cc; font-size:40px;">
                              <asp:Button ID="btnCheckOut" runat="server" Font-Bold="true" Font-Size ="Larger" ForeColor="black" OnClick="btnCheckOut_Click" Text="Checkout" />
                             </td>
                     </tr>
                 </table>

             </ContentTemplate>
        </asp:UpdatePanel>
        


</asp:Content>
