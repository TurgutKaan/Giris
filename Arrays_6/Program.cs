// Array Metotları
// Dizileri üzerinde işlem yapmamızı sağlayan, bir çok problemde algoritma kurmadan sonuca ulaşmamızı sağlayan program parçalarıdır.


int[] nums = { 51, 6, 2, 11, 4, 43 };

Console.WriteLine($"Dizinin en büyüğü {nums.Max()}");
Console.WriteLine($"Dizinin en küçüğü {nums.Min()}");
Console.WriteLine($"Dizinin ortalaması {nums.Average()}");
Console.WriteLine($"Dizinin toplamı {nums.Sum()}");


// Ayrıca diziler için Array sınıfının metotları kullanılır.

Array.Sort(nums); // diziyi a-z sıralar
foreach(int i in nums) 
    Console.WriteLine(i);

Array.Reverse(nums); // diziyi ters çevirir.


string[] names = { "Turgut", "Hakan", "Kaan" };
//IndexOf => Dizide arama işlemi yapar. Eğer aranan eleman dizide varsa index numarasını döner. Eğer eleman dizide yoksa -1 döner.
int result = Array.IndexOf(names, "Kaan"); // Kaan 2. ,ndex'te olduğu için result'a 2 set eder.
int result2 = Array.IndexOf(names, "Sümeyye"); // Sümeyye elemanı dizide olmadığı için -1 döner.

//Örnek 1
char[] chars = new char[3];
chars[0] = 'A';
chars[1] = 'B'; 
chars[2] = 'C';
//chars[3] = 'd'; atama yapılamaz çünkü dizi 3 elemanlıdır. En büyük index 2'dir.
char[] temp = chars; // chars'e temp'e ata
chars = new char[4]; // yeni 4 elemanlı referans oluşturur
for(int i = 0; i<temp.Length; i++) // eskisine dön
    chars[i] = temp[i]; // ilgili elemanı ilgili index'e ata.

chars[3] = 'D';
foreach(char c in chars)
    Console.WriteLine(c);

// Örnek 2
char[] karakter = new char[4];
karakter[0] = 'K';
karakter[1] = 'A';
karakter[2] = 'A';
karakter[3] = 'N';

// karakter = new char[5]; Eski referansı kaybetmemek için new ifadesi kullanmıyoruz.!

Array.Resize(ref karakter, 5); // buradaki ref ifadesi karakter dizisinin referansını ifade eder. mevcut referans korunarak dizinin uzunluğu 5 yapılır.

karakter[4] = 'm';
foreach(char ck in karakter)
    Console.WriteLine(ck);

string[] kisiler = { "Hakan", "Kartal", "Turan" }; // dizinin uzunluğu 3
Array.Resize(ref kisiler, 2); // yeni uzunluk 2, 2. elemandan sonrası gider.

// Hakan ile Kartal'ın yerlerini değiştirelim
Array.Reverse(kisiler);
foreach(string k in kisiler)
    Console.WriteLine(k);
// diziyi ters çeviriyoruz. 2'ye düşürdüğümüz için ilk değer Hakan ikinci değer Kartal oluyor ve ters çevirince direkt bu iki veri yer değiştirmiş oluyor.

// Anonim tip (anonymous types) => belirsiz tipler. Tip değer atandığında oluşur. Anonim tip kullanmak için değer atanması zorunludur.

int z = 1;
string s = "deneme";
var a = "deneme"; // anonim a değişkeni. değer atandığı a'nın değeri string oldu.
var b = 1; // variable'ın tipi int oldu
var c = false; // bool
var d = 'D'; // char
var e = 3.1; // double
var f = 3.1f; // float

var ogrencis = new string[] { "Turgut", "Kaan", "Turan", "Hakan" }; // string dizisi
var numbers = new int[] { 10, 20, 30, 40 }; // int dizisi

// NOT: Anonim tipler ileride anlık tipler oluşturmak zorunda kaldığımızda hayat kurtarır. Genelde böyle işler için tercih edilir.

foreach(var item in kisiler)
    Console.WriteLine(item);

foreach(var item in chars)
    Console.WriteLine(item);

foreach(var item in nums)
    Console.WriteLine(item);