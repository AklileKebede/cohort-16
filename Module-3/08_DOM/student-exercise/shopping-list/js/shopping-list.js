// add pageTitle
const pageTitle = 'My Shopping List';

// add groceries
const groceries = ['SoFresh Produce', 'Baking Goods', 'Condiments', 'Grains', 'Freezer Items', 'Bread', 'Protein', 'Dairy', 'Dried Goods', 'Snacks'];


/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
 function setPageTitle() {
  // Reference DOM location
  let titlePlace = document.getElementById('title');
  // Set property
   titlePlace.innerText = pageTitle;
   
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.getElementById('groceries');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item;
    ul.appendChild(li);    
  });
  // document.getElementById('shopping-list').appendChild(ul);
}
 
/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  const lis = document.getElementById('groceries').getElementsByTagName('li');
  for (let i = 0; i < lis.length; i++) {
    lis[i].classList.add('completed');
  };
}

setPageTitle();

displayGroceries();


// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
