// See https://aka.ms/new-console-template for more information

int sicaklik=32;
Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);



if (sicaklik<=(int)HavaDurumu.Normal)
{
    Console.WriteLine("Dişariya cıkamak için havanin biraz daha isinmasini bekleyin");
}
else if(sicaklik>=(int)HavaDurumu.Sicak)
{
    Console.WriteLine("Dişariya çıkmak için cok sicak bir gun");
}else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSicak)
{
    Console.WriteLine("Hadi dişariy cikalim");
}



enum Gunler
{
    Pazartesi=1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk=5,
    Normal=20,

    Sicak=25,

    CokSicak=30

}
