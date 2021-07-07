using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_02_02
{
    public class ListImplementation : ILinkedList
    {
        private Node _head;
        private Node _tail;



        private int Count { get; set; }

        public int[] Values
        {
            get
            {
                var values = new List<int>();

                if (_head == null)
                {
                    return values.ToArray();
                }

                var current = _head;
                do
                {
                    values.Add(current.Value);
                    current = current.NextNode;
                }
                while (current != null);

                return values.ToArray();
            }
        }


        public void AddNode(int value)     // добавляет новый элемент списка
        {
            var newitem = new Node
            {
                Value = value
            };

            if (_head == null)
            {
                _head = newitem;
            }

            if (_tail == null)
            {
                _tail = newitem;
                _head.NextNode = _tail;
                _tail.PrevNode = _head;

                
            }

            _tail.NextNode = newitem;
            newitem.PrevNode = _tail;
            _tail = newitem;
        }

        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        public Node FindNode(int searchValue)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }
    }
}
