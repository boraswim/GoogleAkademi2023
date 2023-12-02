bool loop = true;
int selection;
do
{
    Console.Write
(@"MODUL 2: Programlamaya Giris
0. Hello World
1. Yazim: Hatalara Giris|Execution Order: Programlama dili nasil calisir?
2. Egzersiz: Console'da Yazi Yazma|Egzersiz: Farkli Cozum
       
MODUL 3: Degerlerin Kullanilmasi
3. Literals
4. Deklerasyon|Degerlerde Problemler|Implicit Declaration: Tanimlama
5. Implicit Declaration: Ornek
6. Escape Character: Ornekler
7. String Concatenate|Interpolation

MODÜL 4: Sayısal Operasyonlar
8. Toplama
9. Basit 4 Islem

99. Cikis

Calistirmak istediginiz kod parcasininin numarasini giriniz:");
    selection=Convert.ToInt32(Console.ReadLine());
    switch(selection)
    {
        case 0:
        {
            // MODÜL 2: Programlamaya Giriş
            // Hello World
            Console.WriteLine("Hello, World!"); // Bu bir yorum satırıdır. Bu fonksiyon konsolda "Hello World" yazılmasını sağlar.
            Console.ReadLine();
            break;
        }

        case 1:
        {
            // Yazım: Hatalara Giriş|Execution Order: Programlama dili nasıl çalışır ?
            Console.Write("Yenisatir");
            Console.Write("DigerWrite");
            Console.ReadLine();                 // VE && VEYA ||
            break;
        }

        case 2:
        {
            // Egzersiz: Console'da Yazı Yazma|Egzersiz: Farklı Çözüm
            // Bu bir satırdır
            // Bu da bir satırdır
            Console.WriteLine("Bu bir satirdir");
            Console.WriteLine("Bu da bir satirdir");
            Console.Write("\nBu bir sonraki satirdir");
            Console.Write("\nBu satir en alltadir");
            Console.ReadLine();
            break;
        }

        case 3:
        {
            // MODÜL 3: Değerlerin Kullanılması
            // Literals
            int a; 
            float b;    // Private: Başka bir class'tan erişilemez
            bool c;     // True || False
            string d;
            a = 1;      // a; 2, 3, 4, 100 gibi değerleri alabilir (tam sayı)
            b = 1.1f;
            c = true;
            d = "birden fazla karakter";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(123);
            Console.WriteLine(4.0m);
            Console.WriteLine(false);
            Console.ReadLine();
            break;
        }

        case 4:
        {
            // Deklerasyon|Değerlerde Problemler|Implicit Declaration: Tanımlama
            string benimAdim;               // String tanımı
            int tamSayi = 0;
            float ondalikUcBasamakliSayi;   // Camel case
            float OndalikSayi;              // Pascal case
            bool renkli;
            var tam = 10.1f;
            benimAdim = "Bora";
            Console.WriteLine(benimAdim);
            benimAdim = "Sevim";
            Console.WriteLine(benimAdim);
            Console.WriteLine(tamSayi);
            Console.WriteLine(tam);
            Console.ReadLine();
            break;
        }

        case 5:
        {
            // Implicit Declaration: Örnek
            // İzmir'de bomba yedim ve tanesi 5 liraydı ve hava sıcaklığı 25.5 dereceydi
            string sehir = "İzmir";
            int fiyat = 5;
            float sicaklik = 25.5f; // Decimal m Float f
            Console.Write(sehir);
            Console.Write("\'de bomba yedim ve tanesi ");
            Console.Write(fiyat);
            Console.Write(" liraydi ve hava sicakligi ");
            Console.Write(sicaklik);
            Console.Write(" dereceydi");
            Console.ReadLine();
            break;
        }

        case 6:
        {
            // Escape Character: Örnekler
            // \n \t \" \' \\ @ \u1234
            Console.WriteLine("Hello\nWorld"); 
            Console.WriteLine("Hello\tWorld"); 
            Console.WriteLine("\"Hello World\"");           // "Hello World"
            Console.WriteLine("C:\\Users\\Bora\\Appdata");  // C:\Users\Bora\Appdata
            Console.WriteLine(@"C:\Users\Bora\Appdata");
            Console.ReadLine();
            break;
        }

        case 7:
        {
            // String Concatenate|Interpolation
            string birinci = "Bora";
            string ikinci = "Google Certified Scholar " + birinci;
            string ucuncu = "Google Certified Scholar " + birinci + " " + "Sevim";
            string dorduncu = $"{birinci} {ikinci} elle yazi yaziyorum";
            string besinci = $@"C:\Users\Bora\{ikinci}\veri";
            Console.WriteLine(ucuncu);
            Console.WriteLine(dorduncu);
            Console.WriteLine(besinci);
            Console.ReadLine();
            break;
        }

        case 8:
        {
            // MODÜL 4: Sayısal Operasyonlar
            // Toplama
            int birinciSayi = 35;
            int ikinciSayi = 34;
            Console.WriteLine(birinciSayi + ikinciSayi + "bir string"); // 35 + 34
            Console.WriteLine(birinciSayi + "bir string" + ikinciSayi);
            Console.WriteLine(birinciSayi + "bir string" + ikinciSayi + 10);
            Console.WriteLine((birinciSayi + 10) + "bir string" + ikinciSayi + 10);
            Console.ReadLine();
            break;
        }

        case 9:
        {
            // Basit 4 İşlem
            break;
        }

        case 99:
        {
            Console.WriteLine("Programdan cikis yapildi.");
            loop = false;
            Console.ReadLine();
            break;
        }
        
        default:
        {
            Console.WriteLine("Yanlis deger girildi.");
            Console.ReadLine();
            break;
        }
    }
}while(loop);