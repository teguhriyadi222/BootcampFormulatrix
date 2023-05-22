class Cat {
	public Leg totalLeg;
	public void SetLeg(Leg x) 
	{
		totalLeg = x;
	}
	public int GetTotalLeg() 
	{
		return totalLeg.LegSize;
        
	}
}
class Leg
{

	public int LegSize = 5;
	public Nail totalNail;
	public Leg(Nail x) 
	{
		totalNail = x;
		LegSize = 4;
	}
}
class Nail 
{
	public int NailLength;
	public Nail() 
	{
		NailLength = 4;
	}
}
class Program 
{
	static void Main() 
	{
		Cat cotton = new Cat();
        Nail catNail = new Nail();
        Leg catLeg = new Leg(catNail);
		cotton.SetLeg(catLeg);
		Console.WriteLine(cotton.GetTotalLeg);
		Console.WriteLine(cotton.totalLeg.totalNail.NailLength);
	}
}