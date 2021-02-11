using System;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList playList = new DoublyLinkedList();

            for (int i = 1; i < 5; i++)
            {
                playList.AddFirst(i);
                Console.WriteLine(playList.Head.Value);
            }


            playList.RemoveLast();
            Console.WriteLine(playList.Tail.Value);
            playList.RemoveLast();
            Console.WriteLine(playList.Tail.Value);






        }
    }
}
