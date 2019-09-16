<!--
Authors: Owiny Ayorech, Nicolas Tambellini
Date: July, 4 2019
Version: 1.9
Functionality:
-->
      <?php
        require "includes/header.php";
      ?>

  <section>
      
    <div class="container-fluid"> 
    <?php
        
        // set default timezone
        date_default_timezone_set('America/Denver'); // MDT
     
        /* This sets the $time variable to the current hour in the 24 hour clock format */
        $time = date("H");
        /* Set the $timezone variable to become the current timezone */
        /* If the time is less than 1200 hours, show good morning */
        if ($time < "12") {
            $msg = "Good Morning Welcome to Travel Experts! <i class='fas fa-coffee'></i>";
        } else
        /* If the time is grater than or equal to 1200 hours, but less than 1700 hours, so good afternoon */
        if ($time >= "12" && $time < "17") {
          $msg = "Good Afternoon Welcome to Travel Experts! <i class='fas fa-hamburger'></i>";
        } else
        /* Should the time be equal to or greater than 1700 hours, show good evening */
        if ($time >= "17") {
          $msg = "Good Evening Welcome to Travel Experts! <i class='fas fa-wine-bottle'></i>";
        }  

        echo "<div class='welcome'>$msg</div>";

      ?> 
      <table id="descTable" class="table table-dark col-3 ml-3" align="left" border="1" cellpadding="3" cellspacing="0">
        <thead class="thead-light">
          <tr>
            <th>Places To Visit</th>
          </tr>
        </thead>
        </table>
        <div id="imgDiv"></div>
    </div>
  </section>
            <!-- Copyright -->
        
      <?php
        require "includes/footer.php";
      ?> 