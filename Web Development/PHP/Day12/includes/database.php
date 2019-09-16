<?php

// Get Database and test connection to the database

function getDatabase () {
    $servername = "localhost";
    $username = "dbAdmin";
    $password = "L0g1n2db!";
    $dbname = "test";

    $conn = new mysqli($servername, $username, $password, $dbname);
    // Check connection
    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    } 
    
    return $conn;
}
?>
   

