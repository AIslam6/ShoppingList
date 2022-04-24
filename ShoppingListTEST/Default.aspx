<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShoppingListTEST._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="row">
   <div class="col-md-5">   
       Current 
   </div>

    <div class="col-md-1">
       Previous
    </div>

</div>
<div class ="row">
    <div class="col-md-3">
   <table> 
    <tr>
        <td>
            <asp:ListBox ID ="LeftList" runat="Server" SelectionMode="Multiple" Width="230" Rows="10">
            </asp:ListBox>

        </td>
    </tr>
   </table>
    
    </div>
<div class="col-md-2">
<table>
      <tr>
          <td>
            <div class="col-md-1">
                <asp:button ID ="MoveRight" runat="Server" Text =">>" OnClick = "MoveToRight"> </asp:button>
            </div>
              </td>
          <td>
            <div class="col-md-1">
                <asp:button ID ="MoveLeft" runat="Server" Text ="<<" OnClick = "MoveToLeft"> </asp:button>
            </div>
              </td>
          </tr>
    <br/><br/>

    <tr>
        <td>
            <div style="height:10px;"></div>
        </td>
    </tr>

    <tr>
          <td>
            <div class="col-md-1">
                <asp:button ID ="up" runat="Server" Text ="Up" OnClick = "MoveUp"> </asp:button>
            </div>
              </td>
          <td>
            <div class="col-md-1">
                <asp:button ID ="down" runat="Server" Text ="Dn" OnClick = "MoveDown"> </asp:button>
            </div>
           </td>
      </tr>
</table>
</div>
       <div class="col-md-3">
           
        <table>
           <tr>
               <td> 
            <asp:ListBox ID ="RightList" runat="Server" SelectionMode="Multiple" Width="230" Rows="10">  
             </asp:ListBox>
               </td>
            <tr>
       </table>
        </div>
       
</div>
      <div style="height:20px"> </div>
<div class="row">
    <div class="col-md-6">
    <table>
        <tr>
           <td>
           <asp:button ID ="BtnLoadButton" runat="Server" Text ="Load list" OnClick = "LoadButton"> </asp:button>
             <asp:button ID ="BtnClearListButton" runat="Server" Text ="Clear list" OnClick = "ClearListButton"> </asp:button>
               <asp:button ID ="BtnDelete" runat="Server" Text ="Delete" OnClick = "DeleteItem"> </asp:button>
               <asp:button ID ="BtnPrioritise" runat="Server" Text ="Prioritise" OnClick = "PrioritiseItem"> </asp:button>
               <br/><br/>
               <asp:TextBox ID="txtboxitem" runat="server"/>
               <asp:button ID ="BtnAddItem" runat="Server" Text ="Add" OnClick = "AddItem"> </asp:button>
               <asp:button ID ="BtnRename" runat="Server" Text ="Rename" OnClick = "RenameItem"> </asp:button>
           </td>
       </tr>
        
    </table>
</div>
    <div style="height: 20px"></div>
</asp:Content>
