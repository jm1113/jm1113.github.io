

const menu = document.querySelector("#mobile-menu");
const menuLinks = document.querySelector(".navbar__menu");
menu.addEventListener("click", function () {
  menu.classList.toggle("is-active");
  menuLinks.classList.toggle("active");
});

let posts = [];

function addPost() {
  const postContent = document.getElementById("postContent").value;
  if (postContent.trim() !== "") {
    const newPost = {
      id: Date.now(),
      content: postContent,
      likes: 0,
      comments: [],
    };
    posts.unshift(newPost);
    document.getElementById("postContent").value = "";
    displayPosts();
  }
}

function addComment(postId) {
  const commentInput = document.getElementById(`commentInput-${postId}`);
  const commentText = commentInput.value;
  if (commentText.trim() !== "") {
    const post = posts.find((p) => p.id === postId);
    post.comments.push({ id: Date.now(), text: commentText });
    commentInput.value = "";
    displayPosts();
  }
}

function likePost(postId) {
  const post = posts.find((p) => p.id === postId);
  post.likes += 1;
  displayPosts();
}

function displayPosts() {
  const postsContainer = document.getElementById("postsContainer");
  postsContainer.innerHTML = "";
  posts.forEach((post) => {
    const postElement = document.createElement("div");
    postElement.classList.add("post");

    postElement.innerHTML = `
      <p>${post.content}</p>
      <button onclick="likePost(${post.id})">Like (${post.likes})</button>
      <div class="comments">
        <input type="text" id="commentInput-${
          post.id
        }" placeholder="Add a comment"/>
        <button onclick="addComment(${post.id})">Comment</button>
      </div>
      <div class="comment-list">
        ${post.comments
          .map((comment) => `<p class="comment">${comment.text}</p>`)
          .join("")}
      </div>
    `;
    postsContainer.appendChild(postElement);
  });
}



document.getElementById("signupButton").addEventListener("click", function () {
  const username = document.getElementById("username").value.trim();
  const ID = document.getElementById("ID").value.trim();
  const password = document.getElementById("password").value.trim();
  const confirmPassword = document.getElementById("confirmPassword").value.trim();

  
  if (!username || !ID || !password || !confirmPassword) {
    alert("All fields are required.");
    return;
  }

  if (password !== confirmPassword) {
    alert("Passwords do not match!");
    return;
  }

  if (password.length < 6) {
    alert("Password must be at least 6 characters long.");
    return;
  }


  alert("Sign-up successful! Welcome, " + username + "!");

  
  window.location.href = "home.html";
});




document.getElementById("signinForm").addEventListener("submit", function (event) {
  event.preventDefault();

  const username = document.getElementById("signinUsername").value;
  const password = document.getElementById("signinPassword").value;

  
  const validUsername = "admin";
  const validPassword = "12345";

  if (username === validUsername && password === validPassword) {
    alert("Sign-In Successful!");
    
    window.location.href = "home.html";
  } else {
    
    const errorBox = document.getElementById("errorBox");
    errorBox.style.display = "block";
    errorBox.textContent = "Invalid username or password. Please try again.";
  }
});



  function confirmSignOut() {
    const confirmation = confirm("Are you sure you want to sign out?");
    if (confirmation) {
      window.location.href = 'index.html';
    }
  }
