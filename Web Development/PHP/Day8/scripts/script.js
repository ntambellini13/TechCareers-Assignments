function focusHint(textId){
   if (textId == "inputFName"){
         var fName = document.getElementById("inputFName");
         fNameHint.innerHTML = "Please enter First Name here"
    } else if (textId == "inputMName") {
         var mName = document.getElementById("inputMName");
         mNameHint.innerHTML = "Please enter Middle Name here"
   } else if (textId == "inputLName") {
         var lName = document.getElementById("inputLName");
         lNameHint.innerHTML = "Please enter Last Name here"
   } else if (textId == "inputPassword") {
         var fPassword = document.getElementById("inputPassword");
         passwordHint.innerHTML = "Please enter your Password here"
   } else if (textId == "inputPostalCode") {
         var fPostalCode = document.getElementById("inputPostalCode");
         postalCodeHint.innerHTML = "Please enter your Postal Code here"
   } else if (textId == "inputEmail") {
         var fEmail = document.getElementById("inputEmail");
         emailHint.innerHTML = "Please enter your Email Address here"
   } else if (textId == "inputApartmentNumber") {
         var fApartmentNumber = document.getElementById("inputApartmentNumber");
         apartmentNumberHint.innerHTML = "Please enter your Apartment Number here"
   } else if (textId == "inputHouseNumber") {
         var fHouseNumber = document.getElementById("inputHouseNumber");
         houseNumberHint.innerHTML = "Please enter your House Number here"
   } else if (textId == "inputStreetName") {
         var fStreetName = document.getElementById("inputStreetName");
         streetNameHint.innerHTML = "Please enter your Street Name here"
   } else if (textId == "inputStreetType") {
         var fStreetName = document.getElementById("inputStreetType");
         streetTypeHint.innerHTML = "Please enter your Street Type here"
   } else if (textId == "inputDirection") {
         var fDirection = document.getElementById("inputDirection");
         directionHint.innerHTML = "Please enter your Direction here"
   } else if (textId == "inputCity") {
         var fDirection = document.getElementById("inputCity");
         cityHint.innerHTML = "Please enter your City here"
   } else if (textId == "inputProvince") {
         var fProvince = document.getElementById("inputProvince");
         provinceHint.innerHTML = "Please select your Province from the list"
   }
 }

 function blurHint(textId){
   if (textId == "inputFName"){
      var fName = document.getElementById("inputFName");
      fNameHint.innerHTML = ""
   } else if (textId == "inputMName") {
      var mName = document.getElementById("inputMName");
      mNameHint.innerHTML = ""
   } else if (textId == "inputLName") {
      var lName = document.getElementById("inputLName");
      lNameHint.innerHTML = ""
   } else if (textId == "inputPassword") {
      var fPassword = document.getElementById("inputPassword");
      passwordHint.innerHTML = ""
   } else if (textId == "inputPostalCode") {
      var fPostalCode = document.getElementById("inputPostalCode");
      postalCodeHint.innerHTML = ""
   } else if (textId == "inputEmail") {
      var fEmail = document.getElementById("inputEmail");
      emailHint.innerHTML = ""
   } else if (textId == "inputApartmentNumber") {
      var fApartmentNumber = document.getElementById("inputApartmentNumber");
      apartmentNumberHint.innerHTML = ""
   } else if (textId == "inputHouseNumber") {
      var fHouseNumber = document.getElementById("inputHouseNumber");
      houseNumberHint.innerHTML = ""
   } else if (textId == "inputStreetName") {
      var fStreetName = document.getElementById("inputStreetName");
      streetNameHint.innerHTML = ""
   } else if (textId == "inputStreetType") {
      var fStreetName = document.getElementById("inputStreetType");
      streetTypeHint.innerHTML = ""
   } else if (textId == "inputDirection") {
      var fDirection = document.getElementById("inputDirection");
      directionHint.innerHTML = ""
   } else if (textId == "inputCity") {
      var fDirection = document.getElementById("inputCity");
      cityHint.innerHTML = ""
   } else if (textId == "inputProvince") {
      var fProvince = document.getElementById("inputProvince");
      provinceHint.innerHTML = ""
   }
 }

 


// ********************* Reusable Functions *****************************

//input ID of parent Element and child element
//returns list of child elements of parent, matching type of child element specified
function getChildrenById(parentID,childType) {
   var parentEl = document.getElementById(parentID);
   // alert('Parent: ' + parentEl);
   var children = parentEl.getElementsByTagName(childType);
   
   
   if (children)
   {
      // alert('children: ' + children);
      return children;
   }
   else 
   {
      return "No Child Elements of that type";
   }
 }

