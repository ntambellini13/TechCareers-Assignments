<?php

    
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

        $sql ="INSERT INTO ".$tableName." (".$cols.") VALUES (". $data.");";
        $submit = $conn->query($sql);

        $conn->close();
        return $submit;
    }
?>