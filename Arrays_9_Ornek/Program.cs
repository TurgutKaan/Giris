string[] ogr = { "Kartal", "Kaan", "Turgut" };
float[] nots = { 40, 0, 50 };

string[] ogrenciler = new string[0];
float [] notlar = new float[0];

int i = 0;
string cevap;
do
{
    Console.WriteLine($"{i + 1}. öğrencinin adı");
    string ogrenci = Console.ReadLine();

    Console.WriteLine($"{i + 1}. öğrencinin vize notu");
    float vize = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine($"{i + 1}. öğrencinin final notu");
    float final = Convert.ToSingle(Console.ReadLine());

    float ortalama = vize * 0.4f + final * 0.6f;

    Array.Resize(ref ogrenciler, i + 1);
    Array.Resize(ref notlar, i + 1);

    ogrenciler[i] = ogrenci;
    notlar[i] = ortalama;

    Console.WriteLine("Başka öğrenci var mı?");
    cevap = Console.ReadLine();
    i++;
}

while (cevap.ToUpper() == "E");


// hesaplayalım
float avg =nots.Average();
//int index = -1;
//foreach (var not in notlar)
//{
//    index = Array.IndexOf(notlar, not, index + 1);
//    string ogrenci = ogrenciler[index];
//    string durum = not >= avg ? "geçti" : "kaldı"; //ternary if. koşul ve iki durumda kullanılır.

//    //if (not >= avg)
//    //{
//    //    durum = "geçti";
//    //}
//    //else
//    //{
//    //    durum = "kaldı";
//    //}
//    Console.WriteLine($"Ad Soyad = {ogrenci} Durum ={durum}");
//}

for (int j = 0; j<notlar.Length; j++)
{
    string ogrenci = ogrenciler[j];
    string durum = notlar[j] < avg ? "kaldı" : "geçti"; // ternary if => koşul ? true : false
    //if (notlar[j] >= avg)
    //    durum = "geçti";
    //else
    //    durum = "kaldı";
    Console.WriteLine($"Ad Soyad = {ogrenci} durum ={ durum}");
}