function childFinder() {
   var childrenInput = getChildrenById("inputForm","input");
   // var childrenPara = getChildrenById("inputForm","p");
   
   if (childrenInput)
   {
      var arr = Array.prototype.slice.call(children);
      
      for (i = 0; i < childrenInput.length; i++)
      {
         alert(childrenInput[i] + '--' + i); //list each item in the collection
         // childrenInput[i].setAttribute("onfocus",)
         // childrenInput[i].setAttribute("onblur",)
      }
   }
   else 
   {
      alert("No Children Found");
   }
}
// ********************* Reusable Functions *****************************



// ********************** Form Register Page Code **********************

function searchForEmpty(){
   var fName = document.getElementById('inputFName').value;
   var mName = document.getElementById('inputMName').value;
   var lName = document.getElementById('inputLName').value;
   var eml = document.getElementById('inputEmail').value;
   var password = document.getElementById('inputPassword').value;
   var apartmentNumber = document.getElementById('inputApartmentNumber').value;
   var houseNumber = document.getElementById('inputHouseNumber').value;
   var streetName = document.getElementById('inputStreetName').value;
   var streetType = document.getElementById('inputStreetType').value;
   var direction = document.getElementById('inputDirection').value;
   var city = document.getElementById('inputCity').value;
   var province = document.getElementById('inputProvince').value;
   var postalCode = document.getElementById('inputPostalCode').value;

  // To check empty form fields.
   for (var item = 0; item < regForm.length; item++)
   {
      var currentInputValue = regForm[item]; //assign next value into a variable for processing; causes errors if not.
      if (currentInputValue.value == "" || currentInputValue.value == "Choose..." || currentInputValue.value == false) 
      {
         alert("All fields must be filled out");
        return false;
      }
      
   }
   return true;
}

/*check postal code is in valid format*/
function checkPostalCode() {
   var postalCode = document.getElementById("inputPostalCode").value;
   var re = /^[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]\d$/;
   if (!re.test(postalCode)){
       alert("Please Enter A Valid Postal Code");
       return false;
   } 
       return true;
}

/* form submit and reset buttons*/
function confirmSubmit () {
   var submit = confirm("Are you sure you want to submit this information?");
   return submit;
}

function resetSubmit () {
   var  reset= confirm("Are you sure you want to reset the form?");
   return reset;
}

// ********************** Form Register Page Code **********************



// ****************** IMAGE TABLE HOVER CODE ******************

var imageArr = ["images/js_image/img-1.jpg","images/js_image/img-2.jpg","images/js_image/img-3.jpg","images/js_image/img-4.jpg","images/js_image/img-5.jpg","images/js_image/img-6.jpg","images/js_image/img-7.jpg"];
var descArray = ["Barcelona Spain","Bali Indonesia", "Bangkok Thailand", "Beijing China","Zanzibar Tanzania","Tofino Canada","Sao Paulo"];
var urlArray = ["https://www.lonelyplanet.com/spain/barcelona", "https://www.lonelyplanet.com/indonesia/bali", "https://www.lonelyplanet.com/thailand/bangkok", "https://www.lonelyplanet.com/china/beijing","https://www.lonelyplanet.com/tanzania/zanzibar-island","https://www.lonelyplanet.com/canada/british-columbia/tofino-and-around","https://www.lonelyplanet.com/brazil/sao-paulo"];

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
   // newPara.addEventListener("mouseoff",function(){imageDisappear()},false);
   newPara.addEventListener("click",function(){openURL(idx)},false);


   newPara.appendChild(newText); //add text to para field
   newCell.appendChild(newPara); //add para field to cell
   newRow.appendChild(newCell); //add cell/data to row
   newTable.appendChild(newRow); //add row to table
   
   newRow.setAttribute("class","testImg"); 
}

function imageAppear (idx)
{
   var newDiv = document.getElementById("imgDiv");
   newDiv.innerHTML = "<img src="+imageArr[idx]+" onclick =\"openURL("+idx+")\" class='photo'>";
   
}

function imageDisappear ()
{
   var newDiv = document.getElementById("imgDiv");
}

function openURL (idx)
{
   var newWindow = window.open(urlArray[idx], "newWindow");
   setTimeout(function () {newWindow.close()}, 6000);
}

// ****************** IMAGE TABLE HOVER CODE ******************