
public class PersonMemoryDal : IPersonDal
{
    private List<Person> _persons;

    public PersonMemoryDal()
    {
        _persons = new List<Person>{
            new Person{Id=1, FirstName="Can", LastName="Güney", PhoneNumber="0555555555"},
            new Person{Id=2, FirstName="Ali", LastName="Kaya", PhoneNumber="0544444444"},
            new Person{Id=3, FirstName="Ahmet", LastName="Kaya", PhoneNumber="0533333333"},
            new Person{Id=4, FirstName="Mehmet", LastName="Kaya", PhoneNumber="0522222222"},
            new Person{Id=5, FirstName="Ayşe", LastName="Kaya", PhoneNumber="0511111111"},
            new Person{Id=6, FirstName="Fatma", LastName="Kaya", PhoneNumber="0500000000"},
            new Person{Id=7, FirstName="Seda", LastName="Kaya", PhoneNumber="0599999999"},
            new Person{Id=8, FirstName="Seda", LastName="Kaya", PhoneNumber="0599999999"},
        };
    }

    public void Add(Person person)
    {
        _persons.Add(person);
        Console.WriteLine("{0} adlı kişi rehbere eklendi.", person.FirstName);
    }

    public void Delete(Person person)
    {
        Person persontoDelete=_persons.SingleOrDefault(x => x.Id == person.Id);
        _persons.Remove(persontoDelete);
        Console.Write(person.FirstName +" ");
    }

    public Person Get(int id)
    {
        return _persons.SingleOrDefault(x => x.Id == id);
    }

    public List<Person> GetAll()
    {
        return _persons;
    }

    public Person GetbyFirstNameOrLastName(string firstNameOrLastName)
    {
        return _persons.Find(x => x.FirstName == firstNameOrLastName || x.LastName == firstNameOrLastName);
    }
    public Person GetbyPhoneNumber(string phoneNumber)
    {
        return _persons.SingleOrDefault(x => x.PhoneNumber == phoneNumber);
    }

    public void Update(Person person)
    {
        Person personToUpdate = _persons.SingleOrDefault(x => x.Id == person.Id);
        personToUpdate.FirstName = person.FirstName;
        personToUpdate.LastName = person.LastName;
        personToUpdate.PhoneNumber = person.PhoneNumber;
        Console.WriteLine("Güncelleme Başarılı");
    }
}