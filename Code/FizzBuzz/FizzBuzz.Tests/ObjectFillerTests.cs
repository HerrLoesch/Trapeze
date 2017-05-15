using System.Linq;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Tynamix.ObjectFiller;

namespace FizzBuzz.Tests
{
    public class Person
    {
        public string Name { get; set; }

        public Adress Adress { get; set; }
    }

    public class Adress
    {
        public string Street { get; set; }
    }

    [SetUpFixture]
    public class ObjectFillerTests
    {
        [OneTimeSetUp]
        public void OneTime()
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            
        }

        [Test]
        public void TestSomething()
        {
            var persons = Randomizer<Person>.Create(10);

            var filler = new Filler<Person>();
            filler.Setup().OnType<string>().Use("Hallo");


            Assert.AreNotEqual(0, persons.Count());

            foreach (var person in persons)
            {
                Assert.IsNotNull(person.Name);
            }
        }

        [TearDown]
        public void CleanUp()
        {
            
        }

        [OneTimeTearDown]
        public void OneTimeCleanUp()
        {

        }
    }
}
