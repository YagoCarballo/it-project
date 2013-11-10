<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Users.aspx.cs" Inherits="admin_Default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<aside id="actions-menu">
    <ul>
        <li><a href="#" id="add-post-button" onclick="showAddPostBox();">Add / Modify Post</a></li>
        <li><a href="#" id="remove-post-button" onclick="showRemovePostBox();">Remove Post</a></li>
        <li><a href="#" id="display-post-button" onclick="showDisplayPostBox();" class="selected">Display Posts</a></li>
    </ul>
</aside>
<br />

<article id="addPostBox" class="action-box" style="display: none; visibility: hidden;">
    <form>
        <table>
            <tr>
                <td colspan="2" style="text-align: left; color: rgb(6, 90, 218); font-weight: 700;">Select the Post to Modify</td>
            </tr>
            <tr style="height: 0.5em;"></tr>
            <tr>
                <td class="field_name"><b>Post to Modify: </b></td>
                <td>
                    <select class="input">
                        <option value="admin">admin</option>
                    </select>
                </td>
            </tr>
            <tr style="height: 2.5em;"></tr>
            <tr>
                <td colspan="2" style="text-align: left; color: rgb(6, 90, 218); font-weight: 700;">Or Fill the Data for the new Post</td>
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
                    <textarea rows="15" cols="50" class="input"></textarea></td>
            </tr>
            <tr>
                <td class="field_name"><b>Image: </b></td>
                <td>
                    <input type="file" class="input"></input></td>
            </tr>
        </table>
        <br />
	<br />
        <aside id="actions-menu">
            <ul>
                <li><a href="#">Publish</a></li>
		<li><a href="#">Save as draft</a></li>
                <li><a href="#">Cancel</a></li>
            </ul>
        </aside>
        <br />
    </form>
</article>
<article id="removePostBox" class="action-box" style="display: none; visibility: hidden;">
    <form>
        <table>
            <tr>
                <td class="field_name"><b>Post to Remove: </b></td>
                <td>
                    <select class="input">
                        <option value="admin">admin</option>
                    </select>
                </td>
            </tr>
        </table>
        <br />
        <aside id="actions-menu">
            <ul>
                <li><a href="#">Remove</a></li>
                <li><a href="#">Cancel</a></li>
            </ul>
        </aside>
        <br />
    </form>
</article>
<article id="displayPostsBox" class="action-box" style="display: block;">
    <table>
        <tr class="table-header">
            <td>Title</td>
            <td>Excerpt</td>
            <td>Image</td>
        </tr>
        <tr class="table-row">
            <td>Sample post</td>
            <td>An excerpt of up to 50 words...</td>
            <td>img/sample.png</td>
        </tr>
    </table>
</article>
</asp:Content>
