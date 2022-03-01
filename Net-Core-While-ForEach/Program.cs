// See https://aka.ms/new-console-template for more information

 // While Dongusu

 // 1 den başlayarak  consoledan girilen sayı dahil ortlama hesaplama

 Console.Write("Sayı giriniz: ");
 int sayi=Convert.ToInt32(Console.ReadLine());

 int sayac=1;
 int toplam=0;

while (sayac<=sayi)
{
    toplam += sayac;
    sayac++;
}

Console.WriteLine("Ortalama: " + toplam/sayi);


// a dsn z ye kadar tum harfleri yazdırma

char character='a';

while (character<='z')
{
    Console.Write(character +" ");
    character++;

}

Console.WriteLine();

// Foreach dongusu

string[] arabalar={"Mercedes","BMW","Audi","Ferrari","Porsche"};


foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}
