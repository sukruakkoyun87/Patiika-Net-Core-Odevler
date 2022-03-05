// See https://aka.ms/new-console-template for more information
Console.WriteLine("Çalışan sayisi : {0}", Calisan.CalisanSayisi);

Calisan calisan1 = new Calisan("Ayşe","Yılmaz","IK");
Console.WriteLine("Çalışan sayisi : {0}", Calisan.CalisanSayisi);
Calisan calisan2 = new Calisan("Ayşe","Yılmaz","IK");
Calisan calisan3 = new Calisan("Ayşe","Yılmaz","IK");
Console.WriteLine("Çalışan sayisi : {0}", Calisan.CalisanSayisi);


Console.WriteLine("Toplama işleminin Sonucu : {0}", Islemler.Topla(100,200));
Console.WriteLine("Çıkarma işleminin Sonucu : {0}", Islemler.Çıkar(400,50));


class Calisan
{

    private static int calisanSayisi;
    public static int CalisanSayisi { get => calisanSayisi;  }

    private string Isim;
    private string Soyisim;
    private string Departman;

    public Calisan(string isim, string soyisim, string departman)
    {
        Isim = isim;
        Soyisim = soyisim;
        Departman = departman;
        calisanSayisi++;
    }

    static Calisan(){
    calisanSayisi=0;
    }

}

static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

       public static long Çıkar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
    
    
}