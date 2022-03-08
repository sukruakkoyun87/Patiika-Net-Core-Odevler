public class BoardManager:IBoardService
{
    IBoardDal _boardDal;

    public BoardManager(IBoardDal boardDal)
    {
        _boardDal = boardDal;
    }

    public void Add(Board board)
    {
        _boardDal.Add(board);
    }

    public void Delete(Board board)
    {
        _boardDal.Delete(board);
    }

    public Board Get(int id)
    {
        return _boardDal.Get(id);
    }

    public List<Board> GetAll()
    {
        return _boardDal.GetAll();
    }

    public void Update(Board board)
    {
        _boardDal.Update(board);
    }
}