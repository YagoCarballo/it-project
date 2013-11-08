function changeClass(tagID, className) {
    var currentTag = document.getElementById(tagID);
    currentTag.setAttribute("class", className);
    currentTag.setAttribute("className", className); // IE6
}

function changeView(views, selected) {
    for (var i = 0; i < views.length; i++)
        if (views[i] != null) document.getElementById(views[i]).style.display = "none";
    document.getElementById(selected).style.display = "block";
    document.getElementById(selected).style.visibility = "visible";
}

function showAddUserBox() {
    this.changeClass("add-user-button", "selected");
    this.changeClass("remove-user-button", "");
    this.changeClass("password-user-button", "");
    this.changeClass("display-user-button", "");

    this.changeView(["addUsersBox", "removeUsersBox", "displayUsersBox", "passwordUserBox"], "addUsersBox");
}

function showRemoveUserBox() {
    this.changeClass("add-user-button", "");
    this.changeClass("remove-user-button", "selected");
    this.changeClass("password-user-button", "");
    this.changeClass("display-user-button", "");

    this.changeView(["addUsersBox", "removeUsersBox", "displayUsersBox", "passwordUserBox"], "removeUsersBox");
}

function showPasswordUserBox() {
    this.changeClass("add-user-button", "");
    this.changeClass("remove-user-button", "");
    this.changeClass("password-user-button", "selected");
    this.changeClass("display-user-button", "");

    this.changeView(["addUsersBox", "removeUsersBox", "displayUsersBox", "passwordUserBox"], "passwordUserBox");
}

function showDisplayUserBox() {
    this.changeClass("add-user-button", "");
    this.changeClass("remove-user-button", "");
    this.changeClass("password-user-button", "");
    this.changeClass("display-user-button", "selected");

    this.changeView(["addUsersBox", "removeUsersBox", "displayUsersBox", "passwordUserBox"], "displayUsersBox");
}