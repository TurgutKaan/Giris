// not => değişşken sayıları arttıkça yönetmesi zorlaşır. Bir noktadan sonra zorlaşmaz kitlenirsiniz... (kod sayı artar)
// bu noktda birden fazla değişkenle çalışılacaksa, değişkenlerin bir arada tutulması gerekir...birden fazla değişkeni bir arada tanımlayan yapıya array (dizi) denir..

/*
 Diziler => aynı türden değişkenlerin bir arada tutulduğu yapılardır...
Dizi operatörü [] buna indis veya indexte denir...
Örnek tanım;
    
yazılım dilinde değerler value, değişkenler refarans olarak adlanrılır...
    
    int s; // bir adet değişken demektir...
    int[] ss= new int[n]; // birden fazla değişken demektir...
// s değer tutar
// ss referans tutar...
*/

//int a = 4, b = 5, c = 6, d = 7;
//int enb = 0;
//if (a > b && a > c && a > d)
//{
//    enb = a;
//}
//else if (b > a && b > c && b > d)
//{
//    enb = b;
//}
//else if (c > a && c > b && c > d)
//{
//    enb = c;
//}
//else
//{
//    enb = d;
//}

string[] isimler = new string[3]; // e elemanlı string dizisi...
int[] sayilar = new int[4]; // 4 elemanlı int dizisi...
sayilar[0] = 3;
sayilar[1] = 5;
sayilar[2] = 6;
sayilar[3] = 7;

Console.WriteLine("1. eleman " + sayilar[0]);
Console.WriteLine("1. eleman " + sayilar[1]);
Console.WriteLine("1. eleman " + sayilar[2]);
Console.WriteLine("1. eleman " + sayilar[3]);

for (int i = 0; i < 4; i++)
    Console.WriteLine(i + " eleman" + sayilar[i]);

int enb = 0;
for (int i = 0; i < 4; i++)
    if (sayilar[i] > enb)
        enb = sayilar[i];

Console.WriteLine($"Sayıların en büyüğü {enb}");


// eğer dizi olmasaydı
string str1 = "Turgut";
string str2 = "Kaan";
string str3 = "Turan";
string str4 = "Hakan";
string str5 = "Kartal";

Console.WriteLine(str1);
Console.WriteLine(str2);
Console.WriteLine(str3);
Console.WriteLine(str4);
Console.WriteLine(str5);

Console.WriteLine("------------------------------");

// dizi olduğu için
string[] names = new string[5];
names[0] = "Turgut";
names[1] = "Kaan";
names[2] = "Turan";
names[3] = "Hakan";
names[4] = "Kartal";

for (int i = 0; i < 5; i++)
    Console.WriteLine(names[i]);

