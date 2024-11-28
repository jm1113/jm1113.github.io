
const professionalCards = document.querySelectorAll('.professional-card');


professionalCards.forEach((card) => {
  card.addEventListener('click', () => {
   
    card.classList.toggle('active');
  });
});


const filterInput = document.getElementById('filter-input');
filterInput.addEventListener('input', () => {
  const filterValue = filterInput.value.toLowerCase();
  professionalCards.forEach((card) => {
    const specialty = card.querySelector('p strong:contains("Specialty:")').nextSibling.textContent.toLowerCase();
    if (specialty.includes(filterValue)) {
      card.style.display = 'block';
    } else {
      card.style.display = 'none';
    }
  });
});


const contactButtons = document.querySelectorAll('.contact-button');
contactButtons.forEach((button) => {
  button.addEventListener('click', () => {
    const professionalCard = button.closest('.professional-card');
    const contactInfo = professionalCard.querySelector('p strong:contains("Contact:")').nextSibling.textContent;
    const emailRegex = /\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}\b/g;
    const phoneRegex = /\b\d{3}[-.]?\d{3}[-.]?\d{4}\b/g;
    if (emailRegex.test(contactInfo)) {
      
      window.location.href = `mailto:${contactInfo}`;
    } else if (phoneRegex.test(contactInfo)) {
      
      window.location.href = `tel:${contactInfo}`;
    }
  });
});