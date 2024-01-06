//
// koşul  bazı şartlar olduğunda, belirli kodların çalıştırılmasına denir.

//int sayi = 10;
//int sayi2 = 11;

//bool isok = sayi < sayi2;

//if (isok)
//{
//  Console.WriteLine("sayi 2 sayi 1 den büyük");

//}
//Console.ReadLine();


//string kullanıcıAdi = "root";
//string sifre = "1010";

//Console.WriteLine("Kullanıcı adini giriniz");
//string username=Console.ReadLine();

//Console.WriteLine("Şifrenizi giriniz");

//string password = Console.ReadLine();

//bool girisOk = username == kullanıcıAdi && sifre == password;


// koşul ifadelerinde, derleyici bool değere göre hareket eder.
//// her koşul true ise, if bloğu false ise else bloğu çalışır.
//if (girisOk)
//{

//    Console.WriteLine("Giriş Başarılı");
//    int a = 10;
//}
//else
//{

//    Console.WriteLine("Giriş Başarısız");
//}


//// koşulların içerisinde tek satır kod yazacaksanız, süslü parantezleri yazmanıza gerek kalmaz
//if(girisOk)
//    Console.WriteLine("Giriş Başarılı");
//else
//    Console.WriteLine("Giriş Başarısız");



//Ekrandan aldığımız not  değeri 50'nin üstünde ise ekrana geçer not yazsın
// 50'nin altında ise ekrana kalır not yazsın

//Console.WriteLine("Lütfen not giriniz");
//string stringNot = Console.ReadLine();

//int not = Convert.ToInt32(stringNot);

//bool isOk = not >= 50;
//if (isOk)
//    Console.WriteLine("Geçer");
//else
//    Console.WriteLine("Kaldı");



// Ekrandan aldığımız bir rakamın tek sayı mı yoksa çift sayımı olduğunu tespit edip ekrana yazan bir uygulama yapınız

Console.WriteLine("Bir sayı gir");

int not = Convert.ToInt32(Console.ReadLine());



// uzun yol

//int mod = not % 2;

//bool ciftmi = mod == 0;

//if (ciftmi)
//    Console.WriteLine("çift");
//else
//    Console.WriteLine("Tek");

// kısa yol

//if (not % 2 == 0)
//    Console.WriteLine("çift");
//else Console.WriteLine("tek");



// ekrandan aldığınız sayı pozitif bir sayı ise ekrana pozitif negatif bir sayı ise negatif yazınız

Console.WriteLine("Bir sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi >= 0)
{
    Console.WriteLine("Pozitif");
}
else
{
    Console.WriteLine("Negatif");
}


// Ekrandan iki adet sayı alınız!!
// Birinci sayı ikinci sayıya tam bölünüyor mu ? 

Console.WriteLine("Birinci sayıyı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

if (sayi % sayi2 == 0)
{
    Console.WriteLine("bölündü");
}
else {

    Console.WriteLine("bölünmedi");
}
    