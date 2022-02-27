

class Program // class konusuna sonra gireceğiz
{
    // Statik konusu class yapısında ve static üyelerde işlenecek
    // Main => Ana program
    // .Net 6'dan önce console uygulamalarında bu yapı hazır gelirdi bizler de kodlarımızı main içerisine yazardık. Bu yapıyı manuel oluşturduk.
    static void Main(string[] arg)
    {
        #region tanim
        

        // Method => belirli bir isim altında toplanmış kod parçacıklarıdır.(Belirli bir işi yapmak için araya getirilmiş kod blokları) Metotlar uygulamayı modüllere bölmek için kullanılır. Program içerisinde işleri parçalamak ve daha kolay yönetmek için kullanılır.

        // Uygulsms içerisinde kullandığımız komutları farklı yerlerde de kullanmak isteyebiliriz. Farklı yerlerde kod tekrarı yapmaktansa bir kere yazıp, bunu sürekli kullanmayı tercih ederiz.

        // Metotlar önce tanımlanır. Metotların kullanılması için çağrılması gerekir. Örneğin bizler ön tanımlı metotları kullanmak için çağrırız;
        int a =Convert.ToInt32("2");
        Array.Sort(new[] { 1, 7, 3, 6, 2 }); // Belirtilen diziyi sırala.

        /*
         erisimSeviyesi donusTipi MetotAdi()
        {
            <metotGovdesi>
        }
         
        erisimSeviyesi => Metoda nereden erişilecek? Detaylarına oop konusunda değinilecek. private, protected, internal, protected internal, public. Şimdilik private ile devam ediyoruz.
        donusTipi => Metot işini bitirdikten sonra döneceği değer.
        metotAdi => Alt programın adı
        metotGovdesi => Yapılacak iş (kodlar)

        Metotlar ile 2 tip dönüş yapılabilir. İş bittikten sonra boş dönen metotlar ve dolu (değer) dönen metotlar.
        Bir metot eğer geriye değer dönmeyecekse dönüş tipi void olarak belirlenir. Eğer değer dönecekse dönüş tipi bildiğimiz tiplerden birisi olarak belirlenir.

        // Dönüş tipimiz void (yani bişey dönmeyecek)
        private void MyMethod()
        {

        }

        Not: Metot dönüş tipimiz eğer void değilse, metodun gövdesinde return ifadesi ile değer dönmek zorunludur. Dönecek değer donustipi ile aynı olmak zorundadır.

        // Dönüş tipimiz int
        private int Topla()
        {
            retur donecekDeger;
        }
        
        Metotlar parametre alabilen varlıklardır. Parametre => Metot gövdesine metot dışında deer geçirmek için kullanılır. Örneğin; Sort, Reverse, ToInt32, Split, WriteLine gibi metotlara parametre gönderilir ve buna göre işlem yapılır.

         */
        Console.WriteLine("Region içinde kalan kod");
        #endregion
        Console.WriteLine("Selam");

        MesajVer();
        MesajVer();

        // Parametre değerlerine argüman denir.
        Mesaj("Turgut");
        Mesaj("Kaan");
        string name = "Kartal";
            Mesaj(name);

        Mesaj2("Merhaba" , "Hakan");
        Mesaj2("Hello" , "Turgut");
        Mesaj2("Selam" , "Kartal");

        Message();
        Message("Kartal");
        Message("Turgut");
        Message("Selam" ,"Hakan");
        Message("Hello" ,"Turan");
        Message("Naber", "Kaan");
        //Message("Selam", "Tuki", "Nasılsın?"); 3 argümanlı metot tanımlı olmadığı için hata alırız.
    }
    
    private static void MesajVer() // Tanım yaparsın buradaki console.writeline çalışmaz ne olacağını belirler sadece!
    {
        Console.WriteLine("Merhaba ben metot");
    }

    private static void Mesaj(string isim) // isim string tipinde Mesaj metodumuzun parametresidir. Parametre metot dışında metoda değer göndermedir.
    {
        Console.WriteLine($"Merhaba {isim}");
    }

    private static void Mesaj2(string msj, string isim)
    {
        Console.WriteLine($"{msj} {isim}");
    }

    // C# dilinde varlık isimleri unique olmalıdır. Metotlarda ise bu durum farklıdır. Metotlarda aynıisimler kullanılabilir. Örnek Convert.ToInt32 metodunda f12 ile detayına giderek görebilirsiniz. Bu yapıya metot overload denir.
    // Metot Overload => aynı isimdeki metotların farklı parametreler ile tanımlanmasıdır.

    private static void Message()
    {
        Console.WriteLine("Merhaba ben metot");
    }
    private static void Message(string name)
    {
        Console.WriteLine($"Merhaba {name}");
    }

    private static void Message(string msg, string name)
    {
        Console.WriteLine($"{msg} {name}");
    }
}