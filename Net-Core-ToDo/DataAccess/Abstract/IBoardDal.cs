public interface IBoardDal
{
    Board Get(int id);
    List<Board> GetAll();
    void Add(Board board);
    void Update(Board board);
    void Delete(Board board);
}