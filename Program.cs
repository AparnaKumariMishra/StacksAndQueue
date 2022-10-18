namespace UC4Dequeue
{
    internal class program

    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            UC4Dequeue UC4Dequeue = new UC4Dequeue();
            UC4Dequeue.Enqueue(56);
            UC4Dequeue.Enqueue(30);
            UC4Dequeue.Enqueue(70);
           // UC4Dequeue.Dequeu(80);
            UC4Dequeue.Display();// this.top=this.top.next
            Console.ReadKey();
            UC4Dequeue.Dequeu(80);
            UC4Dequeue.Display();// this.top=this.top.next
            Console.ReadKey();

        }
    }
}