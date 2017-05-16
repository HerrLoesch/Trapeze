using System.Collections.Generic;
using System.Linq;
using DynamicSpecs.NUnit;
using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;
using PersonManagementTool.UI;
using Tynamix.ObjectFiller;

namespace PersonManagementTool.Sepcs
{
    public class When_the_person_selection_is_visible : Specifies<MainWindowViewModel>
    {
        private IEnumerable<Person> _persons;

        public override void Given()
        {
            _persons = Randomizer<Person>.Create(10);

            var personRepository = this.GetInstance<IPersonRepository>();
            A.CallTo(() => personRepository.GetPersons()).Returns(_persons);
        }

        public override void When()
        {
            this.SUT.Initialize();
        }

        [Test]
        public void Then_all_persons_from_repository_must_be_shown()
        {
            this.SUT.AvailablePersons.ShouldBeEquivalentTo(_persons);
        }

        [Test]
        public void Then_the_first_available_person_must_be_selected()
        {
            this.SUT.SelectedPerson.ShouldBeEquivalentTo(_persons.First());
        }
    }
}
