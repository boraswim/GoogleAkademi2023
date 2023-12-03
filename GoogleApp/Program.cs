using System;
namespace GoogleApp{
    class Program{
        static void Main(string[] args)
        {
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

            MODUL 4: Sayisal Operasyonlar
            8. Toplama
            9. Basit 4 Islem
            10. Operands: Operandlarla Islemler
            11. Sayi Operasyonlari

            MODUL 5: Class: Namespace Yapilari
            12. Class: Yeni Class Olusturma|Method: Class'a Fonksiyon Ekleme
            13. Math Class

            MODUL 6: Mantiksal Operasyonlar
            14. If- Else- Elseif

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
                        // () > Power > Çarpma ve bölme soldan sağa > Toplama ve çıkarma soldan sağa
                        int ilkSayi = 35;
                        int ikinciSayi = 34;
                        int toplama = 35 + 34;
                        int cikarma = 35 - 34;
                        int carpim = 35 * 34;
                        //int bolme = 35 / 34;
                        float bolme = 35f / 34;
                        int mod = ilkSayi % ikinciSayi;
                        float bolmeIkinci = (float)ilkSayi / ikinciSayi;
                        Console.WriteLine("Toplam " + toplama + "\nCikarma " + cikarma + "\nCarpim " + carpim + "\nBolme " + bolmeIkinci + "\nMod " + mod);
                        int ornek1 = 5 + 6 * 7;     // 5 + 42 > 47
                        int ornek2 = (5 + 6) * 5;   // 11 * 5 > 55
                        Console.WriteLine(ornek1);
                        Console.WriteLine(ornek2);
                        Console.ReadLine();
                        break;
                    }

                    case 10:
                    {
                        // Operands: Operandlarla İşlemler
                        int ilkSayi = 35;
                        int ucuncuSayi = ilkSayi + 5;   // 40
                        ucuncuSayi += 10;               // ucuncuSayi = ucuncuSayi + 10; 50
                        Console.WriteLine(ucuncuSayi);  
                        ucuncuSayi -= 10;               // 40
                        Console.WriteLine(ucuncuSayi);
                        ucuncuSayi *= 2;                // 40 * 2
                        Console.WriteLine(ucuncuSayi);
                        ucuncuSayi /= 5;                // 80 / 5
                        Console.WriteLine(ucuncuSayi);
                        int dorduncuSayi = 5;
                        dorduncuSayi++;                 // 5 + 1
                        Console.WriteLine(dorduncuSayi);
                        dorduncuSayi--;                 // 6 - 1
                        Console.WriteLine(dorduncuSayi);
                        ++dorduncuSayi;                 // 5 + 1
                        Console.WriteLine(dorduncuSayi);
                        Console.ReadLine();
                        break;
                    }

                    case 11:
                    {
                        // Sayı Operasyonları
                        // Santimetreden Inch'e çevirme
                        // Metrekareden Sqfeet'e çevirme
                        // 150cm olan bir ağacım 1000m^2 arazimde tek başına duruyor.
                        // 2.54cm = 1 inch
                        // 1sqfoot = 0.092903m^2 10.764
                        int agac = 150;
                        int alan = 1000;
                        Console.WriteLine((agac/2.54f) + "inch olan bir ağacım " + (alan * 10.764f) + "sqfeet arazimde tek başına duruyor");
                        Console.ReadLine();
                        break;
                    }

                    case 12:
                    {
                        // MODÜL 5: Class: Namespace Yapıları
                        // Class: Yeni Class Oluşturma|Method: Class'a Fonksiyon Ekleme
                        Yeni inst = new Yeni();
                        inst.birinci = 10;
                        inst.ikinci = 20;
                        Console.WriteLine(inst.birinci + inst.ikinci);
                        Console.WriteLine(inst.toplama());
                        Console.ReadLine();
                        break;
                    }

                    case 13:
                    {
                        // Math Class
                        // 10'un 2. kuvveti
                        // En küçük değer
                        // Mutlak değer
                        float bir = 10f;
                        float iki = 2f;
                        Console.WriteLine(Math.Pow(bir, iki));  // 100
                        Console.WriteLine(Math.Min(20,10));     // 10
                        Console.WriteLine(Math.Abs(-25.4f));    // 25.4
                        break;
                    }

                    case 14:
                    {
                        // 6. MODÜL: Mantıksal Operasonlar
                        // If- Else- Elseif 
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
        }
        class Yeni
        {
            public int birinci;
            public int ikinci;
            public int toplama()
            {
                return birinci + ikinci;
            }
        }
    }
}