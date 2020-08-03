using System;
using System.Threading.Tasks;

namespace AsyncTestConsole
{
    internal static class Program
    {
        private static void Main()
        {
            ExecuteJob();
            ExecuteJobAsync();

            Console.ReadKey();
        }

        private static void Job()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(" » " + i);
            }
        }

        private static Task JobAsync()
        {
            return Task.Run(() => Job());
        }

        private static void ExecuteJob()
        {
            JobAsync();
            Console.WriteLine("Job Done!");
        }

        private static async void ExecuteJobAsync()
        {
            await JobAsync();
            Console.WriteLine("Async Job Done!");
        }
    }
}
