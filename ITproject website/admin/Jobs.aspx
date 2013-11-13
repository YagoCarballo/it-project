<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Jobs.aspx.cs" Inherits="admin_Default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<aside id="actions-menu">
    <ul>
        <li><a href="#" id="add-job-button" onclick="showAddJobBox();">Add / Modify Job</a></li>
        <li><a href="#" id="remove-job-button" onclick="showRemoveJobBox();">Remove Job</a></li>
        <li><a href="#" id="display-job-button" onclick="showDisplayJobsBox();" class="selected">Display Jobs</a></li>
    </ul>
</aside>
<br />

<article id="addJobBox" class="action-box" style="display: none; visibility: hidden;">
    <form>
        <table>
            <tr>
                <td colspan="2" style="text-align: left; color: rgb(6, 90, 218); font-weight: 700;">Select the Job to Modify</td>
            </tr>
            <tr style="height: 0.5em;"></tr>
            <tr>
                <td class="field_name"><b>Job to Modify: </b></td>
                <td>
                    <select class="input">
                        <option value="Sample Job">Sample Job</option>
                    </select>
                </td>
            </tr>
            <tr style="height: 2.5em;"></tr>
            <tr>
                <td colspan="2" style="text-align: left; color: rgb(6, 90, 218); font-weight: 700;">Or Fill the Data for the new Job</td>
            </tr>
            <tr style="height: 0.5em;"></tr>
            <tr>
                <td class="field_name"><b>Job name: </b></td>
                <td>
                    <input type="text" class="input"></input></td>
            </tr>
            <tr>
                <td class="field_name"><b>Job description: </b></td>
                <td>
                    <textarea>Your content here.</textarea></td>
            </tr>
	    <tr>
		<td class="field_name"><b>Number of vacancies: </b></td>
		<td>
		    <input type="text" class="input"></input></td>
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
<article id="removeJobBox" class="action-box" style="display: none; visibility: hidden;">
    <form>
        <table>
            <tr>
                <td class="field_name"><b>Job to Remove: </b></td>
                <td>
                    <select class="input">
                        <option value="Sample Job">Sample Job</option>
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
<article id="displayJobsBox" class="action-box" style="display: block;">
    <table>
        <tr class="table-header">
            <td>Title</td>
            <td>Excerpt</td>
	</tr>
        <tr class="table-row">
            <td>Sample job</td>
            <td>Job Description...</td>
	</tr>
    </table>
</article>
</asp:Content>
