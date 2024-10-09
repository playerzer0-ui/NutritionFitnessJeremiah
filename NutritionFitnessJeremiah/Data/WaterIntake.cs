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
    }

    public class JuiceIntake : Drink
    {
        public override string Name => "Juice";
        public override int Amount { get; set; }
    }

    public class SodaIntake : Drink
    {
        public override string Name => "Soda";
        public override int Amount { get; set; }
    }

    public class DrinkIntake
    {
        public int Water { get; set; } = 0;
        public int Juice { get; set; } = 0;
        public int Soda { get; set; } = 0;
    }

    public class WaterTracker : ITrackable
    {
        public Dictionary<string, DrinkIntake> WaterData { get; set; } = new Dictionary<string, DrinkIntake>();

        public void DisplayInfo()
        {
            foreach (var entry in WaterData)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value.Water} glasses of Water, {entry.Value.Juice} glasses of Juice, {entry.Value.Soda} glasses of Soda");
            }
        }
    }
}
