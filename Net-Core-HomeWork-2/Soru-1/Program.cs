// See https://aka.ms/new-console-template for more information

using System.Collections;
ArrayList list = new ArrayList();
ArrayList prime = new ArrayList();
ArrayList notPrime = new ArrayList();

Console.Write("20 Adet Pozitif Sayi Giriniz : ");
int N = Convert.ToInt32(Console.ReadLine());


try
{
    for (int i = 0; i < N; i++)
    {
        Console.Write("Sayi Girin : ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi < 0)
        {
            Console.WriteLine("Negatif Sayi Girdiniz , Lütfen Pozitif Bir Sayi Giriniz");
            i--;
            continue;
        }

        list.Add(sayi);

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


foreach (int item in list)
{
    int sayi = item;
    int sayac = 0;
    for (int i = 1; i <= sayi; i++)
    {
        if (sayi % i == 0)
        {
            sayac++;
        }
    }
    if (sayac == 2)
    {
        prime.Add(sayi);
    }
    else
    {
        notPrime.Add(sayi);
    }
}


Console.WriteLine("Asal Sayıların Listesi : ");
ListedSort(prime);
Console.WriteLine("Asal Sayıların Eleman Listesi ve Ortalaması : ");
ListedAvarage(prime);

Console.WriteLine("===================================================");

Console.WriteLine("Asal Olmayan Sayıların Listesi : ");
ListedSort(notPrime);
Console.WriteLine("Asal Olmayan Sayıların Eleman Listesi ve Ortalaması : ");
ListedAvarage(notPrime);








static void  ListedSort(ArrayList list)
{
    list.Sort();
    list.Reverse();

    foreach (var item in list)
    {
        Console.Write(item+" ");
    }
    Console.WriteLine();
}

static void ListedAvarage(ArrayList list)
{
    int toplam = 0;
    foreach (var item in list)
    {
        toplam +=(int)item;
    }
decimal avg= toplam / list.Count;
    Console.WriteLine($" Eleman Sayisi : {list.Count}  Ortalama : {avg}  ");
}