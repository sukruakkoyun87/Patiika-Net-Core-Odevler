// See https://aka.ms/new-console-template for more information
Console.Write("Bir cümle giriniz: ");
string cumle = Console.ReadLine();

string[] kelimeler = cumle.Split(' ');
int kelimeSayac=0, harfSayac=0;

foreach (string kelime in kelimeler)
{
    kelimeSayac++;
}
char[] harfler = cumle.ToCharArray();
foreach (char harf in harfler)
{
    if (harf != ' ')
    {
        harfSayac++;
    }
}

Console.WriteLine("Cümlede {0} kelime bulunmaktadır.", kelimeSayac);
Console.WriteLine("Cümlede {0} harf bulunmaktadır.", harfSayac);



