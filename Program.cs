using System;

namespace LinkListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");
            //Ablity To Create Linked List By Appending
            LinkListOperation linkedList = new LinkListOperation();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            linkedList = new LinkListOperation();
            linkedList.Add2(70);
            linkedList.Add2(30);
            linkedList.Add2(56);
            linkedList.Display();
            linkedList = new LinkListOperation();
            linkedList.Add(56);
            linkedList.Add(70);
            linkedList.Display();
            Console.WriteLine("\n");
            linkedList.InsertAtParticularPoistion(2, 30);
            linkedList.Display();
            Console.WriteLine("First element is poped out from linked list = " + linkedList.removeFirstNode().data);
            linkedList.Display();
            linkedList.InsertAtParticularPoistion(1, 56);
            Console.WriteLine("last element is poped out from linked list = " + linkedList.removeLastNode().data);
            linkedList.Display();
          

        }
    }
}
