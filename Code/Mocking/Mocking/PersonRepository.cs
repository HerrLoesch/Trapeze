using System;
using System.Collections.Generic;

namespace Mocking
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetAllPersons()
        {
            throw new NotImplementedException();
        }
    }
}