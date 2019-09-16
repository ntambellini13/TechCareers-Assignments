/* First Name*/
function focusFName()
{
   var fName = document.getElementById("inputFName");
   fNameHint.innerHTML="Please Enter First Name";
}

function unFocusFName()
{
   var fName = document.getElementById("inputFName");
   fNameHint.innerHTML="";
}

/* Middle Name*/
function focusMName()
{
   var mName = document.getElementById("inputMName");
   mNameHint.innerHTML="Please Enter Middle Name";
}

function unFocusMName()
{
   var mName = document.getElementById("inputMName");
   mNameHint.innerHTML="";
}

/* Last Name*/
function focusLName()
{
   var mName = document.getElementById("inputLName");
   lNameHint.innerHTML="Please Enter Last Name";
}

function unFocusLName()
{
   var mName = document.getElementById("inputLName");
   lNameHint.innerHTML="";
}

/* Email*/
function focusEmail()
{
   var fEmail = document.getElementById("inputEmail");
   emailHint.innerHTML="Please Enter Email";
}

function unFocusEmail()
{
   var fEmail = document.getElementById("inputEmail");
   emailHint.innerHTML="";
}

/* Password*/
function focusPassword()
{
   var fPassword = document.getElementById("inputPassword");
   passwordHint.innerHTML="Please Enter Password";
}

function unFocusPassword()
{
   var fPassword = document.getElementById("inputPassword");
   passwordHint.innerHTML="";
}

/* Apartment Number*/
function focusApartmentNumber()
{
   var fApartmentNumber = document.getElementById("inputApartmentNumber");
   apartmentNumberHint.innerHTML="Please Enter Apartment Number";
}

function unFocusApartmentNumber()
{
   var fApartmentNumber = document.getElementById("inputApartmentNumber");
   apartmentNumberHint.innerHTML="";
}


/* House Number*/
function focusHouseNumber()
{
   var fHouseNumber = document.getElementById("inputHouseNumber");
   houseNumberHint.innerHTML="Please Enter House Number";
}

function unFocusHouseNumber()
{
   var fHouseNumber = document.getElementById("inputHouseNumber");
   houseNumberHint.innerHTML="";
}

/* Street Name*/
function focusStreetName()
{
   var fStreetName = document.getElementById("inputStreetName");
   streetNameHint.innerHTML="Please Enter Street Name";
}

function unFocusStreetName()
{
   var fStreetName = document.getElementById("inputStreetName");
   streetNameHint.innerHTML="";
}  

/* Street Type*/
function focusStreetType()
{
   var fStreetType = document.getElementById("inputStreetType");
   streetTypeHint.innerHTML="Please Enter Street Type";
}

function unFocusStreetType()
{
   var fStreetType = document.getElementById("inputStreetType");
   streetTypeHint.innerHTML="";
}  

/* Direction*/
function focusDirection()
{
   var fDirection = document.getElementById("inputDirection");
  directionHint.innerHTML="Please Enter Direction";
}

function unFocusDirection()
{
   var fDirection = document.getElementById("inputDirection");
   directionHint.innerHTML="";
}  

/* City*/
function focusCity()
{
   var fCity = document.getElementById("inputCity");
  cityHint.innerHTML="Please Enter City";
}

function unFocusCity()
{
   var fCity = document.getElementById("inputCity");
   cityHint.innerHTML="";
} 

/* Province*/
function focusProvince()
{
   var fProvince = document.getElementById("inputProvince");
  provinceHint.innerHTML="Please Select Province from the list";
}

function unFocusProvince()
{
   var fProvince = document.getElementById("inputProvince");
   provinceHint.innerHTML="";
} 

/*Postal Code*/
function focusPostalCode()
{
  var fPostalCode = document.getElementById("inputPostalCode");
//   fPostalCode.option.[selectedIndex].innerHTML
//   .options[sel.selectedIndex].text
  postalCodeHint.innerHTML="Please Enter Postal Code";
}

