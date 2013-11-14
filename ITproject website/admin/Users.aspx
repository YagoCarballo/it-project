<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Users.aspx.cs" Inherits="admin_Default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<aside id="actions-menu">
    <ul>
        <li><a href="#" id="add-user-button" onclick="showAddUserBox();">Add / Modify User</a></li>
        <li><a href="#" id="remove-user-button" onclick="showRemoveUserBox();">Remove User</a></li>
        <li><a href="#" id="password-user-button" onclick="showPasswordUserBox();">Change User's Password</a></li>
        <li><a href="#" id="display-user-button" onclick="showDisplayUserBox();" class="selected">Display Users</a></li>
    </ul>
</aside>
<br />

<article id="addUsersBox" class="action-box" style="display: none; visibility: hidden;">
    <form>
        <table>
            <tr>
                <td colspan="2" style="text-align: left; color: rgb(6, 90, 218); font-weight: 700;">Select the User to Modify</td>
            </tr>
            <tr style="height: 0.5em;"></tr>
            <tr>
                <td class="field_name"><b>User to Modify: </b></td>
                <td>
                    <select class="input">
                        <option value="admin">admin</option>
                    </select>
                </td>
            </tr>
            <tr style="height: 2.5em;"></tr>
            <tr>
                <td colspan="2" style="text-align: left; color: rgb(6, 90, 218); font-weight: 700;">Or Fill the Data for the new User</td>
            </tr>
            <tr style="height: 0.5em;"></tr>
            <tr>
                <td class="field_name"><b>Username: </b></td>
                <td>
                    <input type="text" class="input"></input></td>
            </tr>
            <tr>
                <td class="field_name"><b>Password: </b></td>
                <td>
                    <input type="password" class="input"></input></td>
            </tr>
            <tr>
                <td class="field_name"><b>Name: </b></td>
                <td>
                    <input type="text" class="input"></input></td>
            </tr>
            <tr>
                <td class="field_name"><b>Surname: </b></td>
                <td>
                    <input type="text" class="input"></input></td>
            </tr>
            <tr>
                <td class="field_name"><b>Email: </b></td>
                <td>
                    <input type="text" class="input"></input></td>
            </tr>
        </table>
        <br />
        <br />
        <aside id="actions-menu" style="float:right;">
            <ul>
                <li><a href="#">Save / Update</a></li>
                <li><a href="#">Cancel</a></li>
            </ul>
        </aside>
        <br />
    </form>
</article>
<article id="removeUsersBox" class="action-box" style="display: none; visibility: hidden;">
    <form>
        <table>
            <tr>
                <td class="field_name"><b>User to Remove: </b></td>
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
                <li><a href="#">remove</a></li>
                <li><a href="#">Cancel</a></li>
            </ul>
        </aside>
        <br />
    </form>
</article>
<article id="passwordUserBox" class="action-box" style="display: none; visibility: hidden;">
    <form>
        <table>
            <tr>
                <td class="field_name"><b>User to Change Password: </b></td>
                <td>
                    <select class="input">
                        <option value="admin">admin</option>
                    </select>
                </td>
                <tr>
                    <td class="field_name"><b>Old Password: </b></td>
                    <td>
                        <input type="text" class="input"></input></td>
                </tr>
                <tr>
                    <td class="field_name"><b>New Password: </b></td>
                    <td>
                        <input type="text" class="input"></input></td>
                </tr>
                <tr>
                    <td class="field_name"><b>Repeat New Password: </b></td>
                    <td>
                        <input type="text" class="input"></input></td>
                </tr>
            </tr>
        </table>
        <br />
        <aside id="actions-menu" style="float:right;">
            <ul>
                <li><a href="#">Update</a></li>
                <li><a href="#">Cancel</a></li>
            </ul>
        </aside>
        <br />
    </form>
</article>
<article id="displayUsersBox" class="action-box" style="display: block;">
    <table>
        <tr class="table-header">
            <td>Username</td>
            <td>Email</td>
            <td>Name</td>
            <td>Surname</td>
        </tr>
        <tr class="table-row">
            <td>admin</td>
            <td>managermidlin@yahoo.co.uk</td>
            <td>Gwen</td>
            <td>Joubert</td>
        </tr>
    </table>
</article>
</asp:Content>