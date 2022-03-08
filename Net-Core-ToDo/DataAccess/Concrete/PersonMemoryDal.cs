
public class PersonMemoryDal : IPersonDal
{
    List<Person> _persons ;

    public PersonMemoryDal()
    {
        _persons = new List<Person>{
            new Person{PersonId=1, FirstName="John", LastName="Doe"},
            new Person{PersonId=2, FirstName="Jane", LastName="Doe"},
            new Person{PersonId=3, FirstName="Joe", LastName="Doe"},
        };
    }

    public void Add(Person person)
    {
        _persons.Add(person);
    }

    public void Delete(Person person)
    {
        Person persontoDelete=_persons.SingleOrDefault(x => x.PersonId == person.PersonId);
        _persons.Remove(persontoDelete);
    }

    public Person Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Person> GetAll()
    {
        return _persons;
    }

    public void Update(Person person)
    {
        Person personToUpdate = _persons.SingleOrDefault(x => x.PersonId == person.PersonId);
        personToUpdate.FirstName = person.FirstName;
        personToUpdate.LastName = person.LastName;
   
    }
}