function unFocusPostalCode()
{
   var fPostalCode = document.getElementById("inputPostalCode");
   postalCodeHint.innerHTML="";
} 




function confirmSubmit () {
    var submit = confirm("Are you sure you want to submit this information?");
    return submit;
}

function resetSubmit () {
    var  reset= confirm("Are you sure you want to reset the form?");
    return reset;
}
/**************************************************************** */



function formSubmitButton() {
   // Make quick references to our fields.
    var fName = document.getElementById('inputFName');
    var mName = document.getElementById('inputMName');
    var lName = document.getElementById('inputLName');
    var eml = document.getElementById('inputEmail');
    var password = document.getElementById('inputPassword');
    var apartmentNumber = document.getElementById('inputApartmentNumber');
    var houseNumber = document.getElementById('inputHouseNumber');
    var streetName = document.getElementById('inputStreetName');
    var streetType = document.getElementById('inputStreetType');
    var direction = document.getElementById('inputDirection');
    var city = document.getElementById('inputCity');
    var postalCode = document.getElementById('inputPostalCode');
    var province = document.getElementById('inputProvince');
    var flg = 0;
    var regForm = new Array(fName, mName, lName, eml, password, apartmentNumber, houseNumber, streetName, streetType, direction, city, province, postalCode);
    // To check empty form fields.
        for (var item = 0; item < regForm.length; item++){
         currentInputValue = regForm[item];
         if (currentInputValue.value == "" || currentInputValue.value == "Choose..." || currentInputValue.value == false) {
            flg = 0;
            // alert('Blank field');
         }
         else{
            flg = 1;
            // alert(currentInputValue.value);
         }
         
         
            // if (regForm[item].value != "") {
            //    alert('in the reg form loop ');
            // }
            // else if (regForm[item].value == "") {
            //     return false;
            // }
                    
                
        }
      //   alert(flg);
      //   alert('end of validator');
        if (flg == 1){
         alert('All fields filled, submit away');
        //   confirmSubmit();
      }
      else if (flg == 0) {
          alert('Check to see if all fields are filled');
      }
      //   return flg;
    

}

// function submitButton () {
//    alert('We are in the submit button func'); 
//    var flg = checkUserName();
//     if (flg == true){
//        alert('All fields filled, submit away');
//       //   confirmSubmit();
//     }
//     else{
//         alert('Check to see if all fields are filled');
//     }
// }//this function is called on the submit button; it calls all the functions we need to execute


function validatePostalCode() {
    if (/^[A-Z]\d[A-Z] ?\d[A-Z]\d$/.test(inputPostalCode.value))
    {
        return (true)
    }
    
}


function confirmSubmit () {
    var submit = confirm("Are you sure you want to submit this information?");
    return submit;
}

function resetSubmit () {
    var  reset= confirm("Are you sure you want to reset the form?");
    return reset;
}


/************************************************************** */
function formValidation() {

    // Make quick references to our fields.
var fName = document.getElementById('inputFName');
var mName = document.getElementById('inputMName');
var lName = document.getElementById('inputLName');
var eml = document.getElementById('inputEmail');
var password = document.getElementById('inputPassword');
var apartmentNumber = document.getElementById('inputApartmentNumber');
var houseNumber = document.getElementById('inputHouseNumber');
var streetName = document.getElementById('inputStreetName');
var streetType = document.getElementById('inputStreetType');
var direction = document.getElementById('inputDirection');
var city = document.getElementById('inputCity');
var province = document.getElementById('inputProvince');
var postalCode = document.getElementById('inputPostalCode');

var regForm = new Array(fName, mName, lName, eml, password, apartmentNumber, houseNumber, streetName, streetType, direction, city, province, postalCode);
// To check empty form fields.
    for (var item = 0; item < regForm.length; item++){
        if (item.value.length == 0) {
            item.innerText = "*This field needs a to be filled out*"; // This segment displays the validation rule for all fields
            item.focus();
            return false;
            }
    }
}