<template>
  <div>
    <div>
      <input type="text" v-model="searchQuery" placeholder="Search for an ingredient..." />
      <button @click="Search">Search</button>

    </div>

    <ul>
      <li v-for="item in items" :key="item.fdcId" @click="selectIngredient(item)" >{{ item.description }}
        <ul>
          <li v-for="nutrient in item.foodNutrients" :key="nutrient.number">
            {{ nutrient.nutrientName }}: {{ nutrient.value }} {{ nutrient.unitName }}. Nutrient number: {{ nutrient.nutrientNumber }}

          </li>
        </ul>
      </li>
    </ul>


  </div>
</template>

<script setup>
import { ref } from 'vue'
import axios from 'axios'

const ingredient = defineModel()

const searchQuery = ref('');
const items = ref([]);

function Search() {
  axios.post('https://api.nal.usda.gov/fdc/v1/foods/search?api_key=C3PDus2HmruFq15bYIFTEvoDa4EYI4wTemwwvOd1', {
    query: searchQuery.value,
    dataType: ['Foundation'],
    pageSize: 5,
    pageNumber: 1,

  }).then(response => {
    items.value = response.data.foods;
  });
}


function selectIngredient(item) {
  ingredient.value.fdcId = item.fdcId;
  ingredient.value.name = item.description;
  ingredient.value.proteinPer100 = item.foodNutrients.find(n => n.nutrientNumber == 203)?.value || 0;
  ingredient.value.caloriePer100 = item.foodNutrients.find(n => n.nutrientNumber == 208)?.value || item.foodNutrients.find(n => n.nutrientNumber == 957)?.value;
}

</script>
