// See https://aka.ms/new-console-template for more information

/*
    Söz Dizimi :
        class SinifAdi
        {
            [Erişim Belirleyici] [Veri Tipi] Özellik Adi;

            [Erişim Belirleyici] [Geri Dönüş Tipi] Metot Adi ([Parametre Listesi])
            {
                Metot Komutları
            }
        }
*/

/*
    Erişim Belirleyiciler :
    * public: herkes erişebilir.
    * private: sadece sınıf içinde erişebilir.
    * protected: sadece sınıf ve alt sınıflar içinde erişebilir.
    * internal: sadece sınıf içinde erişebilir.
*/

Console.WriteLine("********** Çalışan 1 ***********");

Calisan calisan1=new Calisan("Ayşe","Kara",25425634,"İnsan Kaynakları");
calisan1.CalisanBilgileri();

Console.WriteLine("********** Çalışan 2 ***********");

Calisan calisan2=new Calisan();
calisan2.Ad="Deniz";
calisan2.Soyad="Arda";
calisan2.No=25646789;
calisan2.Departman="Satın Alma";

calisan2.CalisanBilgileri();
Console.WriteLine("********** Çalışan 3 ***********");

Calisan calisan3=new Calisan("Şükrü","Akkoyun");
calisan3.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan()
    {
    }
   public Calisan(string ad ,string soyad)
    {
        Ad=ad;
        Soyad=soyad;
    
    }

    
    public Calisan(string ad ,string soyad,int no,string departman)
    {
        Ad=ad;
        Soyad=soyad;
        No=no;
        Departman=departman;
    }
    
    public void CalisanBilgileri(){

        Console.WriteLine($"Çalışanın Adı : {Ad}");
        Console.WriteLine($"Çalışanın Soyadı : {Soyad}");
        Console.WriteLine($"Çalışanın Numarası : {No}");
        Console.WriteLine($"Çalışanın Departmanı : {Departman}");

    }

}