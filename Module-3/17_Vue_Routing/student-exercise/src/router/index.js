import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '@/views/Home.vue';
import MyBooks from '@/views/MyBooks.vue';
import AddBook from '@/views/NewBook.vue';
import BookDetails from '@/views/BookDetails.vue';

Vue.use(VueRouter);

const routes = [
  {
    path:'/',
    name:'Home',
    component: Home
  },
  {
    path:'/myBooks',
    name:'myBooks',
    component: MyBooks
  },
  {
    path:'/addBook',
    name:'addBook',
    component: AddBook
  },
  {
    path: '/book/:isbn',
    name: 'bookDetails',
    component: BookDetails,
  },

];

const router = new VueRouter({
  mode: 'history',
  routes
});

export default router;
