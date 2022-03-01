// See https://aka.ms/new-console-template for more information


Console.Write("1. Pozitif sayiyi giriniz : ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("2. Pozitif sayiyi giriniz : ");
int m=Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("Sayi giriniz : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi % 2 == 0 || sayi  == m)
    {
        Console.WriteLine($" {sayi} sayi çift veya {m} sayi");
    }
    
}

