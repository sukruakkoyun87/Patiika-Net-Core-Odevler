// See https://aka.ms/new-console-template for more information



Console.Write("Pozitif bir sayı giriniz: ");
int n=Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("Sayi giriniz : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi % 2 == 0)
    {
        Console.WriteLine("Sayı çift");
    }
    
}