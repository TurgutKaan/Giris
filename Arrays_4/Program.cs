
int[] sayilar = new int[3];
sayilar[0] = 10;
sayilar[1] = 20;
sayilar[2] = 30;
//yukarıdaki yazılışın kısası aşağıda;
int[] sayilark = { 10, 10, 30,1, 4, 2 }; // 3 elemanlı sayılar dizisi

string[] kisiler = { "Hakan", "Kartal", "Turgut", "Kaan" };
char[] ka = { 'k', 'a', 'r', 't', 'a', 'l' };

int a =1, b =6, c =20, d=30, e=2;
int[] nums = { a, b, c, d, e };

int min = nums[0]; // 11
int max = nums[0]; // 11

foreach(int num in nums)
{
    if(num > max)
    {
        max = num;
    }

    if(num < min) 
    {      
        min = num; 
    }
}

Console.WriteLine($"min={min} & max = {max}");

// for ile

min = nums[0]; max = nums[0];
for (int i = 0; i < nums.Length; i++)
{
    int num = nums[i];
    if (num > max)
    {
        max = num;
    }
    if(num > min)
    {
        min =num;
    }
    Console.WriteLine(nums[i]);
}
Console.WriteLine($"min={min} & max={max}");