using FactoryMethod;

public class Program

{
    public static void Main(string[] args)
    {
        ICoffeeFactory cappucinoFactory = new CappucinoFactory();
        var myCappucino = cappucinoFactory.Create();

        ICoffeeFactory mochaFactory = new MochaFactory();
        var myMocha = mochaFactory.Create();

    }
}
