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

    public class WaterTracker
    {
        public Dictionary<string, DrinkIntake> WaterData { get; set; } = new Dictionary<string, DrinkIntake>();
    }
}
