<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="News.aspx.cs" Inherits="News_News" %>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id = "page">

        <div class ="page_title">
            <asp:Label ID="title" runat="server"></asp:Label>
        </div>

        <div class ="page_content">
            <asp:Panel ID="pagePanel" runat="server">
                <asp:Literal ID="content" runat="server"></asp:Literal>
            </asp:Panel>
        </div>

        <div class ="page_footer">
            <i><asp:Label ID="author" runat="server"></asp:Label></i>
        </div>
    </div>
     
</asp:Content>

