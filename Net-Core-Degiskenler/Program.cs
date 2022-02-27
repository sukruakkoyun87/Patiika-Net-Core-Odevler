// See https://aka.ms/new-console-template for more information
 byte b=5;            //  1 byte 0 ile 255 arasında değer alır
 sbyte sb=5;          //  1 byte -128 ile 127 arasında değer alır

 short s=5;           //  2 byte -32768 ile 32767 arasında değer alır  ( INT16 )
 ushort us=5;         //  2 byte 0 ile 65535 arasında değer alır ( UINT16 )

 int i=5;             //  4 byte -2147483648 ile 2147483647 arasında değer alır ( INT32 )
 uint ui=5;           //  4 byte 0 ile 4294967295 arasında değer alır  ( INT32  )
 nuint nui=5;         //  4 byte 0 ile 4294967295 arasında değer alır ve platform bağımsızdır

 long l=5;            //  8 byte -9223372036854775808 ile 9223372036854775807 arasında değer alır ( INT64 )
 ulong ul=5;          //  8 byte 0 ile 18446744073709551615 arasında değer alır ( INT64 )


// Kayan Noktalı Sayılar
float f=5.5f;        //  4 byte 0 ile 3.4E+38 arasında değer alır
double d=5.5;        //  8 byte 0 ile 1.7E+308 arasında değer alır
decimal dec=5.5m;    //  16 byte 0 ile 79228162514264337593543950335 arasında değer alır



char c='a';          //  2 byte karakterler için kullanılır
string str="a";      //  16 byte karakterler için kullanılır


bool b1=true;        //  1 byte true false değerleri için kullanılır
bool b2=false;       //  1 byte true false değerleri için kullanılır

//Tarih ve Saat Bilgileri
DateTime dt=DateTime.Now; //  8 byte tarih ve saat bilgisi için kullanılır

Console.WriteLine($"DateTime.Now : {dt}");

object obj="x";            //  8 byte tüm değerler için kullanılır
object obj2="string";      //  8 byte tüm değerler için kullanılır
object obj3=5;             //  8 byte tüm değerler için kullanılır
object obj4=5.5;           //  8 byte tüm değerler için kullanılır

// Degisken Tanımlamaları

// string Tanımlamaları
string str2=string.Empty;
str2="Şükrü Akkoyun";
string firstName="Şükrü";
string lastName="Akkoyun";
string fullName=firstName+" "+lastName;
string fullName2=string.Format("{0} {1}",firstName,lastName);
string fullName3=$"{firstName} {lastName}";


// int Tanımlamaları

int sayi=5;
int sayi2=3;
int toplam=sayi*sayi2;

// bool Tanımlamaları
bool isTrue=10<2; // false
bool isTrue2=10>2; // true

// Tür Dönüşümleri

string strSayi="20";
int intSayi=20;
string newValue=strSayi+intSayi.ToString();  // stringe int değerini ekleme
Console.WriteLine($"stringe int değerini ekleme : {newValue}");


int value=intSayi+Convert.ToInt32(strSayi);  // Convert.ToInt32(strSayi) ile intSayi değerini stringe çevirir
Console.WriteLine($"Convert.ToInt32(strSayi) : {value}");

int value2=int.Parse(strSayi)+intSayi; // int.Parse() metodu string değerini int değere dönüştürür
Console.WriteLine($"int.Parse() : {value2}");



// DateTime Dönüşümleri
string tarih=DateTime.Now.ToShortDateString();
Console.WriteLine($"DateTime.Now.ToShortDateString() : {tarih}");

string tarih2=DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine($"DateTime.Now.ToString(\"dd.MM.yyyy\") : {tarih2}");

string saat=DateTime.Now.ToString("HH:mm");
Console.WriteLine($"DateTime.Now.ToString(\"HH:mm\") : {saat}");

string saat2=DateTime.Now.ToShortTimeString();
Console.WriteLine($"DateTime.Now.Hour.ToString() : {saat2}");

