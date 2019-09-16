<?php
//Logout user, end session and redirect to index page
session_start();
unset($_SESSION['is_logged_in']);
header("Location:./index.php");
?>