public  class BoardMemoryDal:IBoardDal
{
    List<Board> _boards;

    public BoardMemoryDal()
    {
        _boards = new List<Board>{
            new Board{BoardId=1, BoardName="ToDo"},
            new Board{BoardId=2, BoardName="In Progress"},
            new Board{BoardId=3, BoardName="Done"},
        };
    }

    public void Add(Board board)
    {
        _boards.Add(board);
    }

    public void Delete(Board board)
    {
        Board boardToDelete = _boards.SingleOrDefault(x => x.BoardId == board.BoardId);
        _boards.Remove(boardToDelete);
    }

    public Board Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Board> GetAll()
    {
        return _boards;
    }

    public void Update(Board board)
    {
        Board boardToUpdate = _boards.SingleOrDefault(x => x.BoardId == board.BoardId);
        boardToUpdate.BoardName = board.BoardName;
    }
}