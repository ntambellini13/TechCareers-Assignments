function submitButton () {
    formValidator();
    /*var flg = formValidator();
    if (flg == 1){
        confirmSubmit();
    }
    else{
        alert('Make sure all fields are filled in')
    }*/
}//this function is called on the submit button; it calls all the functions we need to execute

function formValidator() { 
    var emailEntry = document.getElementById('inputFName');
    var button = document.getElementById('submitButton');
    var defaultButtonText = button.innerHTML;

    emailEntry.onblur = function(){
        var val = this.value;

        // the following IS NOT a valid test of email address validity
        // it's for demo purposes ONLY

        /*if (val.length == 0 || val.indexOf('@') == -1){
            button.innerHTML = 'retry';
            button.style.color = 'red';
        }*/

        if(val.length == 0){
            val.innerHTML = 'retry';
            val.style.color = 'red';
        }
        else {
            button.innerHTML = defaultButtonText;
            button.style.color = 'black';
        }
    };

    button.onclick = function(){
        // prevent submission of the form if the email was found invalid
        // and the innerHTML was therefore set to 'retry'
        if (this.innerHTML == 'retry'){
            return false;
        }
    };
}

function confirmSubmit () {
    var submit = confirm("Are you sure you want to submit this information?");
    return submit;
}

function resetSubmit () {
    var  reset= confirm("Are you sure you want to reset the form?");
    return reset;
}
