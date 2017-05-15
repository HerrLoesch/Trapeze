using System.Collections.Generic;
using System.Linq;

/* 
 * size -> how many items do we have
 * push -> add an item
 * pop -> remove an item
 * FILO -> Last item pushed is first item poped
 *
 */

namespace StackKata
{
    public class MyStack
    {
        public int Length { get; set; }

        private List<int> _content = new List<int>();

        public int Pop()
        {
            Length--;

            var last = _content.Last();

            _content.RemoveAt(_content.Count - 1);

            return last;
        }

        public void Push(int item)
        {
            Length++;

            _content.Add(item);
        }
    }
}
