public class PersonManager:IPersonService
{
    private IPersonDal _personDal;
    public PersonManager(IPersonDal personDal)
    {
        _personDal = personDal;
    }
    public void Add(Person person)
    {
        _personDal.Add(person);
    }

    public void Delete(Person person)
    {
        _personDal.Delete(person);
    }

    public Person Get(int id)
    {
        return _personDal.Get(id);
    }

    public List<Person> GetAll()
    {
        return _personDal.GetAll();
    }

    public void Update(Person person)
    {
        _personDal.Update(person);
    }
}
