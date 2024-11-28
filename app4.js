
function addPost() {
    const postContent = document.getElementById("postContent").value;
    const postsContainer = document.getElementById("postsContainer");
  
    
    if (postContent.trim() === "") {
      alert("Post content cannot be empty!");
      return;
    }
  
    
    const postDiv = document.createElement("div");
    postDiv.className = "post";
  
    
    const postParagraph = document.createElement("p");
    postParagraph.textContent = postContent;
  
    
    const likeButton = document.createElement("button");
    likeButton.textContent = "Like";
    likeButton.className = "like-button";
    likeButton.onclick = function() {
      likePost(postDiv);
    };
  
    
    const commentsContainer = document.createElement("div");
    commentsContainer.className = "comments-container";
  
    
    const commentInput = document.createElement("textarea");
    commentInput.placeholder = "Add a comment...";
    commentInput.rows = 2;
  
   
    const commentButton = document.createElement("button");
    commentButton.textContent = "Comment";
    commentButton.onclick = function() {
      addComment(commentsContainer, commentInput.value);
      commentInput.value = ""; 
    };
  
 
    postDiv.appendChild(postParagraph);
    postDiv.appendChild(likeButton);
    postDiv.appendChild(commentInput);
    postDiv.appendChild(commentButton);
    postDiv.appendChild(commentsContainer);
  
   
    postsContainer.appendChild(postDiv);
  
    
    document.getElementById("postContent").value = "";
  }
  
  
  function likePost(postDiv) {
    if (postDiv.classList.contains("liked")) {
      alert("You already liked this post!");
    } else {
      postDiv.classList.add("liked");
      alert("You liked the post!");
    }
  }
  
  
  function addComment(commentsContainer, comment) {
    if (comment.trim() === "") {
      alert("Comment cannot be empty!");
      return;
    }
  
  
    const commentParagraph = document.createElement("p");
    commentParagraph.textContent = comment;
  
    
    commentsContainer.appendChild(commentParagraph);
  }