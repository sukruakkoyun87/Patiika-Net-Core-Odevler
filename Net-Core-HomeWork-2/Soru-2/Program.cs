// See https://aka.ms/new-console-template for more information
using System.Collections;


ArrayList list = new ArrayList() { 17, 23, 65, 50, 22, 67, 78, 7, 51, 48, 66, 85, 84, 28, 74, 44, 46, 11, 38, 80 };


// Console.Write("20 Adet Sayi Giriniz :");
// int N=Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < N; i++)
// {
//     Console.Write("Sayi Giriniz :");
//     int sayi=Convert.ToInt32(Console.ReadLine());
//     list.Add(sayi);
// }


Console.WriteLine("Girilen Sayilarin Listesi :");
foreach (var item in list)
{
    Console.Write(item + " ");
}

MaxNumber(list);
MinNumber(list);






static void MinNumber(ArrayList list)
{
    int[] smallNumbers = new int[3];
    list.Sort();
   int sum=0;
        for (int i = 0; i < 3; i++)
        {
            smallNumbers[i] = (int)list[i];
            sum += smallNumbers[i];
        }
   

    Console.WriteLine("En Kucuk Sayilar :");
    foreach (var item in smallNumbers)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
    Console.WriteLine("En Kucuk Sayi Ortalamasi :");
    decimal avg = sum /smallNumbers.Length ;
    Console.WriteLine($"Ortalama : {avg} ");


    Console.WriteLine();
}

static void MaxNumber(ArrayList list)
{
    int[] bigNumbers = new int[3];
    list.Sort();
    list.Reverse();
  int sum=0;
        for (int i = 0; i < 3; i++)
        {
            bigNumbers[i] =(int)list[i];
            sum += bigNumbers[i];
        }
  

    Console.WriteLine("En Buyuk Sayilar :");
    foreach (var item in bigNumbers)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
    Console.WriteLine("En Buyuk Sayi Ortalamasi :");
    decimal avg = sum /bigNumbers.Length ;
    Console.WriteLine($"Ortalama : {avg} ");


    Console.WriteLine();
}





