namespace NutritionFitnessJeremiah.Data
{
    public class Rootobject
    {
        public bool success { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public object previousPage { get; set; }
        public string nextPage { get; set; }
        public int totalPages { get; set; }
        public int totalExercises { get; set; }
        public int currentPage { get; set; }
        public Exercise[] exercises { get; set; }
    }

    public class Exercise
    {
        public string exerciseId { get; set; }
        public string name { get; set; }
        public string gifUrl { get; set; }
        public string[] instructions { get; set; }
        public string[] targetMuscles { get; set; }
        public string[] bodyParts { get; set; }
        public string[] equipments { get; set; }
        public string[] secondaryMuscles { get; set; }
    }

}
