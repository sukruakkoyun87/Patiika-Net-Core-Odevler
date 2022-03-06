// See https://aka.ms/new-console-template for more information

IPersonService _personService = new PersonManager(new PersonMemoryDal());
Islemler();

void Islemler()
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
    Console.WriteLine("*******************************************");
    Console.WriteLine("(1)  Yeni Numara Kaydetmek ");
    Console.WriteLine("(2)  Varolan Numarayı Silmek ");
    Console.WriteLine("(3)  Varolan Numarayı Güncellemek ");
    Console.WriteLine("(4)  Rehberi Listelemek ");
    Console.WriteLine("(5)  Rehberde Arama Yapmak ");
    Console.WriteLine("(6)  Programı Kapatmak ");
    Console.Write(" : ");

    int secim = Convert.ToInt32(Console.ReadLine());
    switch (secim)
    {
        case 1:
            YeniNumaraKaydet();
            break;
        case 2:
            NumaraSil();
            break;
        case 3:
            NumaraGuncelle();
            break;
        case 4:
            Listele();
            break;
        case 5:
            Arama();
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Yanlış Seçim Yaptınız");
            Islemler();
            break;

    }
}

void Arama()
{
    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz");
    Console.WriteLine("*******************************************");
    Console.WriteLine("İsim veya soyisime Göre Arama Yapmak  : (1) ");
    Console.WriteLine("Telefon Numarasına Göre Arama Yapmak  : (2) ");
    int secim = Convert.ToInt32(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Console.Write("Aranacak İsim veya Soyisim : ");
            string isim = Console.ReadLine();
            var sonuc = _personService.GetAll().Where(x => x.FirstName == isim || x.LastName == isim);
            if (sonuc != null)
            {
                Console.WriteLine("Arama Sonuçlarınız : ");
                Console.WriteLine("****************************************************");
                foreach (var item in sonuc)
                {
                    Console.WriteLine($"İsim     : {item.FirstName}");
                    Console.WriteLine($"Soyisim  : {item.LastName}");
                    Console.WriteLine($"Telefon  : {item.PhoneNumber}");
                    Console.WriteLine("-");
                }
                Console.WriteLine("----------------------------------------------------");
                Islemler();
            }
            else
            {
                Console.WriteLine("Aranan İsim veya Soyisim : " + isim + " Bulunamadı");
            }
            break;
        case 2:
            Console.WriteLine("Aranacak Telefon Numarası : ");
            string numara = Console.ReadLine();
            var person = _personService.GetbyPhoneNumber(numara);
            if (person != null)
            {
                Console.WriteLine("Arama Sonuçlarınız : ");
                Console.WriteLine("****************************************************");
                    Console.WriteLine($"İsim     : {person.FirstName}");
                    Console.WriteLine($"Soyisim  : {person.LastName}");
                    Console.WriteLine($"Telefon  : {person.PhoneNumber}");
                    Console.WriteLine("-");
                Console.WriteLine("----------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Aranan Telefon Numarası : " + numara + " Bulunamadı");
            }
            break;
        default:
            Console.WriteLine("Yanlış Seçim Yaptınız");
            Arama();
            break;
    }

}

