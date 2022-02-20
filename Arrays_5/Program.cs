// Ekrana c# bt akademi gelecek şekilde yazdıralım.

//string[] vs = { "BT AKADEMİ", "C#" };
//foreach (string v in vs)
//    Console.WriteLine(v);

//string[] vs = { "BT AKADEMİ", "C#" };
//Console.WriteLine(vs[1]);
//Console.WriteLine(vs[0]);

//string[] vs = { "BT AKADEMİ", "C#" };
//string temp, temp2;

//temp = vs[0];
//vs[0] = vs[1];
//vs[1] = temp;

//foreach(string v in vs)
//    Console.WriteLine(v);

string[] vs = { "BT AKADEMİ", "C#" };
string temp = vs[0]; // BT AKADEMİ
vs[0] = vs[1];
vs[1] = temp;
//Ekrana c# bt akademi gelecek şekilde yazdıralım
foreach(string v in vs)
{
    Console.WriteLine(v);
}

int a = 3;
int b = 2;

int c = a; // 3
a = b; // 2
b = c; // 3

// beklenilen çıktıyı üçüncü bir değişken kullanmadan yapın.

Console.WriteLine($"a'nın değeri {a}"); // 2
Console.WriteLine($"b'nin değeri {b}"); // 3
