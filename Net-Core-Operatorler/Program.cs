// See https://aka.ms/new-console-template for more information
 Console.WriteLine("Atama ve işlemli atama işlemleri");
// Atama ve işlemli atama işlemleri

int x=3;
int y=3;
y=y+2;
Console.WriteLine( $"y=y+2: {y}");
y+=2;
Console.WriteLine( $"y+=2: {y}");
y/=1;
Console.WriteLine( $"y/=3: {y}");
x*=2;
Console.WriteLine( $"x*=3: {x}");


Console.WriteLine("Mantıksal Operatörler ve İfadeler");
// Mantıksal Operatörler ve İfadeler
// || ,&& ,!

bool isSuccess=true;
bool isCompleted=false;

if (isSuccess && isCompleted)  // true && true = true  // true && false = false
    Console.WriteLine("Perfect");

if (isSuccess || isCompleted) // true || false = true  // false || false = false
    Console.WriteLine("Great");

if (isSuccess && !isCompleted)   
    Console.WriteLine("Fine !!");



Console.WriteLine("ilişkisel Opreatorler ve İfadeler");
// ilişkisel Opreatorler ve İfadeler
// == , != , > , < , >= , <=

int sayi1=3;
int sayi2=4;
bool sonuc=sayi1<sayi2;
Console.WriteLine( $"{sayi1} < {sayi2} = {sonuc}");
sonuc=sayi1>sayi2;
Console.WriteLine( $"{sayi1}  {sayi2} = {sonuc}");
sonuc=sayi1<=sayi2;
Console.WriteLine( $"{sayi1} <= {sayi2} = {sonuc}");
sonuc=sayi1>=sayi2;
Console.WriteLine( $"{sayi1} >= {sayi2} = {sonuc}");
sonuc=sayi1==sayi2;
Console.WriteLine( $"{sayi1} == {sayi2} = {sonuc}");
sonuc=sayi1!=sayi2;
Console.WriteLine( $"{sayi1} != {sayi2} = {sonuc}");

Console.WriteLine("Aritmetik Operatörler");
// Aritmetik Operatörler
// + , - , * , / , % , ++ , --

int sayi3=21;
int sayi4=5;
int sonuc2=sayi3+sayi4;
Console.WriteLine( $"{sayi3} + {sayi4} = {sonuc2}");
sonuc2=sayi3-sayi4;
Console.WriteLine( $"{sayi3} - {sayi4} = {sonuc2}");
sonuc2=sayi3*sayi4;
Console.WriteLine( $"{sayi3} * {sayi4} = {sonuc2}");
sonuc2=sayi3/sayi4;
Console.WriteLine( $"{sayi3} / {sayi4} = {sonuc2}");
sonuc2=sayi3%sayi4;
Console.WriteLine( $"{sayi3} % {sayi4} = {sonuc2}");
sayi3++;
Console.WriteLine( $"sayi3 ++ {sayi3}  ");
sayi3--;
Console.WriteLine( $"sayi3 -- {sayi3} ");

