function focusFunc() {
    
    if(textId == "fnameT"){
    var fnameP = document.getElementById("inputFName");
    fnameP.style.color = "blue";
    fnameP.innerHTML = "Please enter first name here";
    }
    else if(textId == "lnameT") {
    var lnameP = document.getElementById("inputLName");
    }

    fnameP.style.color = "blue";
    fnameP.innerHTML = "Please enter first name here";

    lnameP.style.color = "blue";
    lnameP.innerHTML = "Please enter last name here";
}

function blurFunc (textId) {
    if (textId == "fnameT")
    {
        var fnameP = document.getElementById("inputFName");
        fnameP.innerHTML = "";
    }
    else if (textId == "lnameT")
    {
        var lnameP = document.getElementById("inputLName");
        fnameP.innerHTML = "";
}

function confirmSubmit () {
    var submit = confirm("Are you sure you want to submit this information?");
    return submit;
}

function resetSubmit () {
    var  reset= confirm("Are you sure you want to reset the form?");
    return reset;
}

function validate () {
    var fname = document.getElementById("fnameT").nodeValue;

    var lname = document.getElementById("lnameT").nodeValue;

        if (fname == null || lname == null)
            alert("Fill the form name fields please");

}