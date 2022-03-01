// See https://aka.ms/new-console-template for more information

//erişim berliteci geri dönüş tipi metod Adı ( parametre Listesi/ arguman) 
//{
//          Komutları
//          return ;
//  }


int a=2;
int b=3;

Console.WriteLine(a+b);

int result=Topla(a,b);
Console.WriteLine(result);

Metotlar ornek=new Metotlar();
ornek.EkranaYazdir(result.ToString());


int result2=ornek.ArttirVeTopla2(ref a,ref b);
ornek.EkranaYazdir(result2.ToString());


// Metot Tanımı Topla Recursive
static int Topla(int x,int y){

    return x+y;
}


// Metot Kullanımı Sınıf İçinde 
class Metotlar
{
    public  void EkranaYazdir(string veri)
    {
        Console.WriteLine($"Sonuç : {veri}");
    }

    public int ArttirVeTopla(int x,int y){
        x++;
        y++;
        return x+y;
    }

    public int ArttirVeTopla2(ref int x ,ref int y){
        x+=1;
        y+=1;

        return x+y;

    }
}