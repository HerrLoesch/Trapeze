using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Mocking
{
    public class ViewModel : INotifyPropertyChanged
    {
        private IPersonRepository _repository;

        public ViewModel(IPersonRepository repository)
        {
            _repository = repository;
        }

        public void Intialize()
        {
            Persons = _repository.GetAllPersons();
        }

        private IEnumerable<Person> _persons;


        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<Person> Persons
        {
            get { return _persons; }
            set
            {
                _persons = value;
                OnPropertyChanged("Persons");
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}