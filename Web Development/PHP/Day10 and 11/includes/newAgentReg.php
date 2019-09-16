<?php

require "includes/functions.php";

            if(isset($_POST['submitButton'])){

            $newAgent= array(
                'AgtFirstName' => $_POST['inputFName'],
                'AgtLastName' => $_POST['inputLName'],
                'AgtMiddleInitial' => $_POST['inputMInit'],
                'AgtBusPhone' => $_POST['inputPhone'],
                'AgtEmail' => $_POST['inputEmail'],
                'AgtPosition' => $_POST['inputAgentPos'],
                'AgencyId' => $_POST['inputAgencyID']);

            if ($_POST['inputMInit'] == ''){
                unset($newAgent[ 'AgtMiddleInitial']);
            }

            try{
                $success = writeAgentData($newAgent,'agents');
                if ($success == TRUE) {
                    $message = "Agent data successfully submitted";
                    echo ($message);
                    date_default_timezone_set('America/Denver');
                    $log = fopen("logs/agentLog.log", "a");
                        fwrite($log, $message.' '.date('Y-m-d H:i:s')."\n");
                        fclose($log);
                }
            } catch(Exception $e){
                    $message = "Error writing data";
                    echo ($message);
                    date_default_timezone_set('America/Denver');
                    $log = fopen("logs/agentLog.log", "a");
                        fwrite($log, $message.' '.date('Y-m-d H:i:s')."\n");
                        fclose($log);
              }
            }
?>       