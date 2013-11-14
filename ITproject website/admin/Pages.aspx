<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Pages.aspx.cs" Inherits="admin_Default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<aside id="actions-menu">
    <ul>
        <li><a href="#" id="add-page-button" onclick="showAddPagesBox();">Add / Modify Page</a></li>
        <li><a href="#" id="remove-page-button" onclick="showRemovePagesBox();">Remove Page</a></li>
        <li><a href="#" id="display-page-button" onclick="showDisplayPagesBox();" class="selected">Display Pages</a></li>
    </ul>
</aside>
<br />

<article id="addPageBox" class="action-box" style="display: none; visibility: hidden;">
    <form>
        <table>
            <tr>
                <td colspan="2" style="text-align: left; color: rgb(6, 90, 218); font-weight: 700;">Select the Page to Modify</td>
            </tr>
            <tr style="height: 0.5em;"></tr>
            <tr>
                <td class="field_name"><b>Page to Modify: </b></td>
                <td>
                    <select class="input">
                        <option value="admin">admin</option>
                    </select>
                </td>
            </tr>
            <tr style="height: 2.5em;"></tr>
            <tr>
                <td colspan="2" style="text-align: left; color: rgb(6, 90, 218); font-weight: 700;">Or Fill the Data for the new Page</td>
            </tr>
            <tr style="height: 0.5em;"></tr>
            <tr>
                <td class="field_name"><b>Title: </b></td>
                <td>
                    <input type="text" class="input"></input></td>
            </tr>
            <tr>
                <td class="field_name"><b>Content: </b></td>
                <td>
                    <textarea>Your content here.</textarea></td>
            </tr>
        </table>
        <br />
	<br />
        <aside id="actions-menu" style="float:right;">
            <ul>
                <li><a href="#">Publish</a></li>
		<li><a href="#">Save as draft</a></li>
                <li><a href="#">Cancel</a></li>
            </ul>
        </aside>
        <br />
    </form>
</article>
<article id="removePageBox" class="action-box" style="display: none; visibility: hidden;">
    <form>
        <table>
            <tr>
                <td class="field_name"><b>Page to Remove: </b></td>
                <td>
                    <select class="input">
                        <option value="admin">admin</option>
                    </select>
                </td>
            </tr>
        </table>
        <br />
        <aside id="actions-menu" style="float:right;">
            <ul>
                <li><a href="#">Remove</a></li>
                <li><a href="#">Cancel</a></li>
            </ul>
        </aside>
        <br />
    </form>
</article>
<article id="displayPagesBox" class="action-box" style="display: block;">
    <table>
        <tr class="table-header">
            <td>Title</td>
            <td>Excerpt</td>
        </tr>
        <tr class="table-row">
            <td>Sample page</td>
            <td>An excerpt of up to 50 words...</td>
        </tr>
    </table>
</article>
</asp:Content>
