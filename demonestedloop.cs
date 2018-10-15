using System;
class demonestedloop {
	static void Main() {
		//pengulangan bagian luar
		for(int i=1; i<=10; i++) {
			//pengulangan bagian dalam
				for (int j=1; j<=i; j++) {
					Console.Write(i*j + " ");
				}
				Console.WriteLine(); //baris baru
		}
	}
}