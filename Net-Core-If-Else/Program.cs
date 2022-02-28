// See https://aka.ms/new-console-template for more information


//  If - If  Else - Else If

int time = DateTime.Now.Hour;

if (time >= 6 && time < 11)
{
    Console.WriteLine("Günaydın  :)");
}
else if (time <= 18)
{
    Console.WriteLine(" İyi günler :)");
}
else
{
    Console.WriteLine("İyi akşamlar :)");
}


// Ternary If

string message=time>=6 && time< 11?"Günaydın :)":time<=18?"İyi günler :)":"İyi akşamlar :)";

Console.WriteLine(message);


