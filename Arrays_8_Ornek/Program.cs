Console.WriteLine("Bu uygulama girilen sayıların büyük, küçük, toplam ve ortalama değerlerini verir. Sen de oynamak ister misin? (E/H)");

string cevap = Console.ReadLine();

int[] nums = new int[1];
while (cevap.ToUpper() == "E")
{
    Console.WriteLine("Lütfen sayı girin");
    int sayi = Convert.ToInt32(Console.ReadLine());

    Array.Resize(ref nums, nums.Length + 1); // uzunluğuna +1 ekle.
    nums[nums.Length - 1] = sayi;

    Console.WriteLine("Tekrar eklemek ister misin?");
    cevap = Console.ReadLine();
}

Console.WriteLine($"Girilen sayıların toplamı = {nums.Sum()}");
Console.WriteLine($"Girilen sayıların ortalaması = {nums.Average()}");