static class Program
{
	static void Main()
	{
		Cycle cycle = new Cycle("Polygon");
		Car car = new Car("Subaru");
		Cargo myCargo = new Cargo(car, cycle);

		int maxWeight = myCargo.checkWeight();
		Car myCar = myCargo.checkCar();
		Cycle myCycle = myCargo.checkCycle();

		Console.WriteLine(myCar.GetBrand());
		Console.WriteLine(myCycle.GetBrand());
	}
}
class Cargo 
{
	private Car _cargoCar;
	private Cycle _cargoCycle;
	private int _totalWeight;
	public Cargo(Car cargoCar, Cycle cargoCycle)
	{
		_cargoCar = cargoCar;
		_cargoCycle = cargoCycle;
		_totalWeight = 1000;
	}
	public int checkWeight() 
	{
		return _totalWeight;
	}
	public Car checkCar() 
	{
		return _cargoCar;
	}
	public Cycle checkCycle() 
	{
		return _cargoCycle;
	}
}
class Car
{
	private string _carName;
	public Car(string brand) 
	{
		_carName = brand;
	}
	public string GetBrand() 
	{
		return _carName;
	}
}
class Cycle
{
	private string _cycleName;
	public Cycle(string brand) 
	{
		_cycleName = brand;
	}
	public string GetBrand()
	{
		return _cycleName;
	}
}
