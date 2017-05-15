using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackKata.Tests
{
    [TestClass]
    public class StackTests
    {
        private MyStack _sut;

        [TestInitialize]
        public void Initialize()
        {
            _sut = new MyStack();
        }

        [TestMethod]
        public void Stack_length_is_1_if_an_item_was_pushed()
        {
            _sut.Push(1);

            Assert.AreEqual(1, _sut.Length);
        }

        [TestMethod]
        public void Stack_length_is_2_if_two_items_were_pushed()
        {
            _sut.Push(1);
            _sut.Push(2);

            Assert.AreEqual(2, _sut.Length);
        }

        [TestMethod]
        public void Stack_length_is_0_if_stack_is_empty()
        {
            Assert.AreEqual(0, _sut.Length);
        }

        [TestMethod]
        public void Stack_length_is_0_if_an_item_was_pushed_and_poped()
        {
            _sut.Push(1);
            _sut.Pop();

            Assert.AreEqual(0, _sut.Length);
        }

        [TestMethod]
        public void Stack_length_is_1_if_an_item_was_pushed_twice_and_poped_once()
        {
            // Arrange
            var firstItem = 1;
            var secondItem = 2;

            // Act
            _sut.Push(firstItem);
            _sut.Push(secondItem);
            _sut.Pop();

            // Assert
            Assert.AreEqual(1, _sut.Length);
        }

        [TestMethod]
        public void A_pushed_item_is_returned_on_pop()
        {
            _sut.Push(1);
            int result = _sut.Pop();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void A_pushed_items_are_returned_in_reverse_order()
        {
            _sut.Push(1);
            _sut.Push(2);
            _sut.Push(1);
            _sut.Push(1);
            int fourth = _sut.Pop();

            int third = _sut.Pop();
            int second = _sut.Pop();
            int first = _sut.Pop();

            Assert.AreEqual(1, fourth);
            Assert.AreEqual(1, third);
            Assert.AreEqual(2, second);
            Assert.AreEqual(1, first);
        }
    }
}