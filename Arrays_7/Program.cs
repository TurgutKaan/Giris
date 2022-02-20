// Kullanıcıdan 5 adet benzersiz sayı alalım, bu sayıların en büyüğü, en küçüğü, ortalamasını ekrana yazdıralım.

// Ödev: bu örneğin aynısını for döngüsü ile yapın. Not: for'un yapısını bozmadan. for(int i=0; i>sayis.Length;i++)

int n = 5;
int[] sayis = new int[n];

int i = 0;
while (i < sayis.Length) 
{ 
    Console.WriteLine($"Lütfen ({i+1}). sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if(Array.IndexOf(sayis, sayi) == -1) // sayiyı sayisde ara
    {
        sayis[i] = sayi;
        i++;
    }
    
}

Console.WriteLine($"En Büyüğü {sayis.Max()}");
Console.WriteLine($"En Küçüğü {sayis.Min()}");
Console.WriteLine($"Ortalaması {sayis.Average()}");