<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Events.aspx.cs" Inherits="admin_Default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<aside id="actions-menu">
    <ul>
        <li><a href="#" id="add-event-button" onclick="showAddEventBox();">Add / Modify Event</a></li>
        <li><a href="#" id="remove-event-button" onclick="showRemoveEventBox();">Remove Event</a></li>
        <li><a href="#" id="display-events-button" onclick="showDisplayEventsBox();" class="selected">Display Events</a></li>
    </ul>
</aside>
<br />

<article id="addEventBox" class="action-box" style="display: none; visibility: hidden;">
    <form>
        <table>
            <tr>
                <td colspan="2" style="text-align: left; color: rgb(6, 90, 218); font-weight: 700;">Select the Event to Modify</td>
            </tr>
            <tr style="height: 0.5em;"></tr>
            <tr> 
                <td class="field_name"><b>Event Title: </b></td>
                <td>
                    <select class="input">
                        <option value="admin">sample event</option>
                    </select>
                </td>
            </tr>
            <tr style="height: 2.5em;"></tr>
            <tr>
                <td colspan="2" style="text-align: left; color: rgb(6, 90, 218); font-weight: 700;">Or Fill the Data for the new Event</td>
            </tr>
            <tr style="height: 0.5em;"></tr>
            <tr>
                <td class="field_name"><b>Title: </b></td>
                <td>
                    <input type="text" class="input"></input></td>
            </tr>
            <tr>
                <td class="field_name"><b>Description: </b></td>
                <td>
                    <textarea>Your content here.</textarea></td>
            </tr>
	    <tr>
		<td class="field_name"><b>Location: </b></td>
		<td>
		    <input type="text" class="input"></input></td>
	    </tr>
        <tr>
		<td class="field_name"><b>Time: </b></td>
		<td>
		    <input type="text" class="input"></input></td>
	    </tr>
        </table>
        <br />
	<br />
        <aside id="actions-menu" style="float:right;">
            <ul>
                <li><a href="#">Publish</a></li>
                <li><a href="#">Cancel</a></li>
            </ul>
        </aside>
        <br />
    </form>
</article>
<article id="removeEventBox" class="action-box" style="display: none; visibility: hidden;">
    <form>
        <table>
            <tr>
                <td class="field_name"><b>Event to Remove: </b></td>
                <td>
                    <select class="input">
                        <option value="admin">sample event</option>
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
<article id="displayEventsBox" class="action-box" style="display: block;">
    <table>
        <tr class="table-header">
            <td>Title</td>
            <td>Description</td>
            <td>Location</td>
            <td>time</td>
	</tr>
        <tr class="table-row">
            <td>Sample Event</td>
            <td>An excerpt of up to 50 words...</td>
            <td>Mid-Lin Center</td>
            <td>02 / 12 / 2013 - 18:00</td>
	</tr>
    </table>
</article>
</asp:Content>
