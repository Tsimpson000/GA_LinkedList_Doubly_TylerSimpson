namespace GA_LinkedList_Doubly_TylerSimpson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();

            // Add elements
            linkedList.InsertAtFront(30);
            linkedList.InsertAtFront(20);
            linkedList.InsertAtFront(10);

            // Display forward and backward
            Console.WriteLine("Forward:");
            linkedList.DisplayForward();
            Console.WriteLine("Backward:");
            linkedList.DisplayBackward();

            // Remove an element
            if (linkedList.Remove(20))
            {
                Console.WriteLine("20 removed");
            }
                
    
        // Access element by index
            Console.WriteLine($"Element at index 1: {linkedList[1]}");

            Console.ReadLine();
        }
    }
}
