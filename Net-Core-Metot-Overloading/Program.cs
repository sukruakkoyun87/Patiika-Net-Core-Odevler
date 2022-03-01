// See https://aka.ms/new-console-template for more information

// Out Parametreler
string sayi="999";


bool sonuc=int.TryParse(sayi,out int outSayi);

if (sonuc)
{
    Console.WriteLine("Başarılı");
    Console.WriteLine("Sayı: {0}", outSayi);
}
else
{
    Console.WriteLine("Sayı geçersiz");
}

Metotlar instance=new Metotlar();
instance.Toplam(2,4,out int result);
Console.WriteLine("Toplam: {0}",result);


// Metot Overloading Aşiri Yükleme


int ifade=999;
instance.EkranaYaz(ifade.ToString());
instance.EkranaYaz(ifade);
instance.EkranaYaz("Şükrü","Akkoyun");

// Metot imzası
// Metot Adı + Parametre sayisi + Parametrelerin tipi

class Metotlar
{
    public  void Toplam(int x,int y,out int toplam){

    toplam=x+y;

    }

    public void EkranaYaz(string veri){
        Console.WriteLine(veri);
    }

    public void EkranaYaz(int veri){
        Console.WriteLine(veri);
    }


    public void EkranaYaz(string veri,string veri2){
        Console.WriteLine(veri+veri2);
    }
}