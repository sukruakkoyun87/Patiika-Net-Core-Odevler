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
Calisan calisan1=new Calisan();
calisan1.Ad="Ayşe";
calisan1.Soyad="Kara";
calisan1.No=25425634;
calisan1.Departman="İnsan Kaynakları";

calisan1.CalisanBilgileri();

Console.WriteLine("**************************************");

Calisan calisan2=new Calisan();
calisan2.Ad="Deniz";
calisan2.Soyad="Arda";
calisan2.No=25646789;
calisan2.Departman="Satın Alma";

calisan2.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri(){

        Console.WriteLine($"Çalışanın Adı : {Ad}");
        Console.WriteLine($"Çalışanın Soyadı : {Soyad}");
        Console.WriteLine($"Çalışanın Numarası : {No}");
        Console.WriteLine($"Çalışanın Departmanı : {Departman}");

    }

}