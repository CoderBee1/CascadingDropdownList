<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="DropDownForTask.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Cascading Dropdown List Using - <b>Stored Procedure</b> </h3>
    <p>Author and thier books</p>

       <table class="container-fluid text-center"> 
            <tr>  
                <th>Author</th>  
                <th>:</th>  
                <td>  
                  <asp:DropDownList ID="AuthorDropdownList" runat="server" Width="185px" Height="30px" AutoPostBack="True" OnTextChanged="Page_Load" OnSelectedIndexChanged="AuthorDropdownList_SelectedIndexChanged">  
                      </asp:DropDownList>
                </td>  
            </tr>
           <tr>
               <td> &nbsp;</td>
           </tr>
            <tr>  
                <th width="18%">Book</th>  
                <th width="3%">:</th>  
                <td>  
                    <asp:DropDownList class="dropdown" ID="BookDropdownList" runat="server" Width="185px" Height="30px" OnTextChanged="Page_Load" >
                    </asp:DropDownList>  
                </td>  
            </tr>  
           <tr> 
               <td></td> 
            </tr> 
      </table> 
    <br />
    <br />
     <h3>Cascading Dropdown List Using - <b>Entity Framework</b> </h3>
    <p>Author and thier books</p>

       <table class="container-fluid text-center"> 
            <tr>  
                <th>Author</th>  
                <th>:</th>  
                <td>  
                  <asp:DropDownList ID="DropDownList1" runat="server" Width="185px" Height="30px" AutoPostBack="True" OnTextChanged="Page_Load" OnSelectedIndexChanged="AuthorDropdownList_SelectedIndexChanged">  
                      </asp:DropDownList>
                </td>  
            </tr>
           <tr>
               <td> &nbsp;</td>
           </tr>
            <tr>  
                <th width="18%">Book</th>  
                <th width="3%">:</th>  
                <td>  
                    <asp:DropDownList class="dropdown" ID="DropDownList2" runat="server" Width="185px" Height="30px" OnTextChanged="Page_Load" >
                    </asp:DropDownList>  
                </td>  
            </tr>  
           <tr> 
               <td></td> 
            </tr> 
      </table> 
</asp:Content>
