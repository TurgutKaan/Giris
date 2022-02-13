// Kullanıcıdan 1 sayı istenecek. Eğer sayı 1 ile 100 arasında ise "Sayı Pozitif" mesajı verilecek. Eğer 0'dan küçükse "Sayı Negatif" mesajı verilecek, eğer 0 ise "Sayı 0" mesajı verilecek.

// Benim yazdığım yer

//Console.WriteLine("Sayı Girin");
//int sayi = Convert.ToInt32(Console.ReadLine());

//if (sayi == 0)
//{
//    Console.WriteLine("Sayı 0");
//}

//else if ( sayi>1 && sayi < 100)
//{
//    Console.WriteLine("Sayı Pozitif");
//}

//else if (sayi<0)
//{
//    Console.WriteLine("Sayı Negatif");
//}

//else
//{
//    Console.WriteLine("Sayıyı Beğenmedim");
//}


// Hocayla yazdığım yer

Console.WriteLine("Sayı Giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi <= 100)  // girilen sayı 100'den küçük mü?
{
    if (sayi < 0)
    {
        Console.WriteLine("Negatif");
    }
    else if (sayi == 0)
    {
        Console.WriteLine("0");
    }
    else
    {
        Console.WriteLine("Pozitif");
    }
}
else
{
    Console.WriteLine("Sayıyı Beğenmedim");
}


// ÖDEV: Öğrencinin vize final notu alınsın, ortalaması 25'den büyük olan öğrencilerin;
// 85-100 arası ise AA
// 70-84 arasında ise BA
// 60-69 arasında ise BB
// Diğer aralıkları ben belirleyeceğim.(F) e kadar göster notları.

// Önce ortalamayı bul
// ortalama 25'den büyük mü?
// büyükse aa, ba mesajları için kriter belirleyeceğiz.
