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
  
}

Console.WriteLine(sayilar.Max());
Console.WriteLine(sayilar.Min());
Console.WriteLine(sayilar.Average());
