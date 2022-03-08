
public class Card:IEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int PersonId { get; set; }
    public int BoardId { get; set; }
    public Enum Dimesion { get; set; }
}