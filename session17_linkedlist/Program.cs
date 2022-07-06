using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

class LinkedListNode
{
    public int Value { get; set; }

    public LinkedListNode Next { get; set; }

    public LinkedListNode(int x)
    {
            this.Value = x;
            this.Next = null;        
    }
    
}
class LinkedList
{
    public int count { get; set; }
    public LinkedListNode head { get; set; }

    public LinkedList()
    {
        count = 0;
        head = null;
        
    }
  public  void AddToFront(int x) { 

                LinkedListNode node = new LinkedListNode(x);
                node.Next = head;
                head = node ;
                count ++;
    }

  public  void printLinkedList (){
        LinkedListNode objLinkedlist = head;
        while (objLinkedlist !=null)
        {
             
            System.Console.WriteLine(objLinkedlist.Value);
             objLinkedlist =objLinkedlist.Next;
          
        }
    }
    
}
        static void Main(string[] args)
        {
          
LinkedList objLinked = new LinkedList();
objLinked.AddToFront(4);
objLinked.AddToFront(54);
objLinked.AddToFront(12);
objLinked.AddToFront(11);
objLinked.AddToFront(41);
objLinked.printLinkedList();

        }
    }
}