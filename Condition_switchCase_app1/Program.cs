

// Girilen harf sesli mi değil mi?

// Char.ToUpper(c) demek, c'nin değerini büyüğe çevirir
// Char.ToLower(c) demek, c'nin değerini küçüğe çevirir

Console.WriteLine(char.ToUpper('a')); // c'nin değerini büyüğe çevirir
Console.WriteLine(char.ToLower('A')); // c'nin değerini küçüğe çevirir

Console.WriteLine("Bir harf giriniz");
char c = Convert.ToChar(Console.ReadLine());


if (char.ToUpper(c) == 'A')
    if (char.ToLower(c) == 'a')
        if (c == 'a' || c == 'A')

            if (char.ToUpper(c) == 'A' || char.ToUpper(c) == 'E' || char.ToUpper(c) == 'I' || char.ToUpper(c) == 'İ' || char.ToUpper(c) == 'U' || char.ToUpper(c) == 'Ü' || char.ToUpper(c) == 'O' || char.ToUpper(c) == 'Ö')
            {
                Console.WriteLine("Sesli harf girdiniz");
            }
            else
            {
                Console.WriteLine("Sessiz harf girdiniz");
            }


//Console.WriteLine("Switch ile...");
// Birden fazla case ifadesi tek bir koşullu kod için yazılabilir. Buradaki case'leri veya karşılaştırması gibi düşünebilirsiniz.

switch (char.ToUpper(c))
{
    case 'A':
    case 'E':
    case 'I':
    case 'İ':
    case 'U':
    case 'Ü':
    case 'O':
    case 'Ö':
        Console.WriteLine("Sesli harf");
        break;
    default:
        Console.WriteLine("Sessiz harf girdiniz");
        break;
}

// c'deki değer k değişkenine atanarak işlem yapılır.
//char k ifadesi char tipindeki k değişkenine c'nin değerini atar.
// case when yapısı
switch  (char.ToUpper(c))
{
    case char k when k == 'A' || k == 'E' || k == 'I' || k == 'İ' || k == 'U' || k == 'Ü' || k=='O' || k=='Ö':
        Console.WriteLine("Sesli harf girdiniz");
        break;
    default :
        Console.WriteLine("Sessiz harf girdiniz");
        break ;
}