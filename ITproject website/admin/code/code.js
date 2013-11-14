function changeClass(tagID, className) {
    var currentTag = document.getElementById(tagID);
    currentTag.setAttribute("class", className);
    currentTag.setAttribute("className", className); // IE6
}

function changeView(views, selected) {
    for (var i = 0; i < views.length; i++) {
        if (views[i] != null) {
            if (document.getElementById(views[i]) != null)
                document.getElementById(views[i]).style.display = "none";
        }
    }
    document.getElementById(selected).style.display = "block";
    document.getElementById(selected).style.visibility = "visible";
}

function hideAll() {
    
}

function showAddUserBox() {
    this.changeClass("add-user-button", "selected");
    this.changeClass("remove-user-button", "");
    this.changeClass("password-user-button", "");
    this.changeClass("display-user-button", "");

    this.changeView(["addUsersBox", "removeUsersBox", "displayUsersBox", "passwordUserBox", "ErrorContent_error_box"], "addUsersBox");
}

    function showRemoveUserBox() {
        this.changeClass("add-user-button", "");
        this.changeClass("remove-user-button", "selected");
        this.changeClass("password-user-button", "");
        this.changeClass("display-user-button", "");

        this.changeView(["addUsersBox", "removeUsersBox", "displayUsersBox", "passwordUserBox", "ErrorContent_error_box"], "removeUsersBox");
    }

    function showPasswordUserBox() {
        this.changeClass("add-user-button", "");
        this.changeClass("remove-user-button", "");
        this.changeClass("password-user-button", "selected");
        this.changeClass("display-user-button", "");

        this.changeView(["addUsersBox", "removeUsersBox", "displayUsersBox", "passwordUserBox", "ErrorContent_error_box"], "passwordUserBox");
    }

    function showDisplayUserBox() {
        this.changeClass("add-user-button", "");
        this.changeClass("remove-user-button", "");
        this.changeClass("password-user-button", "");
        this.changeClass("display-user-button", "selected");

        this.changeView(["addUsersBox", "removeUsersBox", "displayUsersBox", "passwordUserBox", "ErrorContent_error_box"], "displayUsersBox");
    }

    function showDisplayPostsBox() {
        this.changeClass("add-post-button", "");
        this.changeClass("remove-post-button", "");
        this.changeClass("display-post-button", "selected");

        this.changeView(["addPostBox", "removePostBox", "displayPostsBox", "ErrorContent_error_box"], "displayPostsBox");
    }

    function showRemovePostBox() {
        this.changeClass("add-post-button", "");
        this.changeClass("remove-post-button", "selected");
        this.changeClass("display-post-button", "");
        this.changeView(["addPostBox", "removePostBox", "displayPostsBox", "ErrorContent_error_box"], "removePostBox");
    }

    function showAddPostBox() {
        this.changeClass("add-post-button", "selected");
        this.changeClass("remove-post-button", "");
        this.changeClass("display-post-button", "");

        this.changeView(["addPostBox", "removePostBox", "displayPostsBox", "ErrorContent_error_box"], "addPostBox");
    }

    function showDisplayPagesBox() {
        this.changeClass("add-page-button", "");
        this.changeClass("remove-page-button", "");
        this.changeClass("display-page-button", "selected");

        this.changeView(["addPageBox", "removePageBox", "displayPagesBox", "ErrorContent_error_box"], "displayPagesBox");
    }

    function showRemovePagesBox() {
        this.changeClass("add-page-button", "");
        this.changeClass("remove-page-button", "selected");
        this.changeClass("display-page-button", "");
        this.changeView(["addPageBox", "removePageBox", "displayPagesBox", "ErrorContent_error_box"], "removePageBox");
    }

    function showAddPagesBox() {
        this.changeClass("add-page-button", "selected");
        this.changeClass("remove-page-button", "");
        this.changeClass("display-page-button", "");

        this.changeView(["addPageBox", "removePageBox", "displayPagesBox", "ErrorContent_error_box"], "addPageBox");
    }


    function showDisplayJobsBox() {
        this.changeClass("add-job-button", "");
        this.changeClass("remove-job-button", "");
        this.changeClass("display-job-button", "selected");

        this.changeView(["addJobBox", "removeJobBox", "displayJobsBox", "ErrorContent_error_box"], "displayJobsBox");
    }

    function showRemoveJobBox() {
        this.changeClass("add-job-button", "");
        this.changeClass("remove-job-button", "selected");
        this.changeClass("display-job-button", "");
        this.changeView(["addJobBox", "removeJobBox", "displayJobsBox", "ErrorContent_error_box"], "removeJobBox");
    }

    function showAddJobBox() {
        this.changeClass("add-job-button", "selected");
        this.changeClass("remove-job-button", "");
        this.changeClass("display-job-button", "");
        this.changeView(["addJobBox", "removeJobBox", "displayJobsBox", "ErrorContent_error_box"], "addJobBox");
    }

    function showDisplayEventsBox() {
        this.changeClass("add-event-button", "");
        this.changeClass("remove-event-button", "");
        this.changeClass("display-events-button", "selected");

        this.changeView(["addEventBox", "removeEventBox", "displayEventsBox", "ErrorContent_error_box"], "displayEventsBox");
    }

    function showRemoveEventBox() {
        this.changeClass("add-event-button", "");
        this.changeClass("remove-event-button", "selected");
        this.changeClass("display-events-button", "");
        this.changeView(["addEventBox", "removeEventBox", "displayEventsBox", "ErrorContent_error_box"], "removeEventBox");
    }

    function showAddEventBox() {
        this.changeClass("add-event-button", "selected");
        this.changeClass("remove-event-button", "");
        this.changeClass("display-events-button", "");

        this.changeView(["addEventBox", "removeEventBox", "displayEventsBox", "ErrorContent_error_box"], "addEventBox");
    }
