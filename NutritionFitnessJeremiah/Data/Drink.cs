namespace NutritionFitnessJeremiah.Data
{
    public abstract class Drink
    {
        public abstract string Name { get; }
        public abstract int Amount { get; set; }
        public abstract void Add(int amount);
    }

}
