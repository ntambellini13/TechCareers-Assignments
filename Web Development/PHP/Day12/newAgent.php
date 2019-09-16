<?php
include('includes/header.php');
if(!isset($_SESSION['is_logged_in'])){
  header("Location:./index.php");
} 
?>
    <!-- New Agent Form -->
    <section>
        <form class="reg-form mx-auto" name="agentForm" id="inputForm" method="POST" action="">
            <div class="form-row">
              <div class="form-group col-md-4">
                <label for="fName">Agent First Name</label>
                <input type="text" class="form-control bg-light" name="inputFName" id="inputFName" placeholder="Bob" required>
              </div> 

              <div class="form-group col-md-4">
                <label for="mInit">Agent Middle Initial</label>
                <input type="text" class="form-control bg-light" name="inputMInit" id="inputMInit" placeholder="P." pattern="[A-Za-z]\.?">
              </div> 

              <div class="form-group col-md-4">
                <label for="LName">Agent Last Name</label>
                <input type="text" class="form-control bg-light" name="inputLName" id="inputLName" placeholder="Smith" required>
              </div> 
            </div>

            <div class="form-row">
              <div class="form-group col-md-4">
                <label for="fPhone">Agent Phone Number</label>
                <input type="text" class="form-control bg-light" name="inputPhone" id="inputPhone" placeholder="(403) 666-1234" pattern = "\(\d{3}\) \d{3}[\-]\d{4}" required>
              </div> 

              <div class="form-group col-md-4">
                <label for="fEmail">Agent Email</label>
                <input type="email" class="form-control bg-light" name="inputEmail" id="inputEmail" placeholder="bob@rrtravel.com" required>
              </div> 

              <div class="form-group col-md-4">
                <label for="agencyID">Agency</label>
                <select name="inputAgentPos" id="inputAgentPos" class="form-control bg-light" required>
                  <option selected value= ''>Choose...</option>
                  <option value= "Junior Agent">Junior Agent</option>
                  <option value= "Intermediate Agent">Intermediate Agent</option>
                  <option value= "Senior Agent">Senior Agent</option>
                </select>
            </div>
            </div>

            <div class="form-row">
              <div class="form-group col-md-4">
                  <label for="agencyID">Agency</label>
                  <select name="inputAgencyID" id="inputAgencyID" class="form-control bg-light" required>
                    <option selected value= ''>Choose...</option>
                    <option value=1>1155 8th Ave SW, Calgary AB</option>
                    <option value=2>110 Main Street, Okotoks AB</option>
                  </select>
              </div>
              <div class="form-group col-md-4">
                <label for="username">Username</label>
                <input type="text" name="username" id="username" placeholder="bsmith" class="form-control bg-light" required><br>
              </div>
              
              <div class="form-group col-md-4">
                <label for="password">Password</label>
                <input type="password" name="password" id="password"  class="form-control bg-light" required><br>
              </div>
            </div> 

            <div class="mb-2 button-toolbar">
                <button type="submit" id="submitButton" value="Submit" name="submitButton" class="btn btn-primary" onClick="return confirmSubmit()">Submit</button>
                <!--<button type="submit" id="submitButton" value="Submit" class="btn btn-primary" onClick="return searchForEmpty() && checkPostalCode() && confirmSubmit()">Submit</button>-->
                <button type="reset"  id="resetButton" value="Reset" class="btn btn-danger" onClick="return resetSubmit()">Reset</button>
            </div> 

            <?php
             require "includes/newAgentReg.php";
            ?>
        </form>
    </section>           
<?php
    require "includes/footer.php";
?> 