<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="TestUpload.aspx.cs" Inherits="admin_Default" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
  <form id="form1" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <div>
         <table width="50%" cellpadding="2" cellspacing="0"> 
            <tr>   
               <td>
                  <asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="conditional" />       
                     <ContentTemplate>
                        <asp:FileUpload ID="FileUpload" runat="server" />
                        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
                     </ContentTemplate>
                     <Triggers>
                        <asp:PostBackTrigger ControlID="btnUpload" />
                     </Triggers>
                  </asp:UpdatePanel>
               </td>
            </tr>
         </table>
      </div>
   </form>
</asp:Content>