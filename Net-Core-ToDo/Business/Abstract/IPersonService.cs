
public interface IPersonService
{
    Person Get(int id);
    List<Person> GetAll();
    void Add(Person person);
    void Update(Person person);
    void Delete(Person person);
}
