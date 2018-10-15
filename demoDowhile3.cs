using System;
class demoDowhile3
{
	static void Main()
	{
		const string USERNAME = "telkom";
		const string PASSWORD = "bandung";

		string username, password;

		do
		{
			Console.WriteLine ("Masukkan username dan password");
			Console.Write("Username:  ");
			username= Console.ReadLine();
			Console.Write("Password: ");
			password=Console.ReadLine();
			Console.WriteLine();
		} while (username != USERNAME || password != PASSWORD);
		Console.WriteLine("Selamat Datang....");
	}
}