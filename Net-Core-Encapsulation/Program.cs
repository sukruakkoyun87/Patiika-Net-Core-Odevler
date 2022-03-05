// See https://aka.ms/new-console-template for more information

Ogrenci ogrenci = new Ogrenci();
ogrenci.Isim = "Ayşe";
ogrenci.Soyisim = "Yılmaz";
ogrenci.OgrenciNo = 293;
ogrenci.Sinif = 3;

ogrenci.OgrenciListesi();
ogrenci.SinifAtlat();
ogrenci.OgrenciListesi();

Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",256,1);



ogrenci2.SinifDüsür();
ogrenci2.SinifDüsür();
ogrenci2.OgrenciListesi();

class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif
    {
        get => sinif;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf 1'den küçük olamaz");
                sinif = 1;
            }else
            {
                sinif = value;
            }
        }

    }

    public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public Ogrenci()
    {
    }

    public void OgrenciListesi()
    {

        Console.WriteLine("************** Ögrenci Bilgileri ****************");
        Console.WriteLine("Ögrenci Adı     : {0}", Isim);
        Console.WriteLine("Ögrenci Soyadı  : {0}", soyisim);
        Console.WriteLine("Ögrenci No      : {0}", ogrenciNo);
        Console.WriteLine("Ögrenci Sınıfı  : {0}", sinif);
    }

    public void SinifAtlat()
    {
        Sinif = Sinif + 1;
    }
    public void SinifDüsür()
    {

        Sinif = Sinif - 1;
    }
}