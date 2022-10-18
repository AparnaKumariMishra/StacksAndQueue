namespace UC2PeakAndPop
{
    internal class program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            UC2 UC2 = new UC2();
            UC2.Push(70);
            UC2.Push(30);
            UC2.Push(56);
            UC2.Display();
            UC2.Peek();// top.data
            UC2.Pop();
            UC2.IsEmpty();
            UC2.Display();
            Console.ReadKey();
        }
    }
}