void NumaraGuncelle()
{
    Console.WriteLine("Lütfen numarasını güncellemek istedğiniz kişinin Adını veya soyadını giriniz : ");
    string nameOrSurname = Console.ReadLine();
    var person = _personService.GetbyFirstNameOrLastName(nameOrSurname);
    if (nameOrSurname != person.FirstName && nameOrSurname != person.LastName)
    {
        Console.WriteLine("Aradığınız kriterde uygun veri rehberde bulunamadı. Lütfen bir secim yapınız .");
        Console.WriteLine(" * Güncellemeyi sonlandirmak için : (1)");
        Console.WriteLine(" * Yeniden denemel için           : (2)");
        int secim = Convert.ToInt32(Console.ReadLine());
        switch (secim)
        {
            case 1:
                Islemler();
                break;
            case 2:
                NumaraGuncelle();
                break;
            default:
                Console.WriteLine("Yanlış Seçim Yaptınız");
                NumaraGuncelle();
                break;
        }

    }
    else
    {

        Console.WriteLine("Hangisini güncellemek istiyorsunuz : ");
        Console.WriteLine("İsmini              : (1) ");
        Console.WriteLine("Soyismini           : (2) ");
        Console.WriteLine("Telefon Numarasını  : (3) ");
        int secim = Convert.ToInt32(Console.ReadLine());
        switch (secim)
        {
            case 1:
                Console.WriteLine("Lütfen yeni ismi giriniz : ");
                string newName = Console.ReadLine();
                person.FirstName = newName;
                _personService.Update(person);
                break;
            case 2:
                Console.WriteLine("Lütfen yeni soyismi giriniz : ");
                string newSurname = Console.ReadLine();
                person.LastName = newSurname;
                _personService.Update(person);
                break;
            case 3:
                Console.WriteLine("Lütfen yeni telefon numarası giriniz : ");
                string newPhoneNumber = Console.ReadLine();
                person.PhoneNumber = newPhoneNumber;
                _personService.Update(person);
                break;
            default:
                Console.WriteLine("Yanlış Seçim Yaptınız");
                NumaraGuncelle();
                break;
        }

    }

    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Güncelleme işlemi başarıyla tamamlandı.");
    Islemler();


}

async void NumaraSil()
{
    Console.Write("Lütfen numarasını silmek istedğiniz kişinin Adını veya soyadını giriniz : ");
    string nameOrSurname = Console.ReadLine();
    var person = _personService.GetbyFirstNameOrLastName(nameOrSurname);
    if (nameOrSurname != person.FirstName && nameOrSurname != person.LastName)
    {
        Console.WriteLine("Aradığınız kriterde uygun veri rehberde bulunamadı. Lütfen bir secim yapınız .");
        Console.WriteLine(" * Silmeyi sonlandirmak için : (1)");
        Console.WriteLine(" * Yeniden denemel için      : (2)");
        int secim = Convert.ToInt32(Console.ReadLine());
        switch (secim)
        {
            case 1:
                Islemler();
                break;
            case 2:
                NumaraSil();
                break;
            default:
                Console.WriteLine("Yanlış Seçim Yaptınız");
                NumaraSil();
                break;
        }

    }
    else
    {

        Console.Write("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? (y/n) : ", nameOrSurname);
        string onay = Console.ReadLine();
        if (onay == "y")
        {
            var silinecekPerson = _personService.GetAll().FirstOrDefault(x => x.Id == person.Id);
            _personService.Delete(silinecekPerson);
            Console.WriteLine("{0} isimli kişi rehberden silinmiştir.", nameOrSurname);
        }
        else
        {
            NumaraSil();
        }

    }
        Console.WriteLine("----------------------------------------------------");
        Islemler();

}

void Listele()
{
    Console.WriteLine("Telefon Rehberi");
    Console.WriteLine("****************************************************");
    foreach (var item in _personService.GetAll())
    {
        Console.WriteLine($"İsim     : {item.FirstName}");
        Console.WriteLine($"Soyisim  : {item.LastName}");
        Console.WriteLine($"Telefon  : {item.PhoneNumber}");
        Console.WriteLine("-");
    }
    Console.WriteLine("----------------------------------------------------");

    Islemler();
}

void YeniNumaraKaydet()
{
    Console.Write("Lütfen ismi giriniz             : ");
    string ismi = Console.ReadLine();
    Console.Write("Lütfen soyismi giriniz          : ");
    string soyismi = Console.ReadLine();
    Console.Write("Lütfen telefon numarası giriniz : ");
    string telefon = Console.ReadLine();

    Person person = new Person { FirstName = ismi, LastName = soyismi, PhoneNumber = telefon };
    _personService.Add(person);
    Console.WriteLine("-------------------------------");
    Islemler();
}