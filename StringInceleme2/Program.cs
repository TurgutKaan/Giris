
int a;

string[] names; // dizi değişkeni oluşturulur.
//names = { "Kaan", "Turgut"} // referans oluşturamadığımız için atama yapılamaz. new string ile dizi oluşturulur ve değer atanır. {} ataması başlangıçta verilebilir.
names = new string[] { "Kaan", "Turgut" };

int[] nums = new int[2];
//nums ={ 1,2}; // başlangıçta değer atanabilir.

char[] chs; //değişken oluşturduk.
//chs[0] = 'e'; // dizi oluşturulmadan değer atanamaz.
//chs ={ 'a', 'b'};
chs = new char[2];
chs[0] = 'k'; // dizi oluşturulduktan sonra değer atanabilir.


string[] names1 = { "recep", "ekrem", "emre" };

// dizinin elemanlarını ekrana ters yazdıralım.

Console.WriteLine(names1.Length); // 3
Console.WriteLine(names1[0].Length); // 5

Console.WriteLine(names1[1][1]); // k
Console.WriteLine(names1[2][2]); // r

for(int i =0; i<names1.Length; i++) // elemanlarda dön
{
    for(int j = names1[i].Length-1; j>=0; j--) // elemanın karakterlerinde dön
    {
        Console.WriteLine(names1[i][j]);
    }
    Console.WriteLine("-------------------");
}

Console.WriteLine("-----------------------");
string[] kelimeler = { "panda" ,"ata" , "kavak" , "hava" ,  "masa", "ütü" };
// kelimelerin içerisindeki kelimenin ters ve düz okunuşu aynı ise palindrom'dur.
// dizi içerisindeki palindrom kelimeleri bulacağız.
for (int i = 0; i<kelimeler.Length; i++)
{
    string kelime = kelimeler[i];
    
    bool isPalindrome = false;

    int bas = 0;
    int son = kelime.Length-1;

    for (int j = 0; j<kelime.Length; j++)
    {
        if (bas == son) 
        { 
            break; 
        }
        if (kelime[bas++]==kelime[son--])
            isPalindrome = true;
        else
        {
            isPalindrome=false;
            break;
        }
    }
    if (isPalindrome)
        Console.WriteLine(kelime + " (palindrom)");
    else
        Console.WriteLine(kelime);
}

foreach(var item in kelimeler)
{
    char[] ch = item.ToCharArray(); //arraya çevir
    Array.Reverse(ch); // ters çevir
    bool isPalindrom;
    if( item == new string(ch)) // düz ve ters halini karşılaştır
    {
        isPalindrom = true;
    }
    else
    {
        isPalindrom=false;
    }
    if (isPalindrom)
        Console.WriteLine(item + " (palindrom)");
    else
        Console.WriteLine(item);
}