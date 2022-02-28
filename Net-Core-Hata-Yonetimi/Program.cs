// See https://aka.ms/new-console-template for more information

// try
// {
//     Console.Write("Bir Sayi Giriniz: ");
// int sayi = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Girdiginiz Sayi: " + sayi);
// }
// catch (Exception e)
// {
//     Console.WriteLine("Hata: " + e.Message);
// }
// finally
// {
//     Console.WriteLine("Islem Tamamlandı ...");

// }


try
{
    // int a=int.Parse(null);
    //int a = int.Parse("test");
    int b=int.Parse("-20000000000");

}
catch (ArgumentNullException e )
{
    
    Console.WriteLine("Boş Değer girdiniz : " + e.Message);
    Console.WriteLine(e);
}
catch(FormatException e){
    Console.WriteLine("Hatalı Biçimde Değer Girdiniz : " + e.Message);
    Console.WriteLine(e);
}
catch(OverflowException e){
    Console.WriteLine("Değer Çok Büyük veya Değer Çok Küçük : " + e.Message);
    Console.WriteLine(e);
}finally
{
    Console.WriteLine("Islem Tamamlandı ...");
}