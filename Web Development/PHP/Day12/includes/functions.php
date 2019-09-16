<?php

// Write Agent Data into the Database
function writeAgentData($dataArr,$tableName) {
    $servername = "localhost";
    $username = "dbAdmin";
    $password = "L0g1n2db!";
    $dbname = "travelexperts";

    // Create connection
    $conn = new mysqli($servername, $username, $password, $dbname);
    // Check connection
    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    } 
    
    $cols ='';
    $data = '';
    
    $cnt = 0;

// Loop through the array 
    foreach ($dataArr as $k=>$v) {   
        
        if ($cnt == count($dataArr)-1) 
        {
            $cols .= "$k";
            if (is_numeric($v)) 
            {
                $data .= "$v";    
            } 
            else 
            {
                $data .= "'$v'";
            }
            } 
            else 
            {
            $cols .= "$k,";
            if (is_numeric($v)) 
            {
                $data .= "$v,";    
            } 
            else 
            {
                $data .= "'$v',";
            }
        }
        $cnt += 1;
    }

// Insert data into the table
    $sql ="INSERT INTO ".$tableName." (".$cols.") VALUES (". $data.");";
    $submit = $conn->query($sql);

    $conn->close();
    return $submit;
}

//verify user is valid and can login
function verifyLogin($user, $pwd){
    $servername = "localhost";
    $username = "dbAdmin";
    $password = "L0g1n2db!";
    $dbname = "travelexperts";
    
    // Create connection
    $conn = new mysqli($servername, $username, $password, $dbname);
    // Check connection
    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    } 
//check user against database info
    $checkLogin = "SELECT password FROM agents WHERE username = '$user';";
    $verified = $conn -> query($checkLogin);

    if($verified == false){
        return false;
    } else {
        $row = $verified -> fetch_row();
        return password_verify($pwd,$row[0]);
    }
    $conn->close();
}   
?>