<!--
Features to add:
  TODO 01: Show the average rating and the frequency of each rating in the "well-display" above the reviews.
    Average Rating:
      Make a coputed property for the average rating- Script
      One-way data bind the div class=well - template
    N-star review counts:
      Make a coputed property for nStarReviews that return an array of counts
      Bind or "count wells" to the proper index of the computed property

  TODO 02: Allow the user to click on a Well to display only those reviews with a particular rating
    Make a filter property that says waht star rating reviews we want to see. filter=0 means see all reviews
    Make a computed  filteredReviews property wich applies the filter
    Add click event on the wells, and change the filter accordingly 
    Change the display loop for reviews to use filteredReviews

  TODO 03: Give a visual indication of which filter is being applied
    Create a CSS class selector which applies some formatiing to the selected filter
    Apply the "selected" css class to the well which matches the filter value

  TODO 04: Provide a form to allow the user to add a new review
    Create newReview variable to store the values for the new review fields as the user enters
    Create the Add Review formform
    Handle the submit / click event on teh form to add the new review to t he collection

  TODO 05: Show and hide the AddReview form as appropriate
    Hide the form by default
    Create a button/link to show the form (Add Review)
    Close the form and reset its values if the new review is added
    Close the form and reset its values if the user presses Cancel
-->
<template>
  <div class="main">
    <h2>Product Reviews for {{ name }}</h2>
    <p class="description">{{ description }}</p>

    <!-- TODO 01B: The "well displays" for holding the number of reviews has been added below.
            Add the appropriate data bindings to the Displays. -->

    <!-- TODO 02D: Set the filter when the user clicks on the display -->

    <!-- TODO 03B: Mark which rating is selected -->

    <div class="well-display">
      <div
        class="well"
        v-on:click="filter = 0"
        v-bind:class="{ 'selected-well': filter === 0 }"
      >
        <span class="amount">{{ averageRating }}</span>
        Average Rating
      </div>

      <div
        v-for="i in 5"
        v-bind:key="i"
        v-on:click="filter = i"
        v-bind:class="{ well: true, 'selected-well': filter === i }"
      >
        <span class="amount">{{ nStarReviews[i - 1] }}</span>
        {{ i }} Star Review
      </div>
    </div>

    <!-- TODO 05C: Add a link to show or hide the form -->
    <a href="#" v-on:click.prevent="showForm = true" v-show="!showForm"
      >Add Review</a
    >
    <!-- TODO 04B: Create the form that allows the user to add a new review -->
    <form v-on:submit.prevent="addNewReview" v-show="showForm">
      <!-- Form has: reviewer, title, rating, and review. Object also has: id, favorite-->
      <div>
        <label for="reviewer"> Reviewer: </label>
        <input id="reviewer" type="text" v-model="newReview.reviewer" />
      </div>
      <div>
        <label for="reviewer"> Title: </label>
        <input id="title" type="text" v-model="newReview.title" />
      </div>
      <div>
        <label for="rating"> Rating: </label>
        <input
          id="rating"
          type="number"
          min="1"
          max="5"
          v-model.number="newReview.rating"
        />
      </div>
      <div>
        <label for="review"> Review: </label>
        <textarea id="review" type="text" v-model="newReview.review" />
      </div>
      <!-- <input type="submit" value="Save"/> -->
      <button v-on:click.prevent="resetForm">Cancel</button>
      <button type="submit">Save</button>
    </form>

    <!-- TODO 05B: Only show the form of the showForm variable is set -->

    <!-- TODO 02C: Display the filteredReviews array instead of the raw data -->

    <!-- Display each review in a loop -->
    <div
      class="review"
      v-for="review in filteredReviews"
      v-bind:key="review.id"
      v-bind:class="{ fav: review.favorite, someOtherClass: review.rating > 3 }"
    >
      <h4>{{ review.reviewer }}</h4>
      <div class="rating">
        <img
          src="../assets/star.png"
          class="ratingStar"
          v-for="n in review.rating"
          v-bind:key="n"
        />
      </div>
      <h3>{{ review.title }}</h3>
      <p>{{ review.review }}</p>

      <!-- Add the checkbox for Favorite? -->
      <div>
        Favorite?
        <input type="checkbox" v-model="review.favorite" />
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "product-review",
  // data() is a function that returns an object full of properties
  data() {
    return {
      name: "Cigar Parties for Dummies",
      description:
        "Host and plan the perfect cigar party for all your squirelly friends",

      // TODO 02A: Create a variable to hold the current ratings Filter value
      filter: 0,
      // TODO 04A: Create a new, empty review object for adding new reviews.
      newReview: {},
      // TODO 05A: Create a variable to store whether the Add Review form should be visible
      showForm: false,

      // Reviews data
      reviews: [
        {
          id: 1,
          reviewer: "Malcolm Gladwell",
          title: "What a book!",
          review:
            "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language.",
          rating: 3,
          favorite: false,
        },
        {
          id: 2,
          reviewer: "Craig Castelaz",
          title: "Better than a swift kick in the butt!",
          review: "My bar is low.",
          rating: 4,
          favorite: false,
        },
        {
          id: 3,
          reviewer: "Ed",
          title: "Better than Cats",
          review: "I loved it.  It was great.  It was better than CAts.",
          rating: 2,
          favorite: false,
        },
        {
          id: 4,
          reviewer: "Lace",
          title: "It's no FizzBuzz",
          review:
            "Not the most constructive how-to. I think the author may be nuts.",
          rating: 2,
          favorite: false,
        },
        {
          id: 5,
          reviewer: "Joe",
          title: "Pick up the pace",
          review: "Like War and Peace, but much slower.",
          rating: 5,
          favorite: false,
        },
        {
          id: 6,
          reviewer: "Max",
          title: "Dummy",
          review: "The writer needs to read a 'writing for dummies' book.",
          rating: 1,
          favorite: false,
        },
      ],
    };
  },

  // TODO 01A: Create Computed properties for averageRating and number of star ratings
  computed: {
    averageRating() {
      // Calculate the average rating of all the reviews (add ratings of all reviews then divide by the count)
      if (this.reviews.length === 0) {
        return 0;
      }
      let sum = this.reviews.reduce((accum, review) => {
        return accum + review.rating;
      }, 0);
      return (sum / this.reviews.length).toFixed(2);
    },
    nStarReviews() {
      let result = [0, 0, 0, 0, 0];
      this.reviews.forEach((review) => {
        result[review.rating - 1]++;
      });
      return result;
    },

    // TODO 02B: Add a computed property filteredReviews to return the reviews to be displayed
    filteredReviews() {
      return this.reviews.filter((rev) => {
        return this.filter === 0 || this.filter === rev.rating;
      });
    },
  },

  // TODO 04C: Create methods to add the new review or cancel the add
  methods: {
    addNewReview() {
      // alert("submit it now!");
      //Add
      this.newReview.id = this.reviews.length + 1;
      this.newReview.favorite = false;

      // Add the new review to the array of reviews (data)
      this.reviews.unshift(this.newReview);

      // Clear the new review
      this.resetForm();
    },
    resetForm() {
      // Clear the new review
      this.newReview = {};
      this.showForm = false;
    },
  },
};
</script>

