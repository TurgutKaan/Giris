// Klavyeden a tuşuna basana kadar kullanıcıdan harf isteyen program.

//string str = "";
//while (str != "a")
//{
//    Console.WriteLine("Lütfen birşeyler yazın");
//    str = Console.ReadLine(); // a
//}

//string parola = "";
//while (parola != "safak")
//{
//    Console.WriteLine("Parola Nedir?");
//    parola = Console.ReadLine(); // şafak
//}



// 1'den 100'e n adet sayının toplamı?

Console.WriteLine("Kaç adet sayı giriyorsun?");
int n = Convert.ToInt32(Console.ReadLine());

int gtoplam = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{i + 1} . sayıyı giriniz");
    int girilenSayi = Convert.ToInt32(Console.ReadLine());
    gtoplam += girilenSayi;
}

Console.WriteLine($"Girilen Sayıların Toplamı : {gtoplam}");

//Console.WriteLine("Kaç adet sayı giriyorsun?");
//int n = Convert.ToInt32(Console.ReadLine());

//int gToplam = 0;
//int j = 0;
//while (j < n)
//{
//    Console.WriteLine($"{j + 1} . sayıyı giriniz");
//    int girilenSayi = Convert.ToInt32(Console.ReadLine());

//    if (girilenSayi >= 0 && girilenSayi <= 100)
//    {
//        gToplam += girilenSayi;
//        j++; // j sadece girilen sayı belirtilen aralıkta ise o zaman arttırılır.. Diğer ihtimalde j arttırılmayacağı için döngü tekrar dönecektir. Bu sayede kullanıcı doğru değer(leri) girene kadar kullanıcıdan sayı istenecektir.
//    }

//}
//Console.WriteLine($"Girilen Sayıların Toplamı = {gToplam}");


//1) n adet öğrencinin vize final notu istenecek. Vize ve finalden ortalama hesaplanaccak. En büyük ve en düşük ortalama notu ekrana yazdır. Sınıf ortalamasını ekrana yazdır.

//2) Kullanıcı adı ve şifre istenecek, kullanıcı adı admin ve şifre 123 ise hoş geldin admin mesajı verilip döngü bir daha dönmeyecek şekilde sonlandırılacak. Not : öğretilen dışında bir şey kullanmak yok. 
//Eğer kullanıcı adı veya şifre yanlış ise kullanıcıya bilgileriniz yanlış mesajı verilecek. kullanıcı bilgileri en fazla 3 kez hatalı girebilecek. Eğer üçüncü kez de hatalı girerse uygulama hesabınız bloke olmuştur mesajı verilip yine döngü sonlandırılacak.

// Versiyon kontrol sistemi nedir?
//GIT
//SVN
//TFS

//Gitler versiyonla
//Github'da sakla

//Repository ; kodları sakladığımız depo.

// Komutların saklandığı yere github denir.