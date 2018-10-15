using System;
class demowhile2
{
	static void Main()
	{
		int n, i, faktorial=1;
		string s;

		Console.Write("Masukkan bilangan bulat:  ");
		s=Console.ReadLine();
		n=int.Parse(s);

		Console.Write(n + "!=");

		if (n > 1)
		{
			i=n;
			while (i >= 1)
			{
				if (i != 1)
				{
					Console.Write (i + " x ");
				} else {
					Console.Write (i + " = ");
				}
				faktorial = faktorial * i;
				i--;
			}
		}
		Console.WriteLine (faktorial);

	}
}