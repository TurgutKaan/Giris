/*
 String Metotları
 */



string isim = "     Kaan         ";
string isim1 = "Turan";
// Trim() => string metninin kenarındaki boşlukları almak için kullanılır.
Console.WriteLine(isim + isim1);

//isim = isim.Trim(); 
Console.WriteLine(isim.Trim() + isim1);

string isim2 = "Kaan Turan";
string a = isim2.Substring(0, 4); // çıktısı Kaan

string b = isim2.Substring(5, 5); // Turan

Console.WriteLine(a);
Console.WriteLine(b);

Console.WriteLine("Adınız Syadınız");
string FullName = Console.ReadLine(); // Kaan Turan

// IndexOf => Metin içerisinde karakter arar
int i = FullName.IndexOf(' ');
string Name = FullName.Substring(0, 1);

Console.WriteLine($"Hoş Geldin {FullName}");

// Split => Metni belirtilen karaktere göre parçalar ve dizi döner
string FullName2 = FullName;
string[] temp = FullName2.Split(' '); // boşluk karakterine göre diziye ayır. (parçala dizi yap)
Console.WriteLine($"Hoş Geldin {temp[0]}");

string aaaa = "ekrem,emre,ahmet";
string [] ogrenciler = aaaa.Split(' '); 

// Replace =Z Metin içerisinde karakter değiştirir.
string metin = "ekrem yıldırım";
metin = metin.Replace("ı", "i");

// Metotlar Konusuna Giriyoruz.