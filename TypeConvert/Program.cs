/*
 Convert = Farklı tiplerin birbirine dönüşümüdür.
 Veri formatı uygun formatta olmalıdır.
 */


//string s = "10";
//byte say1 = Convert.ToByte(s); // byte'a çevirir.
//int say2 = Convert.ToInt32(s); //  inte çevirir.

//Console.WriteLine(say1 + say2);
//Console.WriteLine(5*say1);
//Console.WriteLine(40+say2);

// TİP ADI      DÖNÜŞÜM METODU
// short        Convert.ToInt16
// int          Conver.ToInt32
// long         Convert.ToInt64
// float        Convert.ToSingle
// bool         Convert.ToBoolean
// byte         Convert.ToByte
// string       Convert.ToString

//int a = 500;
//byte b = Convert.ToByte(a);
//Console.WriteLine(b); // a değerini byte'a dönüştürür runtime hatası verir. Çünkü a'nın değeri byte için büyüktür.

//byte bt = Convert.ToByte("random");
//Console.WriteLine(bt);  // random değerini byte'a dönüştürürke runtime hatası alırız, çünkü random değeri format olarak sayı değildir.

int d = Convert.ToInt32("352");
Console.WriteLine(d);

bool durum = Convert.ToBoolean("true");
Console.WriteLine(durum);