<style scoped>
div.main {
  margin: 1rem 0;
}

div.main div.well-display {
  display: flex;
  justify-content: space-around;
}

div.main div.well-display div.well {
  display: inline-block;
  width: 15%;
  border: 1px black solid;
  border-radius: 6px;
  text-align: center;
  margin: 0.25rem;
  cursor: pointer;
}

div.main div.well-display div.well span.amount {
  color: darkslategray;
  display: block;
  font-size: 2.5rem;
}

div.main div.review {
  border: 1px black solid;
  border-radius: 6px;
  padding: 1rem;
  margin: 10px;
}

div.main div.review div.rating {
  height: 2rem;
  display: inline-block;
  vertical-align: top;
  margin: 0 0.5rem;
}

div.main div.review div.rating img {
  height: 100%;
}

div.main div.review p {
  margin: 20px;
}

div.main div.review h3 {
  display: inline-block;
}

div.main div.review h4 {
  font-size: 1rem;
}

input[type="text"] {
  padding: 5px 10px;
  margin: 5px 10px;
  background-color: beige;
  border: 1px solid lightblue;
  border-radius: 5px;
  box-shadow: 2px 2px 2px 2px lightblue;
  width: 300px;
}

div.review.fav {
  background-color: lightyellow;
}

/* TODO 05A: Add a style to Mark which rating is selected */
/* Use these or any rule you want */
.selected-well {
  border-color: blue;
  box-shadow: 0px 0px 5px 5px lightblue;
}
div.main div.well-display div.well:hover {
  box-shadow: 0px 0px 5px 5px lightgray;
}
</style>