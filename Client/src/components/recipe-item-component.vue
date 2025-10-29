<template>
  <article class="recipe-card">
    <h4 class="title">{{ recipe.name }}</h4>
    <p v-if="recipe.description" class="desc">{{ recipe.description }}</p>
  </article>
</template>

<script setup>
const { recipe } = defineProps({
  recipe: { type: Object, required: true }
})
</script>

<style scoped>
.recipe-card {
  background: #fff;
  border: 1px solid #e5e7eb;
  border-radius: 12px;
  padding: 12px;
  box-shadow: 0 1px 2px rgba(0,0,0,0.05);
}
.title { margin: 0 0 6px; font-size: 1rem; }
.desc  { margin: 0; color: #6b7280; font-size: 0.9rem; }
</style>
