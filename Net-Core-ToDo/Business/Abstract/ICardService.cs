public interface ICardService
{
    Card Get(int id);
    List<Card> GetAll();
    void Add(Card card);
    void Update(Card card);
    void Delete(Card card);
}
