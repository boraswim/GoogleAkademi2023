Console.WriteLine("Hello, World!"); // Bu bir yorum satırıdır. Bu fonksiyon konsolda "Hello World" yazılmasını sağlar.
Console.Write("Yenisatir");
Console.Write("DigerWrite");
Console.ReadLine();                 // VE && VEYA ||

Console.WriteLine("Bu bir satirdir");
Console.WriteLine("Bu da bir satirdir");
Console.Write("\nBu bir sonraki satirdir");
Console.Write("\nBu satir en alltadir");
Console.ReadLine();

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

// \n \t \" \' \\ @ \u1234
Console.WriteLine("Hello\nWorld"); 
Console.WriteLine("Hello\tWorld"); 
Console.WriteLine("\"Hello World\"");           // "Hello World"
Console.WriteLine("C:\\Users\\Bora\\Appdata");  // C:\Users\Bora\Appdata
Console.WriteLine(@"C:\Users\Bora\Appdata");
Console.ReadLine();

string birinci = "Bora";
string ikinci = "Google Certified Scholar " + birinci;
string ucuncu = "Google Certified Scholar " + birinci + " " + "Sevim";
string dorduncu = $"{birinci} {ikinci} elle yazi yaziyorum";
string besinci = $@"C:\Users\Bora\{ikinci}\veri";
Console.WriteLine(ucuncu);
Console.WriteLine(dorduncu);
Console.WriteLine(besinci);
Console.ReadLine();