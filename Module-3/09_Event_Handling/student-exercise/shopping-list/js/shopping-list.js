let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}

/*
 * When the DOM is fully loaded into a browser, the browser itself will trigger an event called
 * DOMContentLoaded on the document object. What you need to do is add all of your event listeners inside
 * of an anonymous function that only runs once the DOMContentLoaded event is fired.
 */
document.addEventListener('DOMContentLoaded', () => {
  setPageTitle();
  displayGroceries();
  
  let groceryItems = document.querySelectorAll('li');

  /*Go over the list of items adn mark it complete if event lister click correct*/
  groceryItems.forEach((groceryItem) => {
    groceryItem.addEventListener('click', () => {
      if (!groceryItem.classList.contains('completed')) {
        groceryItem.classList.add('completed');
        groceryItem.querySelector('i').classList.add('completed');
      }
    });

    groceryItem.addEventListener('dblclick', () => {
      if (groceryItem.classList.contains('completed')) {
        groceryItem.classList.remove('completed');
        groceryItem.querySelector('i').classList.remove('completed');
      }
    });
  });

  let completeButton = document.getElementById('toggleAll');
  let allItemsIncomplete = true;

  completeButton.addEventListener('click', () => {
    if (allItemsIncomplete) {
      groceryItems.forEach(groceryItem => {
        groceryItem.classList.add('completed');
        groceryItem.querySelector('i').classList.add('completed');
      });
      completeButton.innerText = "Mark All Incomplete";
      allItemsIncomplete = false;
    }
    else {
      groceryItems.forEach((groceryItem) => {
        groceryItem.classList.remove('completed');
        groceryItem.querySelector('i').classList.remove('completed');
      });
      completeButton.innerText = "Mark All Complete";
      allItemsIncomplete = true;
    }
    
    });
});
