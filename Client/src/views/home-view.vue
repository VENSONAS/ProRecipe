 <template>
  <div class="home">
    <h1>Welcome to ProRecipe!</h1>
    <p>Your ultimate recipe management app.</p>
  </div>
  <hr>
  <RecipeList />
</template>


<script setup>

import RecipeList from '../components/recipe-list-component.vue';

</script>

<style scoped>
.page {
  display: flex;
  flex-direction: column;
  gap: 1rem;
}
</style>
