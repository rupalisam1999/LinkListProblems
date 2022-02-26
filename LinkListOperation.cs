using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProblems
{
    public class LinkListOperation
    { 
    public Node head;
    public void insert(int value)
    {
        Node newNode = new Node();
        newNode.data = value;
        newNode.next = null;
        if (head != null)
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
        else
        {
            head = newNode;
        }
    }
    public void display()
    {
        if (head == null)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine(temp.data);

        }

    }
    public void insertAfter(int value, int search)
    {
        Node newNode = new Node();
        newNode.data = value;
        newNode.next = null;
        if (head != null)
        {
            Node temp = head;
            while (temp.next != null)
            {
                if (temp.data.Equals(search))
                {
                    break;
                }
                temp = temp.next;
            }
            Node tail = temp.next;
            temp.next = newNode;
            newNode.next = tail;
        }
        else
        {
            head = newNode;
        }
    }
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
            {

                temp = temp.next;
            }
            Console.WriteLine(temp.data);

        }


    }
}
}
    