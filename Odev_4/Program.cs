class Program
{
    // isPalindrome metodu ile cümle içerisindeki palindrome kelimeleri bulup palindrome dizine ekleyen programı yazınız.

    //View --> Task List. To do listler view menüsü altında task listesinde bulunur.

    // cümleyi parçala (string to char gibi) kelime kelime palindrome olup olmadığına bak.

    // Palindrome kelimeleri yazdıralım

    static void Main(string[] args)
    {
        string cumle = "Bugün hava çok güzel, arkadaşlar ile piknik yapmaya gittik orada kavak ağaçları vardı çıkmadan önce elbiselerime ütü yaptım";

        string[] palindromes = cumle.Split(' ');

        //Console.WriteLine($"{palindromes[0]}");

        //string[] palindromes = new string[0];

        foreach (var item in palindromes)
        {
            char[] ch = item.ToCharArray();
            Array.Reverse(ch);
            bool isPalindrome;
            if( item == new string(ch))
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }
            if (isPalindrome)
                Console.WriteLine($"{item} 'palindrome kelimedir' ");
            else
                Console.WriteLine(item);
            //Console.WriteLine(item);
        }
    }

    //static bool IsPalindrome(string kelime)
    //{
    //    bool isp = true; // geçici true değeri verdik
    //    // eğer kelime palindrome ise isp true, değilse false atanmalı

    //    return isp; // isp i dön.
    //}
}