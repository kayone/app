<%@ MasterType VirtualPath="App.master" %>
<%@ Page Language="C#" AutoEventWireup="true" 
Inherits="app.web.ui.views.DepartmentBrowser"
CodeFile="DepartmentBrowser.aspx.cs"
 MasterPageFile="App.master" %>
<asp:Content ID="content" runat="server" ContentPlaceHolderID="childContentPlaceHolder">
    <p class="ListHead">Select An Department</p>
            <table>
              <% foreach (var department in this.model)
                 { %>            
              <tr class="ListItem">
               <td><a href='subdepartments/<%= department.id + "/view.iqmetrix" %>'>"><%= department.name %></a></td>
           	  </tr>        
              <% } %>
      	    </table>
</asp:Content>
