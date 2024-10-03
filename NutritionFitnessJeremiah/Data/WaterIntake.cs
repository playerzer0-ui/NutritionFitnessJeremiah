namespace NutritionFitnessJeremiah.Data
{
    public enum DrinkType
    {
        Water,
        Juice,
        Soda
    }

    public class WaterIntake : Drink
    {
        public override string Name => "Water";
        public override int Amount { get; set; }

        public override void Add(int amount)
        {
            Amount += amount;
        }
    }

    public class WaterTracker : ITrackable
    {
        public Dictionary<string, WaterIntake> WaterData { get; set; } = new Dictionary<string, WaterIntake>();

        public void Track(int amount){}

        public void DisplayInfo()
        {
            foreach (var entry in WaterData)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value.Amount} glasses of {entry.Value.Name}");
            }
        }
    }

}
