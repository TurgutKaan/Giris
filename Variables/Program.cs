// Algoritma, problem çözme tekniğidir.

//Veri                    
//Değişkenler - Variables 

/* 
    - Veriler diskte (kalıcı) veya ramde (geçici) saklanır.

    - Değişken Nedir? 
Ram'de veri saklamak için kullanılan alanlardır. Bellekteki adres işaretçileridir.
Bir değişken veri tutmak için oluşturulur.
    - Değişken oluşturabilmek için veri tiplerine ihtiyaç vardır.
    - Veri tiplerini 3 ana grupta inceleriz.
1) Metinsel Veri Tipleri (char, string) [sayısal değer girilir ama hesaplama yapılamaz]
2) Sayısal Veri Tipleri Tam sayı;(byte, sbyte, short, ushort, int, uint, long, ulong) Ondalıklı;(float, decimal, double)
3) Matıksal Veri Tipi (Bool)
 
    -Object => C#'taki tüm tiplerin atasıdır. En büyük.

  Örnek;
  <veriTipi> <değişkenAdi> = <ilkDeğer>;
  NOT: " = " c# dilinde atama operatörüdür. sağdaki değeri sola atar (set eder)    
*/

int sayi; // int tipinde sayı değişkeni.

int a = 1; // 1 değerini a'ya atadık.

int b = 3 + a;

//Bir değişken diğer değişkene atanırken kopyalanır.
int c = b; //b'nin değerini c'ye ata.

int o = 5, l = 2; // Tek satırda aynı tipte değişken tanımlayabiliriz.

/*
 Değişken tanımlarken;
 1) Değişken isimleri unique olmalıdır.
 2) Değişkenler tanım satırlarından sonra kullanılır.
 3) Değişken isimleri ön tanımlı kod isimleri kullanılamaz.
    int object veya int byte olmaz
 4) Değişken isimleri rakamla başlayamaz.
    int 1sayi; olmaz int sayi1; olur
 5) Değişken ömürleri tanımlı oldukları scope kadardır.

{

    int r;
}

{
    r burada görülmez. scope dışına alınırsa üst scopeta tanımlı olan r burada da görünür.
}
*/

    byte v1 = 255;  // byte tipli v1 değişkeni
    sbyte v2; // sbyte tipli veri değişkeni
    int v3 = 20034454; // int tipli v3 değişkeni
    char v4 = 'A'; // char tipli v4 değişkeni
    string v5 = "Beşiktaş"; // string tipli v5 değeri
    bool v6 = true; // bool tipli v6 değişkeni
    double v7 = 4.3; // double tipli v7 değişkeni
    decimal v8 = 50.4m; // m eki decimal'de kullanılır
    float v9 = 54.6f; // f eki float'ta kullanılır.

// char tipi tek tırnakla değerlenir ve tek harf alır içine.
// string çift tırnakla değerlenir ve text yazılabilir içine.

Console.WriteLine("Merhaba C# VeriTipleri");
Console.WriteLine(v1);
Console.WriteLine(v3);
Console.WriteLine(v4);
Console.WriteLine(v5);  
Console.WriteLine(v6);
Console.WriteLine(v7);
Console.WriteLine(v8);  
Console.WriteLine(v9);