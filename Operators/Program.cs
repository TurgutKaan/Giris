// Operatörler;

// = atama operatörüdür, sağdaki değeri sola atar.
//int z = 1;
//string s = "1";

//atama operatörlerinde kural sağdaki tip ile soldaki tip birbirine eşit olmalıdır.
//int u = "1"; // değerin tipi string olduğu için int tipindeki bir değişkene atanamaz.
//byte b = 1;
//int c = b;// b tipi int tipi ile ortak olduğu için bu atama yapılabilir.

// Aritmatic Operators;
//int sonuc = 3 + 4; // toplama operatörü
//Console.WriteLine(sonuc);

//sonuc = sonuc + 5;
//Console.WriteLine(sonuc);

//sonuc += 5;
//Console.WriteLine(sonuc);

//int sonuc2 = 3 * 4;
//Console.WriteLine(sonuc2);

//sonuc2 = sonuc2 * 2;
//Console.WriteLine(sonuc2);

//sonuc2 *= 10;
//Console.WriteLine(sonuc2);

//int sonuc;

//sonuc = 3 - 1;
//Console.WriteLine(sonuc);

//sonuc -= 10;
//Console.WriteLine(sonuc);

//sonuc = 3 / 1;
//Console.WriteLine(sonuc);

//sonuc /= 3;
//Console.WriteLine(sonuc);

// Karşılaştırma operatörleri, iki değeri karşılaştırmak için kullanılır.

//Console.WriteLine(3>1);
//Console.WriteLine(3<1);

//int i = 1, j=5;
//Console.WriteLine(i<j);
//Console.WriteLine(i>j);

//bool snc = i < j;
//Console.WriteLine(snc);
//bool snc2 = i > j;
//Console.WriteLine(snc2);

//Console.WriteLine(i >= j); // büyük eşit operatörü
//Console.WriteLine(i <= j);

// Eşitlik

//Console.WriteLine(i==j); // i j'ye eşit mi? eşitse true değilse false çıkar sonuç

//Console.WriteLine("a"=="b"); // string değer olarak a b'ye eşit mi?

//Console.WriteLine('c'=='d'); // char olarak c d'ye eşit mi?

/*Console.WriteLine("Turgut Kaan" == "Turgut Kaan");*/ // Büyük harf küçük harfe dikkat ederek karşılaştırır. bu case de true

// Eşit değil 

Console.WriteLine("BEŞİKTAŞ" != "KARAKARTAL"); // eşit olmadığı için true olarak döner.

Console.WriteLine('A' != 'A'); // eşit olduğu için false olarak döner.


// bool d = z == s; // tipler birbirine eşit olmadığı için karşılaştırma yapılamaz.

// Mantıksal operatörler // birden fazla değeri karşılaştırmak için kullanılır.
// Karşılaştırmalardan ikisinin de true olması gerekir.
// Mantıksal ve (and) && 



//int k = 1, l = 5, m = 3;
//bool durum = k < l && k < m;
//durum = "a" == "a" && "b" == "d"; // false
//durum = "a" == "a" && "b" != "d"; // true
//durum = "1" == s && k == l; // false

//Console.WriteLine(durum);

// veya (or) operatörü
//karşılaştırmalardan birisinin true olması yeterlidir.

//durum = k < l || k < m;
//durum = "a" =="b" || "b" =="d"; //false
//durum = "a" == "a" || "b" != "d"; // true
//durum = "1" == s || k == l; // true
