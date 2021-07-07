using System;
using System.Collections.Generic;
using System.Linq;

namespace GB_02_02
{
    public  class Node : ILinkedList
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }


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
                    values.Add(current.Value);      // !
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

        public void AddNodeAfter(Node node, int value)    // добавляет новый элемент списка после определённого элемента
        {
            var newNode = new Node { Value = value };
            var nextItem = node.NextNode;
            node.NextNode = newNode;
            newNode.NextNode = nextItem;
        }

        public Node FindNode(int searchValue)   // ищет элемент по его значению
        {
            if (_head == null)
            {
                return null;
            }

            var current = _head;
            var comparer = EqualityComparer<int>.Default;
            do
            {
                if (comparer.Equals(current.Value, searchValue))
                {
                    return current;
                }
                current = current.NextNode;
            }
            while (current != null);

            return null;
        }

        public int GetCount()     // возвращает количество элементов в списке
        {
            Count = Values.Count();
            return Count;
        }

        public void RemoveNode(int index)    // удаляет элемент по порядковому номеру 
        {
            var current = FindNode(index);

            if (current == null)
            {
                Console.WriteLine("Данный элемент не найден");
                return;
            }

            var prev = current.NextNode;
            var next = current.PrevNode;

            if (prev != null)
            {
                prev.NextNode = next;
            }
            else
            {
                _head = next;
            }

            if (next != null)
            {
                next.PrevNode = prev;
            }
            else
            {
                _tail = prev;
            }

        }

        public void RemoveNode(Node node)        // удаляет указанный элемент
        {
            var current = FindNode(node.Value);

            if (current == null)
            {
                Console.WriteLine("Данный элемент не найден");

            }

            var prev = current.NextNode;
            var next = current.PrevNode;

            if (prev != null)
            {
                prev.NextNode = next;
            }
            else
            {
                _head = next;
            }

            if (next != null)
            {
                next.PrevNode = prev;
            }
            else
            {
                _tail = prev;
            }
        }
    }

}

