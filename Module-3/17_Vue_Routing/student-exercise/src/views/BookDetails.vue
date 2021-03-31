<template>
  <div>
    <!-- TODO: Add router-links to products and about pages. -->
    <h1>{{ book.title }}</h1>
    <h2>{{ book.author }}</h2>
    <img
      v-if="book.isbn"
      v-bind:src="
        'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'
      "
    />
    
  </div>
</template>

<script>
export default {
  data() {
    return {
      isbn: 0,
    };
  },
  computed: {
    book() {
      return this.$store.state.books.find((b) => {
        return b.isbn === this.isbn;
      });
    },
  },
  created() {
    this.isbn = this.$route.params.isbn;
  },
};
</script>

<style scoped>
</style>