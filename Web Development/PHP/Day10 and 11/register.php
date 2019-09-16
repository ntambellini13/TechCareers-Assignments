<!--
Authors: Owiny Ayorech, Nicolas Tambellini
Date: July, 4 2019
Version: 1.9
Functionality:
-->
      <?php
        require "includes/header.php";
      ?>
  
    <!-- Registration Form -->
    <section class='reg-form'>
        <form name="RegForm" id="inputForm" method="POST" action="registerDb.php">
            <div class="form-row">
              <div class="form-group col-md-4">
                <label for="inputFName">First Name</label>
                <input type="text" class="form-control bg-light" id="inputFName" placeholder="First Name" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="fNameHint"></p>
              </div> 
              <div class="form-group col-md-4">
                <label for="inputMName">Middle Name</label>
                <input type="text" class="form-control bg-light" id="inputMName" placeholder="Middle Name (optional)" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="mNameHint"></p>
              </div>

              <div class="form-group col-md-4">
                <label for="inputLName">Last Name</label>
                <input type="text" class="form-control bg-light" id="inputLName" placeholder="Last Name" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="lNameHint"></p>
              </div>
            </div>

            <div class="form-row">
              <div class="form-group col-md-6">
                <label for="inputEmail">Email</label>
                <input type="email" class="form-control bg-light" id="inputEmail" placeholder="Email" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="emailHint"></p>
              </div>

              <div class="form-group col-md-6">
                <label for="inputPassword">Password</label>
                <input type="password" class="form-control bg-light" id="inputPassword" placeholder="Password" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="passwordHint"></p>
             </div>
            </div> 

            <div class="form-row">
              <div class="form-group col-md-4">
                <label for="inputApartmentNumber">Apartment Number</label>
                <input type="text" class="form-control bg-light" id="inputApartmentNumber" placeholder="#101" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="apartmentNumberHint"></p>
              </div>

              <div class="form-group col-md-4">
                <label for="inputHouseNumber">House Number</label>
                <input type="text" class="form-control bg-light" id="inputHouseNumber" placeholder="1234" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="houseNumberHint"></p>
              </div>
              
              <div class="form-group col-md-4">
                <label for="inputStreetName">Street Name</label>
                <input type="text" class="form-control bg-light" id="inputStreetName" placeholder="Main" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="streetNameHint"></p>
              </div>

              <div class="form-group col-md-4">
                <label for="inputStreetType">Street Type</label>
                <input type="text" class="form-control bg-light" id="inputStreetType" placeholder="Avenue" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="streetTypeHint"></p>
              </div>

              <div class="form-group col-md-4">
                  <label for="inputDirection">Direction</label>
                  <input type="text" class="form-control bg-light" id="inputDirection" placeholder="NW" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="directionHint"></p>
              </div>
            </div>

            <div class="form-row">
              <div class="form-group col-md-6">
                <label for="inputCity">City</label>
                <input type="text" class="form-control bg-light" id="inputCity" placeholder="Calgary" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="cityHint"></p>
              </div>
              <div class="form-group col-md-4">
                <label for="inputPostalCode">Postal Code</label>
                <input type="text" class="form-control bg-light" id="inputPostalCode" placeholder="T2E 9B5" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                <p class="hint" id="postalCodeHint"></p>
              </div>
              <div class="form-group col-md-4">
                <label for="inputProvince">Province</label>
                <select id="inputProvince" class="form-control bg-light" onfocus="focusHint(this.id);" onblur="blurHint(this.id);"><br/>
                  <option selected>Choose...</option>
                  <option>AB</option>
                  <option>BC</option>
                  <option>MB</option>
                  <option>NB</option>
                  <option>NL</option>
                  <option>NS</option>
                  <option>NT</option>
                  <option>NU</option>
                  <option>ON</option>
                  <option>PE</option>
                  <option>ON</option>
                  <option>SK</option>
                  <option>YK</option>
                </select>
                <p class="hint" id="provinceHint"></p>
              </div>
            </div>

          <div class="button-toolbar">
              <button type="submit" id="submitButton" value="Submit" class="btn btn-primary" onClick="return confirmSubmit() && searchForEmpty() && checkPostalCode()">Submit</button>
              <!--<button type="submit" id="submitButton" value="Submit" class="btn btn-primary" onClick="return searchForEmpty() && checkPostalCode() && confirmSubmit()">Submit</button>-->
              <button type="reset"  id="resetButton" value="Reset" class="btn btn-danger" onClick="return resetSubmit()">Reset</button>
          </div>   
        </form>
    </section>
           
    <!-- Back button and Copyright -->
    <?php
        require "includes/footer.php";
    ?> 
