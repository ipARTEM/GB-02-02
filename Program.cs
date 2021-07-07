using System;

namespace GB_02_02
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            RunDoublyLinkedList();

            Console.ReadLine();
        }

        internal static void RunDoublyLinkedList()
        {
            var linkedList = new Node();

            Console.WriteLine("Запуск двусвязного списка...");

            Run(linkedList);
        }

        internal static void Run(Node linkedList)
        {
            if (linkedList == null)
            {
                throw new ArgumentNullException(nameof(linkedList));
            }

            linkedList.AddNode(10);
            linkedList.AddNode(20);
            linkedList.AddNode(30);
            linkedList.AddNode(40);

            

            Console.WriteLine("Печать элементров:");

            foreach (var elem in linkedList.Values)
            {
                Console.WriteLine(elem);
            }

            var target = 30;
            var result = linkedList.FindNode(target);

            Console.WriteLine($"Элемент {result.Value} найден");


            //linkedList.RemoveNode(2);

            //linkedList.RemoveNode(20);

            Console.WriteLine("Печать элементров:");

            foreach (var elem in linkedList.Values)
            {
                Console.WriteLine(elem);
            }

            var node = new Node();

            Console.WriteLine("Печать элементров:");

            foreach (var elem in linkedList.Values)
            {
                Console.WriteLine(elem);
            }



            Console.WriteLine(linkedList.GetCount());

            Console.WriteLine(linkedList.FindNode(30).Value);

            Console.WriteLine(linkedList.FindNode(30).NextNode.Value);
            Console.WriteLine(linkedList.FindNode(30).PrevNode.Value);
            




        }
    }

}
