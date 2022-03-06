public class PersonManager : IPersonService
{ 
    IPersonDal _personDal;

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
       return _personDal.Get(id);;
    }

    public List<Person> GetAll()
    {
        return _personDal.GetAll();
    }

    public Person GetbyFirstNameOrLastName(string firstNameOrLastName)
    {
        return _personDal.GetbyFirstNameOrLastName(firstNameOrLastName);
    }

    public Person GetbyPhoneNumber(string phoneNumber)
    {
        return _personDal.GetbyPhoneNumber(phoneNumber);
    }

    public void Update(Person person)
    {
        _personDal.Update(person);
    }
}