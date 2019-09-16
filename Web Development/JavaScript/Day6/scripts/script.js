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
  var regex = /^[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]\d$/
  fPostalCode.setAttribute("pattern",regex.source); // added single backslash before each instance of "d$" to escape them
  fPostalCode.setAttribute("required","true");
  // set custom popup message if invalid postal code entered
   fPostalCode.oninvalid = function(event) {
      event.target.setCustomValidity('Invalid Postal Code Format');}
  postalCodeHint.innerHTML="Please Enter Postal Code";
}

function unFocusPostalCode()
{
   var fPostalCode = document.getElementById("inputPostalCode");
   var regex = /^[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]\d$/
   fPostalCode.setAttribute("pattern",regex.source); // added single backslash before each instance of "d$" to escape them
   fPostalCode.setAttribute("required","true");
   // set custom popup message if invalid postal code entered
    fPostalCode.oninvalid = function(event) {
       event.target.setCustomValidity('Invalid Postal Code Format');}

   postalCodeHint.innerHTML="";
} 


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
    var flgList = new Array(regForm.length);
    
   
  // To check empty form fields.
   for (var item = 0; item < regForm.length; item++)
   {
      var currentInputValue = regForm[item]; //assign next value into a variable for processing; causes errors if not.
      if (currentInputValue.value == "" || currentInputValue.value == "Choose..." || currentInputValue.value == false) 
      {
         flgList[item] = 0; // assign a value indicating an unfilled field to flg array
         alert("All fields must be filled out");
        return false;
      }
      else
      {
         flgList[item] = 1; // assign a value indicating a filled field to flg array         
      }
   }
   return true;
  
} 




var imageArr = ["images/js_image/img-1.jpg","images/js_image/img-2.jpg","images/js_image/img-3.jpg","images/js_image/img-4.jpg"];
var descArray = ["Barcelona Spain","Bali Indonesia", "Bangkok Thailand", "Beijing China"];

function populateTable() 
{
   for (i=0; i < descArray.length; i++)
   {
      loadTable(descArray[i],i);   
   }
}

function loadTable (desc,idx) 
{
   var newTable = document.getElementById("descTable");
   var newRow = document.createElement("tr");
   var newCell = document.createElement("td");
   var newText = document.createTextNode(desc);
   var newPara = document.createElement("p");
   
   newPara.addEventListener("mouseover",function(){imageAppear(idx)},false);
   newPara.addEventListener("mouseoff",function(){imageDisappear()},false);

   newPara.appendChild(newText); //add text to para field
   newCell.appendChild(newPara); //add para field to cell
   newRow.appendChild(newCell); //add cell/data to row
   newTable.appendChild(newRow); //add row to table
   
   newRow.setAttribute("class","testImg");
   
}

function addElement () { 
   // create a new div element 
   var descriptionArr = new Array("w","x","y","z");
   var newDiv = document.createElement("div");
   var newTable = document.createElement("table");
   newTable.setAttribute("id","imgTable");
   
   var orderArrayHeader = ["Description"];
   var thead = document.createElement('thead');


   for (var item = 0; item < descriptionArr.length; item++)
   {
      var newRow = document.createElement("tr");
      newTable.setAttribute("id","imgTable");
      newTable.appendChild(newRow);
   }
   
   // and give it some content 
   // add the text node to the newly created div
   newDiv.appendChild(newText);  
   newDiv.appendChild(newTable);
   
   
   // add the newly created element and its content into the DOM 
   var currentDiv = document.getElementById("addToEnd"); 
   document.body.insertBefore(newDiv, currentDiv); 
 }


function imageAppear (idx)
{
   var newDiv = document.getElementById("imgDiv");
   newDiv.innerHTML = "<img src="+imageArr[idx]+" class='photo'>";  
}

function imageDisappear ()
{
   var newDiv = document.getElementById("imgDiv");
}


