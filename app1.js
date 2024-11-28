
document.addEventListener("DOMContentLoaded", () => {
    const signupButton = document.getElementById("signupButton");
    const signupForm = document.getElementById("signupForm");

    signupButton.addEventListener("click", (event) => {
       
        event.preventDefault();

       
        const username = document.getElementById("username").value.trim();
        const studentID = document.getElementById("ID").value.trim();
        const password = document.getElementById("password").value;
        const confirmPassword = document.getElementById("confirmPassword").value;

       
        if (validateInputs(username, studentID, password, confirmPassword)) {
            
            console.log("Sign Up Successful!");
            alert("Sign Up Successful!"); 
           
            signupForm.reset();
        }
    });

    function validateInputs(username, studentID, password, confirmPassword) {
    
        if (!username || !studentID || !password || !confirmPassword) {
            alert("All fields are required!");
            return false;
        }

        
        if (password !== confirmPassword) {
            alert("Passwords do not match!");
            return false;
        }

      

        return true; 
    }
});