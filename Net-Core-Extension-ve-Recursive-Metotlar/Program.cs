// See https://aka.ms/new-console-template for more information


    // Recursive = Özyinelemeli Fonksiyonlar
    // 3 ^4=81

int result=1;
for (int i = 1; i < 5; i++)
{
    result=result*3;
}
Console.WriteLine(result);

Islemler  islem=new();
Console.WriteLine(islem.Expo(3,4));

// Extension Metotlar
string str="Şükrü Akkoyun";
bool sonuc=str.CheckSpaces();
string str2=str.RemoveWhiteSpaces();

Console.WriteLine(sonuc);
Console.WriteLine(str2);
Console.WriteLine(str2.MakeUpperCase());
Console.WriteLine(str2.MakeLowerCase());
int[] dizi={9,3,6,2,1,5,0};
dizi.SortArray();
dizi.EkranaYazdir();

int sayi=5;

Console.WriteLine(sayi.isEvenNumber());
Console.WriteLine(str.GetFirstCharacter());


class Islemler{

    public int Expo(int sayi,int us){

        if(us <2){
            return sayi;
        }

        return Expo(sayi,us-1)*sayi;
        /*
        Expo(3,4)
        Expo(3,3)*3
        Expo(3,2)*3*3
        Expo(3,1)*3*3*3
        3*3*3*3=3^4=81

        */
    }
}


public static class Extension
{

    public static bool CheckSpaces(this string param){
        return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param){
        string[] words=param.Split(' ');
        return string.Join("",words);
    }

    public static string MakeUpperCase(this string param){
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param){
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param){
        Array.Sort(param);
        return param;
    }

    public  static void EkranaYazdir(this int[] param){
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool isEvenNumber(this int param){
        return param%2==0;
    }
    public static string GetFirstCharacter(this string param){
        return param.Substring(0,1);
    }
}