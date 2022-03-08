// See https://aka.ms/new-console-template for more information
ICardService _cardService = new CardManager(new CardMemoryDal());
IPersonService _personService = new PersonManager(new PersonMemoryDal());
IBoardService _boardService = new BoardManager(new BoardMemoryDal());

Islemler();

void Islemler()
{
    Console.WriteLine("Lütfen yapmak isteiğiniz işlemi seçiniz :)");
    Console.WriteLine("******************************************");
    Console.WriteLine("( 1 ) Board Listelemek ");
    Console.WriteLine("( 2 ) Board'a Kart Eklemek ");
    Console.WriteLine("( 3 ) Board'dan Kart Silmek ");
    Console.WriteLine("( 4 ) Kart Taşımak ");
    Console.WriteLine("( 5 ) Programdan Çıkış ");
    Console.Write(" : ");
    int secim = Convert.ToInt32(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Listele();
            break;
        case 2:
            AddtoCardBoard();
            break;
        case 3:
            DeleteCard();
            break;
        case 4:
            MoveCard();
            break;
        case 5:
            Environment.Exit(0);
            Console.WriteLine("Programdan Çıkılıyor...");
            break;
        default:
            Console.WriteLine("Geçersiz işlem...");
            break;
    }
}



void Listele()
{
    Console.WriteLine();
    int boardCount = _boardService.GetAll().Count;
    int cardCount = _cardService.GetAll().Count;
    for (int i = 1; i <= boardCount; i++)
    {
        int boardId = _boardService.GetAll().Where(x => x.BoardId == i).FirstOrDefault().BoardId;
        int cardId = _cardService.GetAll().Where(x => x.BoardId == boardId).FirstOrDefault().Id;

        Console.WriteLine($" {_boardService.GetAll().Where(x => x.BoardId == i).FirstOrDefault().BoardName.ToUpper()} Line");
        Console.WriteLine("********************************************");

        foreach (var item in _cardService.GetAll().Where(x => x.BoardId == boardId))
        {
            Console.WriteLine($"Başlık       : {item.Title}");
            Console.WriteLine($"İçerik       : {item.Description}");
            Console.WriteLine($"Büyüklük     : {item.Dimesion}");
            Console.WriteLine($"Atanan Kişi  : {_personService.GetAll().Where(x => x.PersonId == item.PersonId).FirstOrDefault().FirstName} {_personService.GetAll().Where(x => x.PersonId == item.PersonId).FirstOrDefault().LastName}");
            Console.WriteLine("-");
        }
    }

    Islemler();
}

void AddtoCardBoard()
{
    Console.Write("Başlık Giriniz                                 :  ");
    string title = Console.ReadLine();
    Console.Write("İçerik Giriniz                                 :  ");
    string description = Console.ReadLine();
    Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :  ");
    int dimesion =int.Parse(Console.ReadLine());
    Console.WriteLine("Atanan Kişi Seçiniz                            :  ");
    personList();
    Console.Write(" : ");
    int personId =int.Parse(Console.ReadLine());
    var personSelectedId=_personService.GetAll().Where(x => x.PersonId == personId).FirstOrDefault().PersonId;
    
    if (personSelectedId!=null)
    {

    _cardService.Add(new Card{Title=title,Description=description,Dimesion=(Dimesion)dimesion,PersonId=personSelectedId,BoardId=1});
    }
    else
    {
        Console.WriteLine("Hatalı girişler yaptınız!. Tekrar Deneyiniz");
        AddtoCardBoard();
    }
    
        
  Listele();
}

void personList()
{
   foreach (var item in _personService.GetAll())
   {
       Console.WriteLine($"{item.PersonId} - {item.FirstName} {item.LastName}");
   }
  
}

void DeleteCard()
{
    Console.WriteLine("Öncelikle Silmek istediğiniz kartı seçmeniz gerekiyor.");
    Console.Write("Lütfen kart başlığını  giriniz  : ");
    string title = Console.ReadLine();
    var cardName=_cardService.GetAll().Find(x => x.Title == title);

    if (title!=cardName.Title)
    {
         Console.WriteLine("Aradığınız kriterde uygun veri rehberde bulunamadı. Lütfen bir secim yapınız .");
        Console.WriteLine(" * Silmeyi sonlandirmak için : (1)");
        Console.WriteLine(" * Yeniden denemek için      : (2)");
        int secim = Convert.ToInt32(Console.ReadLine());
        switch (secim)
        {
            case 1:
                Islemler();
                break;
            case 2:
                DeleteCard();
                break;
            default:
                Console.WriteLine("Yanlış Seçim Yaptınız");
                DeleteCard();
                break;
        }
    }else
    {
        Console.WriteLine(" {0} isimli kart silinmek üzere,Onaylıyor musunuz (y/n) ?",cardName.Title);
        string onay = Console.ReadLine();

        if(onay.ToLower() == "y")
        {
                var silinecekCard=_cardService.GetAll().FirstOrDefault(x => x.Title == title);
                _cardService.Delete(silinecekCard);
        }else
        {
            DeleteCard();
        }
    }

    
    Listele();
}

void MoveCard()
{
    Console.WriteLine("Öncelikle Taşımak istediğiniz kartı seçmeniz gerekiyor.");
    Console.Write("Lütfen kart başlığını  giriniz  : ");
    string title = Console.ReadLine();
    var cardName=_cardService.GetAll().Find(x => x.Title == title);

    if (title!=cardName.Title)
    {
         Console.WriteLine("Aradığınız kriterde uygun veri rehberde bulunamadı. Lütfen bir secim yapınız .");
        Console.WriteLine(" * Taşıma işlemini sonlandirmak için : (1)");
        Console.WriteLine(" * Yeniden denemek için              : (2)");
        int secim = Convert.ToInt32(Console.ReadLine());
        switch (secim)
        {
            case 1:
                Islemler();
                break;
            case 2:
                MoveCard();
                break;
            default:
                Console.WriteLine("Yanlış Seçim Yaptınız");
                MoveCard();
                break;
        }
    }else
    {
        Console.WriteLine("Bulunan Kart Bilgileri  : ");
        Console.WriteLine("********************************************");
        foreach (var item in _cardService.GetAll().Where(x => x.Title == title))
        {
            Console.WriteLine($"Başlık       : {item.Title}");
            Console.WriteLine($"İçerik       : {item.Description}");
            Console.WriteLine($"Büyüklük     : {item.Dimesion}");
            Console.WriteLine($"Atanan Kişi  : {_personService.GetAll().Where(x => x.PersonId == item.PersonId).FirstOrDefault().FirstName} {_personService.GetAll().Where(x => x.PersonId == item.PersonId).FirstOrDefault().LastName}");
            Console.WriteLine($"Line         : {item.BoardId}");
           
        }


        Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz  : ");
        foreach (var item in _boardService.GetAll())
        {
            Console.WriteLine($"( {item.BoardId} )  -  {item.BoardName.ToUpper()}");
        }
        Console.Write(" : ");
        int boardId = Convert.ToInt32(Console.ReadLine());
        var card = _cardService.GetAll().FirstOrDefault(x => x.Title == title);
        var cardId = _cardService.GetAll().Where(x => x.Title == title).FirstOrDefault().Id;
        var cardBoardId = _cardService.GetAll().Where(x => x.Title == title).FirstOrDefault().BoardId;

        _cardService.Update(new Card{Id=cardId,Title=card.Title,Description=card.Description,Dimesion=card.Dimesion,PersonId=card.PersonId,BoardId=boardId});
}
Listele();
}