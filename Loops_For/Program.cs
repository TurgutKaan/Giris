// Loop ( Döngüler) => Kod satır veya satırlarını tekrar çalıştırmak için kullanılan ypılara denir. Bir döngünün çalışabilmesi için bir koşulun olması bir de koşullu kodun olması gerekir.
// i++ ifadesi i = i + 1 'in kısaltmasıdır.

/*  c# dilinde 4 adet döngü vardır. Bunlar;
    1)for
    2)while
    3)do while
    4)foeach (sadece c#'ta var)
 */

/*
 for adımları;
1- Başlangıç değeri belirlenir
2- Koşula bakılır
3- Koşullu komut çalıştırılır
4- artım işlemi yapılır 
 */

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Introductionı c# ile öğreniyoruz");
}

int j = 0;
while (j < 3)
{
    Console.WriteLine("Introductionı c# ile öğreniyoruz");
    j++;
}

// Do while döngüsü => Diğer iki döngünün aksine önce işlem yapılır sonra koşula bakılır.
// Çok tercih edilen bir döngü değildir.


int k = 0;
do
{
    Console.WriteLine("Introductionı c# ile öğreniyoruz");
    k++;
} while (k < 3);
