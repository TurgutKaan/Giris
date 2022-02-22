// String tipi aslında bir char dizisidir. Birden fazla karakterden oluşur. Dizi gibi metotları vardır, elemanlarına index bazlı erişilebilir.
// String bir dizi gibi düşünülebilir ama özel bir tiptir

string[] names = { "kaan", "kartal" };
string name1 = names[0]; // kaan
string name2 = names[1]; // kartal

char c = 'k';
string name = "kaan";

Console.WriteLine(name.Length); // name değişkeninin uzunluğu (4)

//char f = name; // tipler eşit değil tek char'a birden fazla char atanamaz
//char l = name; // tipler eşit değil tek char'a birden fazla char atanamaz

char f = name[0];
char l = name[1];
Console.WriteLine(f);
Console.WriteLine(l);

for(int i = 0; i < name.Length; i++)
    Console.WriteLine(name[i]);
Console.WriteLine("----------------");
for(int j =name.Length; j >0 ;j--)
    Console.WriteLine(name[j-1]);

string ogrenci = "Turgut";
//ogrenci[0] = 'k' string'inne index bazlı atama yapılamaz. çünkü read only'dir.
Console.WriteLine(ogrenci.ToUpper());
Console.WriteLine(ogrenci.ToLower());

Console.WriteLine("Lütfen adınızı yazınız");
string ad = Console.ReadLine();

char[] ads = new char[0]; // 0 elemanlı bir karakter dizisi
for(int i =0; i < ad.Length; i++)
{
    Array.Resize(ref ads, ads.Length+1); // dizinin uzunluğunu 1 arttırır
    ads[i] = ad[i]; 
}

for(int i = ads.Length; i>0; i--)
    Console.WriteLine(ads[i-1]);

Console.WriteLine("-------------");

Console.WriteLine("Lütfen adınızı yazınız");
string ad1 = Console.ReadLine();
char[] ch = ad1.ToCharArray(); // ToCharArray => string'i char dizisine çevirir.
Array.Reverse(ch); // terse çevir.
ad1=new string(ch); // char dizisinden yeni bir string oluşturur.
Console.WriteLine(ad1);
