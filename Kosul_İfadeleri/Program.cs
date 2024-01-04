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


string kullanıcıAdi = "root";
string sifre = "1010";

Console.WriteLine("Kullanıcı adini giriniz");
string username=Console.ReadLine();

Console.WriteLine("Şifrenizi giriniz");

string password = Console.ReadLine();

bool girisOk = username == kullanıcıAdi && sifre == password;

if (girisOk)
{

    Console.WriteLine("Giriş Başarılı");
}
else
{

    Console.WriteLine("Giriş Başarısız");
}
