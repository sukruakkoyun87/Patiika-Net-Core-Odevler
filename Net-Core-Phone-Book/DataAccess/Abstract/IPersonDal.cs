

public interface IPersonDal
{
    Person Get(int id);
    List<Person> GetAll();
    void Add(Person person);
    void Update(Person person);
    void Delete(Person person);

    Person GetbyPhoneNumber(string phoneNumber);
 Person GetbyFirstNameOrLastName(string firstNameOrLastName);
    
}