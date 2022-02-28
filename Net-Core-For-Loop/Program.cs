// See https://aka.ms/new-console-template for more information


// Ekrandan girilen sayiya kadar olan tek sayilari ekrana yazdiran program

// Console.Write("Bir Sayi Giriniz : ");
// int sayac=Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < sayac; i++)
// {
//     if (i%2==1)
//     {
//         Console.WriteLine($"Sayı : {i}");
//     }
// }


// 1 ile 1000 arasindaki tek ve çift sayilarin toplamini ekrana yazdiran program
// int tekToplam=0,ciftToplam=0;


// for (int i = 1; i <=1000; i++)
// {
//     if (i%2==1)
//     {
//         tekToplam+=i;
//     }
//     else
//     {
//         ciftToplam+=i;
//     }
// }

// Console.WriteLine($"Tek Sayilarin Toplamı : {tekToplam}");
// Console.WriteLine($"Çift Sayilarin Toplamı : {ciftToplam}");


// break ve continue kullanımı

for (int i = 1; i < 10; i++)
{
    if(i==4)
    break;
    Console.WriteLine($"Sayi : {i}");
}

for (int i = 1; i < 10; i++)
{
    if (i==4)
    continue;

    Console.WriteLine($"Sayi : {i}");
}