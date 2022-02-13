
Console.WriteLine("1. Sayıyı Giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı Giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

// Programın performans kaybı yaşamaması ve doğru çalışması için ifleri birbirine bağlamak gerekir. Çünkü burada tek koşul sağlanabilir.

if (sayi1 > sayi2)
{
    Console.WriteLine("1. Sayı Büyüktür");
}
else if ( sayi2 > sayi1)
{
    Console.WriteLine("2. Sayı Büyüktür");
}
else
{
    Console.WriteLine("Sayılar Eşittir");
}
Console.WriteLine("Program Doğru Sonucu Buldu");






// Daha doğru yazımı yukarıda

//if(sayi1 < sayi2)
//{
//    Console.WriteLine("2. Sayı Büyüktür");
//}

//if( sayi1 == sayi2)
//{
//    Console.WriteLine("Sayılar Eşit");
//}

//else
//{
//    Console.WriteLine("Sayılar Eşittir");
//}
