﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <!-- 
     <div class ="post">
     <div class ="post_title">

     </div>
     <div class ="post_image">

     </div>
     <div class ="post_content">

     </div>
     <div class ="post_author">

     </div>
</div> 
     -->
<div class="content_holder">
<div class="event">
    <h1>Recent images</h1>
    <img src="http://btckstorage.blob.core.windows.net/site2373/Pics/RBS%201.jpg" />
    
    <img src="http://btckstorage.blob.core.windows.net/site2373/Pics/VF%20Award.JPG" />
    <h2>View our Gallery</h2>
    
    
</div>
    <div class ="front">
        <h1>Latest news</h1>
            <div class ="front_post">
			    <div class="front_image">
				    <img src="http://btckstorage.blob.core.windows.net/site2373/Pics/Mid-Lin%203.JPG" alt="" />
				    <p>We were delighted to attend an Award ceremony today at City Chambers where the Lord Provost, Bob Duncan presented Mid - Lin representatives with a VOLUNTEER FRIENDLY AWARD FOR April 2012 - April 2015</p>
				
			    </div>
			
				     <h2>Welcome Tim                     24/10/2013</p>
			<SCRIPT LANGUAGE="JavaScript">
<!--

			    function changeFontSize(element, step) {
			        step = parseInt(step, 10);
			        var el = document.getElementById(element);
			        var curFont = parseInt(el.style.fontSize, 10);
			        el.style.fontSize = (curFont + step) + 'px';
			    }

//   -->
</script>
	<a href="javascript:void(0);" onclick="changeFontSize('content','2');">Increase font</a>
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<a href="javascript:void(0);" onclick="changeFontSize('content',-2);">Decrease font</a>
<br /><br />
<p id="content" style="font-size:12px;"><br /><br />
	This is the test text to increase or decrease.
</p>

			     <p>Author: Tom Riddle</p>
			    </div>
		    </div>


     </div>
</div>
</asp:Content>

