using System.Collections.Generic;

namespace Mocking
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPersons();
    }
}