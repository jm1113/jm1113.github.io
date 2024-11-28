
const users = [
    { username: "user1", password: "password1" },
    { username: "user2", password: "password2" },
  ];
  
  
  function signIn(event) {
    
    event.preventDefault();
    
    
    const username = document.getElementById("signinUsername").value;
    const password = document.getElementById("signinPassword").value;
    
 
    const user = users.find(user => user.username === username && user.password === password);
    
 
    const errorBox = document.getElementById("errorBox");
    
    
    if (user) {
      
      window.location.href = "home.html";
    } else {
      
      errorBox.style.display = "block";
    }
  }
  
  
  document.getElementById("signinButton").addEventListener("click", signIn);