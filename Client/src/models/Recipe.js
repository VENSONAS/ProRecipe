export class Recipe {
  constructor(id, name, description, ingredients = []) {
    this.id = id
    this.name = name
    this.description = description
    this.ingredients = ingredients
  }
}

export class Ingredient {
  constructor(id, recipeId, name, comment, weight, proteinPer100, caloriePer100, fdcId) {
    this.id = id
    this.recipeId = recipeId
    this.name = name
    this.comment = comment ?? ""
    this.weight = Number(weight)
    this.proteinPer100 = proteinPer100
    this.caloriesPer100 = caloriePer100
    this.fdcId = fdcId
  }
}
