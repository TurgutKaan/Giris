/*
                Switch Case Yapısı 
Daha sadece ifadeler(koşullar) yazmak için kullanılır.

    Switch(değer){
        case sabitdeger1: 
            <kosulluKod>
        break;
        case sabitdeger2: 
            <kosulluKod>
        break;
        case sabitdeger3: 
            <kosulluKod>
        break;
        default:
        break;
    }

Değer sabitdeger ile karşılaştırılır, hangi sabitdeger eşitse o case bloğu çalıştırılır. Case'deki koşullu kod sonrasında break ifadesi ile switch sonlandırılır. Eğer değer sabitdeger'le eşit değilse default(else gibi) bloğu çalışır. 
 */

int a = 5;
switch (a)
{
    case 1:
        Console.WriteLine("bir");
        break;
    case 2:
        Console.WriteLine("iki");
        break;
    case 4:
        Console.WriteLine("dört");
        break;
    default:
        Console.WriteLine("case'lerden birisi değil");
        break;
}


// a ile 5 karşılaştırılır eğer a 5'ten küçükse if bloğu çalışır
a = 6;
if (a < 5)
{
    Console.WriteLine("a 5'ten küçüktür");
}

bool b = a > 5;
// switch ile
// switch (b)
switch (a > 5)
{
    case true:
        Console.WriteLine("a büyük 5'ten");
        break;
    case false:
        Console.WriteLine("a küçük 5'ten");
        break;
}

Console.WriteLine("Harf Notunuzu Giriniz");
string harfNotu = Console.ReadLine();
int not = 0;
switch (harfNotu)
{
    case "AA":
        not = 85;
        break;
    case "BA":
        not = 75;
        break ;
    case "BB":
        not = 65;
        break;
    case "CC":
        not = 55;
        break;
    case "DC":
        not = 45;
        break;
    //case "DC":     // NOT : Case'ler unique olmalıdır.
    //    not = 35;
    //    break;
    case "DD":
        not = 25;
        break;

}
//Console.WriteLine("BB notunun taban puanı 65");
//Console.WriteLine("65 taban puanı BB harf notunun karşılığıdır");

//Console.WriteLine(harfNotu + " notunun taban puanı " + not);
//Console.WriteLine(not + " taban puanı " + harfNotu + " harf notunun karşılığıdır");
// alt taraftaki console.writeline'lar daha temiz.
// $ stringe dışardan parametre (değer) verileceğini, { } ise parametreleri(değer) ifade eder
Console.WriteLine($"{harfNotu} notunun taban puanı {not}");
Console.WriteLine($"{not} taban puanı {harfNotu} harf notunun karşılığıdır");

