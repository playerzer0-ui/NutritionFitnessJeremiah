namespace NutritionFitnessJeremiah.Data
{

    public class RootobjectList
    {
        public Result[] results { get; set; }
        public int offset { get; set; }
        public int number { get; set; }
        public int totalResults { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
        public Nutrition nutrition { get; set; }
    }

    public class Nutrition
    {
        public Nutrient[] nutrients { get; set; }
    }

    public class Nutrient
    {
        public string name { get; set; }
        public float amount { get; set; }
        public string unit { get; set; }
    }

}
