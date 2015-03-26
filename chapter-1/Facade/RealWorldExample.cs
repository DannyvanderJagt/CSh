public class CoffeeMachine
{
    CoffeeBeanTank _beanTank;
    WaterTank _waterTank;
    CoffeeDisposal _disposal;
    CoffeeGrinder _grinder;
    CoffeeMaker _coffeeMaker;

    public CoffeeMachine()
    {
        _beanTank = new CoffeeBeanTank();
        _waterTank = new WaterTank();
        _disposal = new CoffeeDisposal();
        _grinder = new CoffeeGrinder();
    }

    public Coffee MakeCoffee()
    {
        var beans = _beanTank.GetBeans();
        var powder = _grinder.Grind(beans);
        var water = _waterTank.TapWater();

        var cupOfCoffee = _coffeeMaker.Make(powder, water);

        return cupOfCoffee;
    }
}