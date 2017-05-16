using System.Collections.Generic;

namespace PersonManagementTool
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
    }
}
