// ÖDEV: Öğrencinin vize final notu alınsın, ortalaması 25'den büyük olan öğrencilerin;
// 85-100 arası ise AA
// 70-84 arasında ise BA
// 60-69 arasında ise BB
// Diğer aralıkları ben belirleyeceğim.(F) e kadar göster notları.

// Önce ortalamayı bul
// ortalama 25'den büyük mü?
// büyükse aa, ba mesajları için kriter belirleyeceğiz.



Console.WriteLine("Vize Notunuzu Girin");
float vize = Convert.ToSingle(Console.ReadLine());

if (vize < 0 || vize > 100)
    Console.WriteLine("Geçersiz Vize");

Console.WriteLine("Final Notunuzu Girin");
float final = Convert.ToSingle(Console.ReadLine());

if (final < 0 || final > 100)
    Console.WriteLine("Geçersiz Final");

vize *=  0.4f;
final *= 0.6f;

float ortalama = vize + final;

Console.WriteLine("Ortalamanız = " + ortalama);

if (ortalama < 25)
{
    Console.WriteLine("Kaldınız...");
}
if (ortalama > 25)
{
    if (ortalama < 40)
    {
        Console.WriteLine("Notunuz : F");
    }

    if (ortalama > 40 && ortalama <= 50)
    {
        Console.WriteLine("Notunuz : D ");
    }

    if (ortalama > 50 && ortalama <= 59)
    {
        Console.WriteLine("Notunuz : D+");
    }

    if (ortalama > 60 && ortalama <= 65)
    {
        Console.WriteLine("Notunuz : C-");
    }

    if (ortalama > 66 && ortalama <= 70)
    {
        Console.WriteLine("Notunuz : C");
    }

    if (ortalama > 71 && ortalama <= 75)
    {
        Console.WriteLine("Notunuz : C+");
    }

    if (ortalama > 76 && ortalama <= 80)
    {
        Console.WriteLine("Notunuz : B-");
    }

    if (ortalama > 81 && ortalama <= 85)
    {
        Console.WriteLine("Notunuz : B");
    }

    if (ortalama > 86 && ortalama <= 90)
    {
        Console.WriteLine("Notunuz : B+");
    }

    if (ortalama > 90 && ortalama <= 95)
    {
        Console.WriteLine("Notunuz : A-");
    }

    if (ortalama > 96 && ortalama <= 100)
    {
        Console.WriteLine("Notunuz : A");
    }
}
else
{
    Console.WriteLine("Öyle bi not yok");
}

// Not: Eğer if bloğunun içerisinde tek satırlık kod varsa scope aç kapaya gerek yoktur.

// ÖNEMLİ NOT : Else if ifadesi çalıştıktan sonra diğer koşulllara bakılmaz.

// Hoca ile Birlikte Yapınca;

//float vize, final, ortalama;

//Console.WriteLine("Vize Notunuzu Girin");
//vize = Convert.ToSingle(Console.ReadLine());

//if (vize < 0 || vize > 100)
//    Console.WriteLine("Geçersiz Vize");

//Console.WriteLine("Final Notunuzu Girin");
//final = Convert.ToSingle(Console.ReadLine());

//if (final < 0 || final > 100)
//    Console.WriteLine("Geçersiz Final");

//ortalama = vize * 0.4f + final * 0.6f;

//if (ortalama >= 25)
//{

//    if (ortalama > 85)
//    {
//        Console.WriteLine("Harf Notu : AA");
//    }
//    else if (ortalama >= 75)
//    {
//        Console.WriteLine("Harf Notu : BA");
//    }
//    else if ( ortalama >= 65)
//    {
//        Console.WriteLine("Harf Notu : BB");
//    }
//    else if (ortalama >= 55)
//    {
//        Console.WriteLine("Harf Notu : CB");
//    }
//    else if (ortalama >= 55)
//    {
//        Console.WriteLine("Harf Notu : CC");
//    }
//    else if (ortalama >= 45)
//    {
//        Console.WriteLine("Harf Notu : CC");
//    }
//    else if (ortalama >= 25)
//    {
//        Console.WriteLine("Harf Notu : DD");
//    }
//}
//else
//{
//    Console.WriteLine("Ders Tekrarı");
//}


//float vize, final, ortalama;

//Console.WriteLine("Vize Notunuzu Girin");
//vize = Convert.ToSingle(Console.ReadLine());

//if (vize < 0 || vize > 100)
//    Console.WriteLine("Geçersiz Vize");

//Console.WriteLine("Final Notunuzu Girin");
//final = Convert.ToSingle(Console.ReadLine());

//if (final < 0 || final > 100)
//    Console.WriteLine("Geçersiz Final");

//ortalama = vize * 0.4f + final * 0.6f;

//if (ortalama >= 25)
//{
//    string harfNot = "";
//    if (ortalama > 85)    
//        harfNot = "AA";    
//    else if (ortalama >= 75)   
//        harfNot = "BA";    
//    else if (ortalama >= 65)   
//        harfNot = "BB";    
//    else if (ortalama >= 55)    
//        harfNot = "CB";    
//    else if (ortalama >= 55)   
//        harfNot = "CC";   
//    else if (ortalama >= 45)    
//        harfNot = "CC";    
//    else if (ortalama >= 25)    
//        harfNot = "DD";    
//    Console.WriteLine("Harf Notunuz = " +harfNot);
//}
//else
//{
//    Console.WriteLine("Ders Tekrarı");
//}