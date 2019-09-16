<!--
Authors: Owiny Ayorech, Nicolas Tambellini
Date: July, 4 2019
Version: 1.9
Functionality:
-->

<!DOCTYPE html>
   <html>
   <head>
       <!-- Required meta tags -->
       <meta charset="utf-8">
       <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
       <title>Travel Experts</title>
       <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
       <link rel='stylesheet' type="text/css" href='css\reset.css'>
       <link rel='stylesheet' type="text/css" href='css\style.css'>
       <link href="https://fonts.googleapis.com/css?family=Kalam:300,400,700& display=swap" rel="stylesheet">

       <script src="https://kit.fontawesome.com/97d02203ff.js"></script>
       <script src="scripts/script.js"></script>
       <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
       <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
       <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
   </head>
   <div id="holder">
     <body class="bg img-responsive" onload="populateTable();">
           <div class="container header" id="headerDiv">
             <header id="testID">

                 <!-- Nav -->
                 <nav class="navbar navbar-expand-lg navbar-dark container-fluid">

                   <a class="navbar-brand" href="index.php">
                     <img class="main-logo mr-auto img-fluid" src="images\travel\3d-illustration-land-and-a-group-of-suitcases-to-1412103-640x480-Travel-logo.jpg" width="30" height="30" class="d-inline-block align-top img-responsive" alt="">
                     <p class="main-title col">Travel Experts</p>
                   </a>

                   <button class="navbar-toggler navbar-toggler-right pull-right" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                       <span class="navbar-toggler-icon"></span>
                   </button>
                   <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                     <ul class="navbar-nav ml-auto">
                       <li class="nav-item">
                         <a class="nav-link" href="register.php"</a><i class="fas fa-clipboard-check"></i>Register</a>
                       </li>
                       <li class="nav-item">
                         <a class="nav-link" href="contact.php"</a><i class="fas fa-envelope-open-text"></i>Contact</a>
                       </li>
                       <li class="nav-item">
                          <a class="nav-link" href="links.php"</a><i class="fas fa-link"></i>Links</a>
                      </li>
                     </ul>
                   </div>
                 </nav>
                 <div id="wrapper">
                   <div id="ball"></div>
                   <img id="ball" src="images\travel\globe1.jpg"></img>
                 </div>
             </header>
           </div>
<div class="main">