<?php
// Submit new agent to database

            if(isset($_POST['submitButton'])){

            // Grab Values from From
            $newAgent= array(
                'AgtFirstName' => $_POST['inputFName'],
                'AgtLastName' => $_POST['inputLName'],
                'AgtMiddleInitial' => $_POST['inputMInit'],
                'AgtBusPhone' => $_POST['inputPhone'],
                'AgtEmail' => $_POST['inputEmail'],
                'AgtPosition' => $_POST['inputAgentPos'],
                'AgencyId' => $_POST['inputAgencyID'],
                'username' => $_POST['username'],
                'password' => password_hash($_POST['password'], PASSWORD_DEFAULT));
            
            // Allow middle name to be null or string
            if ($_POST['inputMInit'] == ''){
                unset($newAgent['AgtMiddleInitial']);
            }

            try{
                $success = writeAgentData($newAgent,'agents');
                if ($success == TRUE) {
                    
                    // show success message on page
                    $message = "Agent data successfully submitted";
                    echo ($message);
                    
                    // log with timestamp
                    date_default_timezone_set('America/Denver');
                    $log = fopen("logs/agentLog.log", "a");
                        fwrite($log, $message.' '.date('Y-m-d H:i:s')."\n");
                        fclose($log);
                }
            } catch(Exception $e){
                    // show error message on page
                    $message = "Error writing data";
                    echo ($message);
                    
                     // log with timestamp
                    date_default_timezone_set('America/Denver');
                    $log = fopen("logs/agentLog.log", "a");
                        fwrite($log, $message.' '.date('Y-m-d H:i:s')."\n");
                        fclose($log);
              }
            }
?>       