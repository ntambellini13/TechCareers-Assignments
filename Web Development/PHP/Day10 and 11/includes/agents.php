<?php
    require 'functions.php';

    $agentData = array(
    "AgtFirstName"=>"Jimi",
     "AgtMiddleInitial"=>"Marshall",
     "AgtLastName"=>"Hendrix",
     "AgtBusPhone"=>"(403)-666-4141",
     "AgtEmail"=>"j.henrix@rrtravel.com",
     "AgtPosition"=>"Agent",
     "AgencyId"=>1); 
         
     writeAgentData($agentData,'agents');
?>
