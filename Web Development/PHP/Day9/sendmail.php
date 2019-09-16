<?php

if(isset($_POST["submit"])){
  // Checking For Blank Fields..
  if($_POST["comments"]==""){
  echo "leave a message in text area please..";
  }else{
  // Check if the "Sender's Email" input field is filled out
  $email=$_POST['form-email'];
  // Sanitize E-mail Address
  $email =filter_var($email, FILTER_SANITIZE_EMAIL);
  // Validate E-mail Address
  $email= filter_var($email, FILTER_VALIDATE_EMAIL);
  if (!$email){
  echo "Invalid Sender's Email";
  }
  else{
  $email2 = "cprg210.travelexperts@gmail.com";
  $message = $_POST['comments'];
  $headers = 'From:'. $email2 . "rn"; // Sender's Email
  $headers .= 'Cc:'. $email2 . "rn"; // Carbon copy to Sender
  // Message lines should not exceed 70 characters (PHP rule), so wrap it
  $message = wordwrap($message, 70);
  // Send Mail By PHP Mail Function
  $to = $email;
  $subject = 'Hello from Travel Experts!';
  $message = 'Thanks for registering with the agency, an agent will contact you in a few days';
  if (mail($to, $subject, $message, $headers)) {
      echo "Your mail has been sent successfuly ! Thank you for your registering!";
  } else {
      echo "Your mail was not sent an ERROR occured";
  }
  
  }
  }
  }

/*// alert("Thank You for Registering with Travel Experts!");

  // Before using $_POST['value'] - check if the value exists
  if (isset($_POST['email'])) 
  { 
  // Instructions if $_POST['value'] exist 
  $email = $_POST['email'];
  echo "this is valid email $email";
  exit(0);
  } 
  */  
  

/*
function alert($msg) {
    echo "<script type='text/javascript'>alert('$msg');</script>";
}*/
?>

//Back button
<?php
  $url = htmlspecialchars($_SERVER['HTTP_REFERER']);
  echo "<a href='$url'>Click Here to Go Back!</a>"; 
?>
