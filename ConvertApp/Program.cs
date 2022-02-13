

//Console.WriteLine("Adınız?");

//string ad = Console.ReadLine(); // Console'dan veri almak için kullanılır. Satırı oku ad değişkenine ata

//Console.WriteLine("Hoş geldin" + " " + ad);
//Console.WriteLine("Hoş Geldin "+ad); // Aynı şeyler.

//// Kullanıcıdan iki sayı girmesini isteyelim.
//int sayi1, sayi2;

//Console.WriteLine("1. Sayıyı Giriniz");
//sayi1 = Convert.ToInt32(Console.ReadLine()); 

//Console.WriteLine("2. Sayıyı Giriniz");
//sayi2 =Convert.ToInt32(Console.ReadLine());

//int sonuc = sayi1 + sayi2;
//Console.WriteLine("İşlem Sonucu : " + sonuc);
// readline dan gelen komut string geliyor o sebeple matematiksel işlem yapmadı. Art arda ekledi sayıları sadece. Converto kullanarak matematiksel işlem yaptırdık.


float vize, final, ortalama;

Console.WriteLine("Vize Sonucunuzu Giriniz");
vize = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Final Sonucunuzu Giriniz");
final = Convert.ToSingle(Console.ReadLine());

ortalama = vize * 0.4f + final * 0.6f;

Console.WriteLine("Ortalamanız : " + ortalama);




