namespace FactoryMethod
{
    public interface ICoffeeFactory
    {
        Coffee Create();
    }


    public class CoffeeParameters
    {
        public IngredientType IngredientType;
        public double Count { get; set; }
        public int Order { get; set; }
    }

    public enum IngredientType
    {
        MilkFoam,
        SteamedMilk,
        Chocolate,
        Espresso,
        Water
    }

    public class CappucinoFactory : ICoffeeFactory
    {
        public Coffee Create()
        {
            return new Cappucino();
        }
    }

    public class MochaFactory : ICoffeeFactory
    {
        public Coffee Create()
        {
            return new Mocha();
        }
    }

    public class LatteFactory : ICoffeeFactory
    {
        public Coffee Create()
        {
            return new Latte();
        }
    }
    public class AmericanoFactory : ICoffeeFactory
    {
        public Coffee Create()
        {
            return new Americano();
        }
    }
    public abstract class Coffee
    {
        protected IList<CoffeeParameters> Params { get; init; }
        protected abstract void Prepare();
        
        public Coffee()
        {
            Params = new List<CoffeeParameters>();
            Prepare();
        }
    }

    public class Cappucino : Coffee
    {
        protected override void Prepare()
        {
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 1, Order = 2 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.MilkFoam, Count = 1, Order = 3 });
        }
    }

    public class Mocha : Coffee
    {
        protected override void Prepare()
        {
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Chocolate, Count = 0.4, Order = 2 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 1.6, Order = 3 });
        }
    }

    public class Latte : Coffee
    {
        protected override void Prepare()
        {
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.SteamedMilk, Count = 1.7, Order = 2 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.MilkFoam, Count = 0.3, Order = 3 });
        }
    }

    public class Americano : Coffee
    {
        protected override void Prepare()
        {
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Espresso, Count = 1, Order = 1 });
            Params.Add(new CoffeeParameters { IngredientType = IngredientType.Water, Count = 2, Order = 2 });
        }
    }
}