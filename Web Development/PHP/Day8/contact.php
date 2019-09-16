<!--
Authors: Owiny Ayorech, Nicolas Tambellini
Date: June. 24, 2019
Version: 1.2
Functionality:
-->
      <?php
        require "includes/header.php";
      ?>

    <section class="company-info">
        <div>    
            <ul class="agency-info"><!-- Company Contact Information -->
                <h2><b>Agency Name: Rock & Roll Travel</b></h2>
                <p>Address: 666 Heartbreak Blvd</p>
                <p>Phone#: 1-800-666-5683</p>
                <p>Email: info@rrtravel.com</p>
            </ul>

            </br>
            <!-- Agent Contact Information -->
                        
            <ul class="list-group ">
                <li class="list-group-item active">Agents:</li>
                <li class="list-group-item" >
                    <p class="indent">Agent Name: Bob Dylan</p>
                    <p class="indent">Phone#: 403-666-4141</p>
                    <p class="indent">Email: b.dylan@rrtravel.com</p>
                </li>
                <br>
                <li class="list-group-item">
                    <p class="indent">Agent Name: Jimi Hendrix</p>
                    <p class="indent">Phone#: 403-666-4242</p>
                    <p class="indent">Email: j.henrix@rrtravel.com</p>
                </li>
                <br>
                <li class="list-group-item">
                    <p class="indent">Agent Name: Courtney Love</p>
                    <p class="indent">Phone#: 403-666-6464</p>
                    <p class="indent">Email: c.love@rrtravel.com</p>
                </li>   
            </ul>       
        </div>

        <div id="wrapper" class="img-responsive">
            <div id="ball"></div>
            <img id="ball" src="images\travel\globe1.jpg"></img>
        </div>
  </section> 
  
    <!-- Back button and Copyright -->
    <?php
        require "includes/footer.php";
    ?>