<?php
    require "includes/header.php"
?>

<!-- Login Form -->
        <section class="login">
            <form class="mx-auto" action=""method="post">
                <div div class="form-row">
                    <div class="form-group col-md-12">
                    <label>Username</label>
                        <input class="form-control bg-light" type="text" name="username" id="username"><br>
                    </div>
                </div>

                <div div class="form-row">    
                    <div class="form-group col-md-12">
                    <label>Password</label>
                        <input class="form-control bg-light" type="password" name="password" id="password"><br>
                    </div>
                </div>
                
                <div class="col text-center button-toolbar">
                    <button type="submit" id="submitButton" value="Submit" name="submitLogin" class="btn btn-primary"  onClick="return confirmSubmit()">Submit</button>
                    <!--<button type="submit" id="submitButton" value="Submit" class="btn btn-primary" onClick="return searchForEmpty() && checkPostalCode() && confirmSubmit()">Submit</button>-->
                    <button type="reset"  id="resetButton" value="Reset" class="btn btn-danger" onClick="return resetSubmit()">Reset</button> 
                </div> 
            </form>
        </section>



