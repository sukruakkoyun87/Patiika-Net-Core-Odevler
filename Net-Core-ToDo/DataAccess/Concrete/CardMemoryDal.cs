

public class CardMemoryDal : ICardDal
{ 
   List<Card> _cards ;

    public CardMemoryDal()
    {
        _cards =new List<Card>{
            new Card{Id=1,Title="Card 1",Description="Card 1 Description",Dimesion=Dimesion.XS , PersonId=1 ,BoardId=1},
            new Card{Id=2,Title="Card 2",Description="Card 2 Description",Dimesion=Dimesion.S,PersonId=2, BoardId=1},
            new Card{Id=3,Title="Card 3",Description="Card 3 Description",Dimesion=Dimesion.M ,PersonId=3, BoardId=2},
            new Card{Id=4,Title="Card 4",Description="Card 4 Description",Dimesion=Dimesion.L,PersonId=1, BoardId=3},
        };
    }

 

    public void Add(Card card)
    {
        _cards.Add(card);
    }

    public void Delete(Card card)
    {
         Card cardtoDelete=_cards.SingleOrDefault(x => x.Id == card.Id);
        _cards.Remove(cardtoDelete);
    }

    public Card Get(int id)
    {
        return _cards.SingleOrDefault(c => c.Id == id);
    }

    public List<Card> GetAll()
    {
        return _cards;
    }

    public void Update(Card card)
    {
        Card cardToUpdate = _cards.SingleOrDefault(x => x.Id == card.Id);
        cardToUpdate.Title = card.Title;
        cardToUpdate.Description = card.Description;
       cardToUpdate.Dimesion = card.Dimesion;
       cardToUpdate.PersonId = card.PersonId;
         cardToUpdate.BoardId = card.BoardId;
    }
}