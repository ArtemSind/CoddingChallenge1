namespace CoddingChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new();
            list.addFirst(12);
            list.addLast(8);
            list.insertNode(100, 2);
            list.printList();
            list.insertNode(100, 20);
        }
    }
}
