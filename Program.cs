namespace StackAndQueue
{
    internal class program
    {
        static void Main()
        {
            UC1Add UC1Add = new UC1Add();
            UC1Add.Push(70);
            UC1Add.Push(30);
            UC1Add.Push(56);
            UC1Add.Display();
            Console.ReadKey();
        }
    }
}

