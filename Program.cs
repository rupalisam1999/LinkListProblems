using System;

namespace LinkListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListOperation listOperation = new LinkListOperation();
            listOperation.Add(56);
            listOperation.Add(30);
            listOperation.Add(70);
            listOperation.Display();

           

            listOperation = new LinkListOperation();

            listOperation.Add2(70);
            listOperation.Add2(30);
            listOperation.Add2(56);
            listOperation.Display();
        }
    }
    
}
    

