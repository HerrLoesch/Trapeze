using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public IEnumerable<Person> AvailablePersons { get; set; }
        public Person SelectedPerson { get; set; }
    }
}
