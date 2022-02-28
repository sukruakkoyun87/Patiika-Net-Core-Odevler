// See https://aka.ms/new-console-template for more information

int month=DateTime.Now.Month;


switch (month)
{
    case 1:
        Console.WriteLine("Ocak  ayındasınız");
        break;
    case 2:
        Console.WriteLine("Şubat ayındasınız");
        break;
    case 3:
        Console.WriteLine("Mart ayındasınız");
        break;
    case 4:
        Console.WriteLine("Nisan ayındasınız");
        break;
    case 5:
        Console.WriteLine("Mayıs");
        break;
    case 6:
        Console.WriteLine("Haziran");
        break;
    case 7:
        Console.WriteLine("Temmuz");
        break;
    case 8:
        Console.WriteLine("Ağustos");
        break;
    case 9:
        Console.WriteLine("Eyül");
        break;
    case 10:
        Console.WriteLine("Ekim");
        break;
    case 11:
        Console.WriteLine("Kasım");
        break;
    case 12:
        Console.WriteLine("Aralık");
        break;
    default:
        Console.WriteLine("Invalid month");
        break;

}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış ayındasınız");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Ilkbahar ayındasınız");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz ayındasınız");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar ayındasınız");
        break;

    default:
    break;
}
