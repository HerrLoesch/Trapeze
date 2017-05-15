using System.Linq;
using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;
using Tynamix.ObjectFiller;

namespace Mocking
{
    [TestFixture]
    public class ViewModelTests
    {
        [Test]
        public void All_persons_must_be_avaiable_after_View_is_initialized()
        {
            // Arrange
            var repository = A.Fake<IPersonRepository>();
            A.CallTo(() => repository.GetAllPersons()).ReturnsLazily(() => Randomizer<Person>.Create(2));
            ViewModel sut = new ViewModel(repository);
            sut.MonitorEvents();

            // Act
            sut.Intialize();

            // Assert
            Assert.IsNotNull(sut.Persons, "Because Persons property is null.");

            sut.Persons.Should().NotBeNull("Persons is null");

            sut.ShouldRaisePropertyChangeFor(x => x.Persons);
        }
    }
}
