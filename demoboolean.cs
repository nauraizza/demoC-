using System;
class demoboolean
{
	static void Main()
	{
		bool a;
		bool b;

		a = true;
		b = false;

		Console.WriteLine("Nilai a: " + a);
		Console.WriteLine("Nilai b: " + b);

		a = 100 > 10;
		b = 100 < 10;

		Console.WriteLine("100 > 10: " +a);
		Console.WriteLine("100 < 10: " +b);
	}
}