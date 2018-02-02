<!DOCTYPE html>
<html lang="en">
  	<head>
  		<title>User Data Collected!</title>
	</head>
	<body>
		<?php
			$username = $_POST["username"];
			$password = $_POST["password"];

			echo 'username = '.$username.'</br>';
			echo 'password = '.$password;
	
		?>
	</body>
</html>