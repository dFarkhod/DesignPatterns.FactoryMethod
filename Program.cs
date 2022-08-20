using FactoryMethod;

public class Program

{
    public static void Main(string[] args)
    {
        // 1-misol, to'g'ridan to'g'ri kerakli factory'ni ishlatish:
        ICoffeeFactory cappucinoFactory = new CappucinoFactory();
        var myCappucino = cappucinoFactory.Create();

        ICoffeeFactory mochaFactory = new MochaFactory();
        var myMocha = mochaFactory.Create();



        // 2-misol, factory'larni container'da ro'yxatga olib ishlatish:
        var factoryContainer = new CoffeeFactoryContainer();

        factoryContainer.Register("cappucino", new CappucinoFactory());
        factoryContainer.Register("mocha", new MochaFactory());
        factoryContainer.Register("americano", new AmericanoFactory());

        var myCappucino2 = factoryContainer.GetFactory("cappucino")?.Create();
    }
}
