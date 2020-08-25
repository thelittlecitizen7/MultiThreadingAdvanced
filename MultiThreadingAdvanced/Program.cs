namespace MultiThreadingAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex ex1 = new Ex();

            ex1.WriteTextAsync("Mamas").Wait();
        }

    }
}
