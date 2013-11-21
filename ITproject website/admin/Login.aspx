<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="admin_Default2" %>
<%@ MasterType VirtualPath="~/admin/AdminMasterPage.master" %>
<!DOCTYPE HTML>
<html>
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	<title>Mid-Lin Administration Page</title>
	<!-- <link href='http://fonts.googleapis.com/css?family=Oswald:400,300' rel='stylesheet' type='text/css'> -->
	<link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,700' rel='stylesheet' type='text/css'>
	<link rel="stylesheet" type="text/css" href="./style/admin.css">
	<script src="./code/code.js" type="text/javascript"> </script>
</head>
<body>
	<article id="login-box">
		<title>Mid-Lin Admin Login</title>
		<form>
			<img src="http://arlia.computing.dundee.ac.uk/2013-ac22003/ac213u1/img/logo.jpg" alt="mid-lin logo"></img><br /><br />
			<label for="username">Username</label><br /><br />
			<input type="text" id="username"></input>
			
			<label for="password">Password</label><br /><br />
			<input type="password" id="password"></input>
			
			<a href="#" id="loginBtn" runat="server" onclick="LogIn_Btn_Click">Log In</a>
		</form>
	</article>
</body>
</html>
