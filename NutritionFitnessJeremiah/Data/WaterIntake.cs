namespace NutritionFitnessJeremiah.Data
{
    public class WaterIntake
    {
        public int Amount { get; set; }
    }

    public class WaterTracker
    {
        public Dictionary<string, WaterIntake> WaterData { get; set; } = new Dictionary<string, WaterIntake>();
    }
}
