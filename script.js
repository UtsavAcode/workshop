document.getElementById("frm").addEventListener("bt",function(event){
  event.preventDefault();

  var name =  document.getElementById("t1").value;
  var email =document.getElementById("t2").value;
  var password = document.getElementById("p").value;

  var message = "Entered the data:\nName:"+name+"\nEmail"+email+"\nPassword:"+password;
  alert(message);
});