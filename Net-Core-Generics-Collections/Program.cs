﻿// See https://aka.ms/new-console-template for more information


// List<T> class
// System.Collections.Generic
// T -> object Türündedir 
List<int> sayiListesi=new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);


List<string> reskListesi =new List<string>();
reskListesi.Add("Kırmızı");
reskListesi.Add("Mavi");
reskListesi.Add("Turuncu");
reskListesi.Add("Sarı");
reskListesi.Add("Yeşil");

// Count

Console.WriteLine(reskListesi.Count);
Console.WriteLine(sayiListesi.Count);

// Foreach ve list.foreach ile elemanlara erişim

foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}


foreach (var renk in reskListesi)
{
    Console.WriteLine(renk);
}

sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
reskListesi.ForEach(renk=>Console.WriteLine(renk));

// Listeden Eleman Çıkarma
sayiListesi.Remove(4);
reskListesi.Remove("Yeşil");

sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
reskListesi.ForEach(renk=>Console.WriteLine(renk));

sayiListesi.RemoveAt(0);
reskListesi.RemoveAt(1);


sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
reskListesi.ForEach(renk=>Console.WriteLine(renk));


// Liste içderisinde arama

if (sayiListesi.Contains(10))
Console.WriteLine("10 Liste içerisinde bulundu");


// Eleman ile index'e erişme

Console.WriteLine(reskListesi.BinarySearch("Turuncu"));


// Diziyi List'e Çevirme

string[] hayvanlar={"Kedi","Kopek","Kuş"};


List<string> hayvanListesi=new List<string>(hayvanlar);


// Listeyi NasılTemizlerim

hayvanListesi.Clear();

// List içerisinde class tutma

List<Kullanicilar> kullaniciListesi=new List<Kullanicilar>();
Kullanicilar kullanici1=new Kullanicilar();
kullanici1.Isim="Ayşe";
kullanici1.Soyisim="Yılmaz";
kullanici1.Yas=26;

Kullanicilar kullanici2=new Kullanicilar();
kullanici2.Isim="Özcan";
kullanici2.Soyisim="Çalışkan";
kullanici2.Yas=26;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);


List<Kullanicilar> yeniListe=new List<Kullanicilar>();
yeniListe.Add(new Kullanicilar{
   Isim="Deniz",
   Soyisim="Arda",
    Yas=24
});


foreach (Kullanicilar kullanici in kullaniciListesi)
{
    Console.WriteLine($" Kullanıcı Adı : {kullanici.Isim}");
    Console.WriteLine($" Kullanıcı Soyadı : {kullanici.Soyisim}");
    Console.WriteLine($" Kullanıcı Yaş  : {kullanici.Yas}");
}


yeniListe.Clear();

class Kullanicilar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}


