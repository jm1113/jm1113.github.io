
function registerUser (username, password) {
    
    if (localStorage.getItem(username)) {
        alert("User  already exists! Please choose a different username.");
        return false;
    }

    
    const userData = {
        username: username,
        password: password 
    };

    localStorage.setItem(username, JSON.stringify(userData));
    alert("User  registered successfully!");
    return true;
}


function loginUser (username, password) {
    const userData = localStorage.getItem(username);

    if (!userData) {
        alert("User  not found! Please register first.");
        return false;
    }

    const parsedData = JSON.parse(userData);

    if (parsedData.password === password) {
        alert("Login successful! Welcome " + username);
        
        window.location.href = "home.html"; 
        return true;
    } else {
        alert("Incorrect password! Please try again.");
        return false;
    }
}


document.getElementById("registerForm").addEventListener("submit", function(event) {
    event.preventDefault(); 

    const username = document.getElementById("registerUsername").value;
    const password = document.getElementById("registerPassword").value;

    
    if (!username || !password) {
        alert("Both fields are required!");
        return;
    }

    
    registerUser (username, password);
});


document.getElementById("loginForm").addEventListener("submit", function(event) {
    event.preventDefault(); 

    const username = document.getElementById("loginUsername").value;
    const password = document.getElementById("loginPassword").value;

   
    if (!username || !password) {
        alert("Both fields are required!");
        return;
    }

    
    loginUser (username, password);
});