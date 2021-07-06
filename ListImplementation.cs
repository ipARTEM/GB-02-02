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


        public void AddNode(int value)
        {
            var node = _head;

            while (node.NextNode != null)
            {
                node = node.NextNode;
            }

            var newNode = new Node { Value = value };
            node.NextNode = newNode;

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
