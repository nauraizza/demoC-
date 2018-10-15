using System;
class demowhile1
{
	static void Main()
	{
		int n, i, faktorial=1;
		string s;

		Console.Write("Masukkan bilangan bulat:  ");
		s= Console.ReadLine();
		n= int.Parse (s);

		if (n>1)
		{
			i=n;
			while (i >=1)
			{
				faktorial= faktorial * i;
				i--;
			}
		}
		Console.WriteLine (n+ "!=" +faktorial);
	}
}