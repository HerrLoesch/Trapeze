using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace List.Tests
{
    [TestFixture]
    public class ListTests
    {
        private ListFoo _sut;

        [SetUp]
        public void Initialize()
        {
            _sut = new ListFoo();
        }
        
        [Test]
        public void Prioritized_list_contains_only_given_items()
        {
            var givenData = new List<string> {"Z","A"};
            _sut.Initialize(new List<string>(), givenData);

            CollectionAssert.AreEquivalent(givenData, _sut.PrioritizedList);
        }

        [Test]
        public void Alphabetical_list_contains_only_given_items_in_alphabetcial_order()
        {
            var notPrioritizedContent = new List<string> { "Z", "A" };
            _sut.Initialize(notPrioritizedContent, new List<string>());

            CollectionAssert.AreEqual(new List<string> { "A", "Z" }, _sut.AlphabeticalList);
        }

        [Test]
        [Ignore("TODO")]
        public void An_exception_is_thrown_if_input_data_has_duplicates_between_both_lists()
        {
            
        }

        [Test]
        public void An_exception_is_thrown_if_unprioritized_input_data_has_duplicates()
        {
            var notPrioritizedContent = new List<string> { "A", "A" };
            
            Assert.Throws<ArgumentException>(() => _sut.Initialize(notPrioritizedContent, new List<string>()));
        }

        [Test]
        [Ignore("TODO")]
        public void An_exception_is_thrown_if_prioritized_input_data_has_duplicates()
        {

        }

        [Test]
        [Ignore("TODO")]
        public void CheckThatAnExceptionIsThrownWhenItemsMovedNotInTheSourceList()
        {
            // Must be done for bot lists -> two tests instead of one!
        }

        [Test]
        public void The_selected_item_in_alphabeticaly_list_must_be_moved_to_last_position_in_prioritized_list()
        {
            var notPrioritizedContent = new List<string> { "Z", "A" };
            _sut.Initialize(notPrioritizedContent, new List<string>());

            _sut.MoveToPriorityList("A");

            Assert.AreEqual("A", _sut.PrioritizedList.Last());
            CollectionAssert.DoesNotContain(_sut.AlphabeticalList, "A");
        }

        [Test]
        public void The_selected_item_in_prioritized_list_must_be_moved_to_alphabetically_position_in_alphabetically_list()
        {
            var prioritizedContent = new List<string> { "Z", "A" };
            _sut.Initialize(new List<string>(), prioritizedContent);

            _sut.MoveToAlphabeticallyList("A");

            Assert.AreEqual("A", _sut.AlphabeticalList.First());
            CollectionAssert.DoesNotContain(_sut.PrioritizedList, "A");
        }
    }

    public class ListFoo
    {
        private List<string> _prioritizedList;
        private SortedList<string,string> _alphabeticalList;

        public ListFoo()
        {
            _alphabeticalList = new SortedList<string, string>();
            _prioritizedList = new List<string>();
        }
        
        public void Initialize(List<string> notPrioritizedContent, List<string> prioritizedList)
        {
            var sortedList = new SortedList<string, string>();
            foreach (var data in notPrioritizedContent)
            {
                sortedList.Add(data, data);
            }

            _alphabeticalList = sortedList;
            _prioritizedList = prioritizedList;
        }

        public IEnumerable<string> AlphabeticalList
        {
            get { return _alphabeticalList.Values; }
        }

        public IEnumerable<string> PrioritizedList
        {
            get { return _prioritizedList; }
        }

        public void MoveToPriorityList(string item)
        {
            _prioritizedList.Add(item);
            _alphabeticalList.Remove(item);
        }

        public void MoveToAlphabeticallyList(string item)
        {
            _alphabeticalList.Add(item,item);
            _prioritizedList.Remove(item);
        }
    }
}
