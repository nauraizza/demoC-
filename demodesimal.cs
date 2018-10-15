using System;
class demodesimal
{
	static void Main()
	{
		//deklarasi variabel
		decimal harga;
		decimal diskon;
		decimal harga_diskon;
		decimal potongan;

		harga = 1000000.00m;
		diskon = 0.25m; //diskon 25%

		harga_diskon =  harga- (harga * diskon);
		potongan= harga-harga_diskon;

		Console.WriteLine("Harga Nornal \t: " +harga);
		Console.WriteLine("Potongan Harga \t: " +potongan);
		Console.WriteLine("Harga Diskon (25%) \t:" +harga_diskon);

		Console.ReadLine();

	}
}