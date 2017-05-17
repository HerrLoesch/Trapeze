using System.Collections.Generic;
using System.Linq;

namespace PersonManagementTool.UI
{
    public class MainWindowViewModel
    {
        private IPersonRepository _personRepository;

        public MainWindowViewModel(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public void Initialize()
        {
            AvailablePersons = _personRepository.GetPersons();
            var firstPerson = AvailablePersons.FirstOrDefault();


            if (firstPerson != null)
            {
                this.SelectedPerson = _personRepository.GetPerson(firstPerson.Id);
            }
        }

        public IEnumerable<Person> AvailablePersons { get; private set; }
        public Person SelectedPerson { get; private set; }
    }
}
