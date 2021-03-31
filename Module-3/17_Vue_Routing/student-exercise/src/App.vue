<template>
  <div id="app">
    <nav>
      <!-- TODO: Add router-links to products and about pages. -->
      <router-link :to="{name:'Home'}">Home</router-link> |
      <router-link :to="{name:'myBooks'}">MyBooks</router-link>
    </nav>
    <router-view />
  </div>
</template>

<script>

export default {
  name: 'app'
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin: 60px;
}
</style>
