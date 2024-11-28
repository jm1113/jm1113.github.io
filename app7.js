


document.getElementById("profileSettingsForm").addEventListener("submit", function(event) {
    event.preventDefault(); 
  
    const username = document.getElementById("username").value;
    const email = document.getElementById("email").value;
    const password = document.getElementById("password").value;
  
    
    if (!username || !email || !password) {
      alert("All fields are required!");
      return;
    }
  
    
    updateUser Profile(username, email, password);
  });
  
  
  function updateUser Profile(username, email, password) {
    const user = firebase.auth().currentUser ;
  
    if (user) {
      
      user.updateEmail(email).then(() => {
        console.log("Email updated successfully.");
       
        return user.updatePassword(password);
      }).then(() => {
        console.log("Password updated successfully.");
        alert("Profile updated successfully!");
        
      }).catch((error) => {
        console.error("Error updating profile:", error);
        alert("Error updating profile: " + error.message);
      });
    } else {
      alert("No user is signed in.");
    }
  }
  
  
  function confirmSignOut() {
    const confirmation = confirm("Are you sure you want to sign out?");
    if (confirmation) {
      signOutUser ();
    }
  }
  
  
  function signOutUser () {
    firebase.auth().signOut().then(() => {
      console.log("User  signed out successfully.");
      alert("You have signed out.");
      
      window.location.href = "index.html"; 
    }).catch((error) => {
      console.error("Error signing out:", error);
      alert("Error signing out: " + error.message);
    });
  }