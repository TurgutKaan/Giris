string[] isimler = new string[3];  // 3 adet string

isimler[0] = "Turgut";
isimler[1] = "Kaan";
isimler[2] = "Turan";

//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);

char[] karakterler = new char[4];  // 4 adet char
karakterler[0] = 'K';
karakterler[1] = 'A';
karakterler[2] = 'A';
karakterler[3] = 'N';

bool[] durumlar = new bool[3];  // 3 adet bool
durumlar[0] = true;
durumlar[1] = false;
durumlar[2] = true;

string[] ogrenciler = new string[4];  // 4 adet 
ogrenciler[0] = "Kaan";
ogrenciler[1] = "Turgut";
ogrenciler[2] = "Turan";
ogrenciler[3] = "Hakan";

byte[] bytler = new byte[500]; // 500 adet


/*
 C# dilinde sadece diziler için kullanılabilen bir döngü daha vardır. O da foreach döngüsüdür.
 İsim değişkeni tanımlanır. in ifadesi ile dizinin sıradaki elemanı isim değişkenine atanır ve döngü içinde o değişken kullanılır.
 Dizilerde ileri yönlü okuma yapmak için kullanılır. Sadece dizinin elemanlarına erişmek için kullanılır.
 */

foreach(string isim in isimler)
{
    Console.WriteLine(isim);
}

foreach(char karakter in karakterler)
{
    Console.WriteLine(karakter);
}

foreach(bool d in durumlar)
{
    Console.WriteLine(d);
}

foreach(string ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}

int[] sayilar = new int[5];
sayilar[2] = 3;
sayilar[4] = 5;
sayilar[1] = 2;
sayilar[3] = 4;
sayilar[0] = 1;

foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);   //  0'dan 4'e doğru okumaya devam eder.
}


// dizide ekstra bir işlem yapmadan diziyi foreach döngüsü ile tersten okuyamayız.

// Length => Dizinin uzunluğunu (eleman sayısını) verir.

Console.WriteLine($"Sayılar Dizisinin Uzunluğu {sayilar.Length}");

// for ( int i = 4; i>=0; i--)

for ( int i = sayilar.Length; i>0; i--)
{
    Console.WriteLine(sayilar[i-1]);
}

int l = isimler.Length - 1; // 2
while (l >= 0)
{
    Console.WriteLine(isimler[l--]);
}

int ji = karakterler.Length;
while (ji > 0)
{
    Console.WriteLine(karakterler[ji-1]);
    ji--;
}