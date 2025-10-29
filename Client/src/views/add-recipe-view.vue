<template>
  <div>
    <h1>Add a New Recipe</h1>
    <h2>Name:</h2>
    <input type="text" v-model="recipe.name" />


    <h2>Ingredients:</h2>
    <li v-for="ingredient in recipe.ingredients" :key="ingredient.fdcId">
      {{ ingredient.name }} - {{ ingredient.weight }}g
      <button @click="deleteIngredient(ingredient)">X</button>
    </li>

<div>

      <div v-if=!addingIngredient>
          <button @click="addingIngredient = true">Add ingredient</button>
      </div>

      <div v-else>
        <IngredientSelector v-model="ingredient" />

        <span>{{ ingredient.name?.trim() ? ingredient.name : 'Ingredient not selected ' }}</span>
        <input type="number" placeholder="Weight (g)"  v-model="ingredient.weight"/>

        <button @click="addIngredient">Add</button>
        <button @click="addingIngredient = false">Cancel</button>
      </div>

    </div>

    <h2>Description</h2>
    <input type="text" v-model="recipe.description" />
    <hr>
    <button @click="addRecipe">Add Recipe</button>
  </div>
</template>

<script setup>
import axios from 'axios'
import { reactive, ref } from 'vue'
import IngredientSelector from '../components/search-select-ingredient-component.vue';

const addingIngredient = ref(false);


const recipe = reactive({
  name: '',
  description: '',
  ingredients: []
})

const ingredient = reactive({
  name: '',
  weight: 0,
  fdcId: null,
  proteinPer100: null,
  caloriePer100: null,
  comment: ''
})

function deleteIngredient(ingredient) {
  const index = recipe.ingredients.indexOf(ingredient);
  recipe.ingredients.splice(index, 1);
}

function addIngredient() {
  recipe.ingredients.push({ ...ingredient });
  ingredient.name = '';
  ingredient.weight = 0;
  ingredient.fdcId = null;
  ingredient.proteinPer100 = '';
  ingredient.caloriePer100 = '';
  ingredient.comment = '';
  addingIngredient.value = false;
}

function addRecipe() {
  axios
    .post('https://localhost:7257/api/recipes', recipe)
    .then((response) => {
      console.log('Recipe added:', response.data)
    })
    .catch((error) => {
      0
      console.error('Error adding recipe:', error)
    })
}
</script>
