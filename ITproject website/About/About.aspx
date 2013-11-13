<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="content_holder">

        <div id = "page">
            <asp:Label ID="title" runat="server"></asp:Label>
            <asp:Panel ID="pagePanel" runat="server">
                <asp:Literal ID="content" runat="server"></asp:Literal>
            </asp:Panel>
            <i><asp:Label ID="author" runat="server"></asp:Label></i>
        </div>
    </div>
</asp:Content>

