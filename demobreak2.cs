using System;
class demobreak2
{
	static void Main()
	{
		const string USERNAME="csharp";
		const string PASSWORD="microsoft";

		string username, password;

		for( ; ; )
		{
			Console.WriteLine("Masukkan username dan password");
			Console.Write("Username:   ");
			username= Console.ReadLine();
			Console.Write("Password:  ");
			password= Console.ReadLine();
			Console.WriteLine();
			if (username == USERNAME && password == PASSWORD)
			{
				break;
			}
		}
		Console.WriteLine("Selamat Datang....");
	}
}