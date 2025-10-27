<template>
  <div>
    <li v-for="recipe in recipes">
      {{ recipe.name }}
      <li v-for="ingredient in recipe.ingredients">
        - {{ ingredient.name }}: {{ ingredient.weight }}g

      </li>
    </li>
  </div>
</template>

<script setup>
import { ref } from 'vue'

const API_URL = 'https://localhost:7257/api/recipes'
const recipes = ref([])

async function fetchRecipes() {
  try {
    const response = await fetch(API_URL)
    if (!response.ok) {
      throw new Error('Network response was not ok')
    }
    recipes.value = await response.json()
  } catch (error) {
    console.error('Error fetching recipes:', error)
  }
}

fetchRecipes()
</script>
