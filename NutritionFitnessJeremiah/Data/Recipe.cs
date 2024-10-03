﻿namespace NutritionFitnessJeremiah.Data
{

    public class RootobjectRecipe
    {
        public bool vegetarian { get; set; }
        public bool vegan { get; set; }
        public bool glutenFree { get; set; }
        public bool dairyFree { get; set; }
        public bool veryHealthy { get; set; }
        public bool cheap { get; set; }
        public bool veryPopular { get; set; }
        public bool sustainable { get; set; }
        public bool lowFodmap { get; set; }
        public int weightWatcherSmartPoints { get; set; }
        public string gaps { get; set; }
        public int? preparationMinutes { get; set; }
        public int? cookingMinutes { get; set; }
        public int aggregateLikes { get; set; }
        public int healthScore { get; set; }
        public string creditsText { get; set; }
        public string license { get; set; }
        public string sourceName { get; set; }
        public float pricePerServing { get; set; }
        public Extendedingredient[] extendedIngredients { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public int readyInMinutes { get; set; }
        public int servings { get; set; }
        public string sourceUrl { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
        public string summary { get; set; }
        public object[] cuisines { get; set; }
        public string[] dishTypes { get; set; }
        public object[] diets { get; set; }
        public object[] occasions { get; set; }
        public string instructions { get; set; }
        public object[] analyzedInstructions { get; set; }
        public object originalId { get; set; }
        public float spoonacularScore { get; set; }
        public string spoonacularSourceUrl { get; set; }
    }

    public class Extendedingredient
    {
        public int id { get; set; }
        public string aisle { get; set; }
        public string image { get; set; }
        public string consistency { get; set; }
        public string name { get; set; }
        public string nameClean { get; set; }
        public string original { get; set; }
        public string originalName { get; set; }
        public float amount { get; set; }
        public string unit { get; set; }
        public string[] meta { get; set; }
        public Measures measures { get; set; }
    }

    public class Measures
    {
        public Us us { get; set; }
        public Metric metric { get; set; }
    }

    public class Us
    {
        public float amount { get; set; }
        public string unitShort { get; set; }
        public string unitLong { get; set; }
    }

    public class Metric
    {
        public float amount { get; set; }
        public string unitShort { get; set; }
        public string unitLong { get; set; }
    }

}
