<!DOCTYPE html>
<html lang="en">
  	<head>
  		<title>User Data Collected!</title>
	</head>
	<body>
		<?php
			$username = $_GET["username"];
			$password = $_GET["password"];

			echo $username;
			echo $password;
			echo "did it work?"
		?>
	</body>
</html>