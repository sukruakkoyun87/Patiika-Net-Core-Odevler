// See https://aka.ms/new-console-template for more information


Console.Write("Pozitif bir sayı giriniz : ");
int n = Convert.ToInt32(Console.ReadLine());
string[] kelimeler = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Kelime giriniz : ");
    string kelime = Console.ReadLine();
    kelimeler[i] = kelime;

}

for (int i = kelimeler.Length-1; i >=0; i--)
{
    Console.Write(kelimeler[i]+" ");
}