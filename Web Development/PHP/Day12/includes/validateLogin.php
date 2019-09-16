<?php
// start session
session_start();
require "includes/functions.php";
// check login is valid from database values
if (isset($_POST["submitLogin"])){
    $username = $_POST['username'];
    $password = $_POST['password'];
    $verified = verifyLogin($username, $password);
    if($verified){
        $_SESSION['is_logged_in'] = true;

        // direct to new agent registration page
        header("Location:./newAgent.php");
    } else {

        // display error about failed login
        echo ("<p class='headertext'>Please verify your username and password are entered correctly.</p>");
    }
}
?>