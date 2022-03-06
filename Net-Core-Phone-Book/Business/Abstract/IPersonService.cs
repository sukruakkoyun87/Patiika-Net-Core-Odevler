public interface IPersonService
{
    void Add(Person person);
    void Delete(Person person);
    Person Get(int id);
    List<Person> GetAll();
    Person GetbyFirstNameOrLastName(string firstNameOrLastName);
   
    Person GetbyPhoneNumber(string phoneNumber);
    void Update(Person person);
}