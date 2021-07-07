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
            var linkedList = new ListImplementation();

            Console.WriteLine("Запуск двусвязного списка...");

            Run(linkedList);
        }

        internal static void Run(ListImplementation linkedList)
        {
            if (linkedList == null)
            {
                throw new ArgumentNullException(nameof(linkedList));
            }

            linkedList.AddNode(10);
            linkedList.AddNode(20);
            linkedList.AddNode(30);
            linkedList.AddNode(40);

            //var target = "four";
            //var isRemoved = linkedList.Remove(target);

            //if (isRemoved)
            //{
            //    Console.WriteLine($"Element {target} is removed.");
            //}
            //else
            //{
            //    Console.WriteLine($"Element {target} is not removed.");
            //}

            //target = "two";
            //var result = linkedList.Find(target);

            //if (result != null)
            //{
            //    Console.WriteLine($"Element {target} is found.");
            //}
            //else
            //{
            //    Console.WriteLine($"Element {target} is not found.");
            //}

            Console.WriteLine("Печать элементров:");

            foreach (var elem in linkedList.Values)
            {
                Console.WriteLine(elem);
            }
        }




    }

}
