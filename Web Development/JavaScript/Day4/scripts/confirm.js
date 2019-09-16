function Submit() {
    if(//check whether all required form button has been clicked)
    {
       var r = confirm("Are you sure to disable this user?");
       if (r == true) {
           //do what ever you need
       }
       else {
        return;
       }
    }
    else{
        alert('Please select a user!!!');
    }
}