using System.Collections.Generic;

namespace PersonManagementTool
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
        Person GetPerson(int id);
    }
}
