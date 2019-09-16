<?php

/*
if (isset($_POST["form-email"]) && !empty($_POST["form-email"])) {
    echo "Yes, mail is set";   
} else {  
    echo "N0, mail is not set";
}*/
$to = $_POST["form-email"];
$subject = 'Hello from Travel Experts!';
$message = 'Thanks for registering with the agency, an agent will contact you in a few days';
$headers = "From: cprg210.travelexperts@gmail.com\r\n";
if (mail($to, $subject, $message, $headers)) {
   echo "Your mail has been sent successfuly ! Thank you for your registering!";
} else {
   echo "Your mail was not sent an ERROR occured";
}

?>

//Back button
<?php
  $url = htmlspecialchars($_SERVER['HTTP_REFERER']);
  echo "<a href='$url'>Click Here to Go Back!</a>"; 
?>
