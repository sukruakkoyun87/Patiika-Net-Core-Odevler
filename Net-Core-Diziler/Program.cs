// See https://aka.ms/new-console-template for more information


string[] renkler=new string[5];

string[] hayvanlar={"kedi","kopek","kuş","maymun"};

int[] dizi;

dizi=new int[5];


// Deger Atama ve Erişim

renkler[0]="mavi";

dizi[3]=10;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);


// Dongulerle Dizi : For, Foreach, While
// Klavyeden girilen n kadar sayıyı ortalamasını alan program

Console.Write("Lütfen dizinin eleman sayısını giriniz : ");
int uzunluk=Convert.ToInt32(Console.ReadLine());

int[] sayiDizisi=new int[uzunluk];

for (int i = 0; i < uzunluk; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz : ",i+1);
    sayiDizisi[i]=Convert.ToInt32(Console.ReadLine());
}

int toplam=0;
foreach (var item in sayiDizisi)
{
    toplam+=item;
}
Console.WriteLine("Ortalama : {0}",toplam/sayiDizisi.Length);




