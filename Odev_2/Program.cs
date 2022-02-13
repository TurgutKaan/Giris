//1) n adet öğrencinin vize final notu istenecek. Vize ve finalden ortalama hesaplanacak. En büyük ve en düşük ortalama notu ekrana yazdır. Sınıf ortalamasını ekrana yazdır.

//Console.WriteLine("Kaç Öğrencinin Vize ve Final Notu Girilecek");
//int n = Convert.ToInt32(Console.ReadLine());

////float sinifOrt =0f;
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine($"{i + 1} Öğrencinin Vize Notu");
//    float girilenVizeNot = Convert.ToSingle(Console.ReadLine());
//    if( girilenVizeNot < 0 || girilenVizeNot > 100)
//    {
//        Console.WriteLine("Geçersiz Not, not 0'dan küçük 100'den büyük olamaz lütfen tekrar başlayın.");
//    }
//    Console.WriteLine($"{i + 1} Öğrencinin Final Notu");
//    float girilenFinalNot = Convert.ToSingle(Console.ReadLine());
//    if( girilenFinalNot < 0 || girilenFinalNot > 100)
//    {
//        Console.WriteLine("Geçersiz Not, not 0'dan küçük 100'den büyük olamaz lütfen tekrar başlayın.");
//    }

//    girilenVizeNot = girilenVizeNot * 0.4f;
//    girilenFinalNot = girilenFinalNot * 0.6f;
//    float ortalama = (girilenVizeNot + girilenFinalNot);
//    Console.WriteLine($"{i + 1}. Öğrencinin Ortalaması; {ortalama}");

//sinifOrt = ortalama / n;
//}

//Console.WriteLine($"Sınıf Ortalaması: {sinifOrt}");

// Sınıf ortalamasını ve en büyük ve en küçük ortalamayı yazdıramadım.
///////////////////////////////////////////////////////////////////////////////////////////////////////////

//2) Kullanıcı adı ve şifre istenecek, kullanıcı adı admin ve şifre 123 ise hoş geldin admin mesajı verilip döngü bir daha dönmeyecek şekilde sonlandırılacak. Not : öğretilen dışında bir şey kullanmak yok. 
//Eğer kullanıcı adı veya şifre yanlış ise kullanıcıya bilgileriniz yanlış mesajı verilecek. kullanıcı bilgileri en fazla 3 kez hatalı girebilecek. Eğer üçüncü kez de hatalı girerse uygulama hesabınız bloke olmuştur mesajı verilip yine döngü sonlandırılacak.


int girisSayisi;
string kAdi = "";
string parola = "";
while (kAdi != "admin" && parola!="123")
{
    Console.WriteLine("Kullanıcı Adınız");
    kAdi = Console.ReadLine(); // admin
   

    Console.WriteLine("Parola Nedir?");
    parola = Console.ReadLine();  //123

    if (kAdi != "admin" || parola != "123")
    {
        Console.WriteLine("Kullanıcı Bilgileriniz Yanlış");
    }
}
//int girisSayi = Convert.ToInt32(girisSayisi);
//if (girisSayisi > 3)
//{
//    Console.WriteLine("Hesabınız Bloke Olmuştur.");
//}


// 3. denemeden sonra hesabın bloke olmasını yazamadım.

Console.WriteLine("Hoş Geldin Admin");





