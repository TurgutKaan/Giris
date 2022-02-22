/* Kullanıcıdan 5 adet benzersiz sayı alalım for döngüsü ile
 bu sayıların,
en büyüğünü
 en küçüğünü
 ve ortalamasını ekrana yazdıralım
 */

int n = 5;
int[] sayilar = new int[n];

for (int i = 0; i<sayilar.Length; i++)
{
    Console.WriteLine($"Lütfen {i + 1}. sayıyı girin");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (Array.IndexOf(sayilar, sayi) == -1) // sayi'yi sayilarda ara.
    {
        sayilar[i] = sayi;
    }
    else
    {
        i--; // i'yi azalt.
    }
} 

Console.WriteLine($"Sayıların en büyüğü : {sayilar.Max()}");
Console.WriteLine($"Sayıların en küçüğü : {sayilar.Min()}");
Console.WriteLine($"Sayıların ortalaması : {sayilar.Average()}");


