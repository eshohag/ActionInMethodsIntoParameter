using System;

namespace ActionInMethodsIntoParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUpInProgress(Extract);
            SetUpInProgress(Initialize);
            SetUpInProgress(Load);

            #region Comment
            //Console.WriteLine("Beginning Extract Methods-" + DateTime.Now);
            //Extract();
            //Console.WriteLine("Finished Extract Methods-" + DateTime.Now);
            //Console.WriteLine("Beginning Initialize Methods-" + DateTime.Now);
            //Initialize();
            //Console.WriteLine("Finished Initialize Methods-" + DateTime.Now);

            //Console.WriteLine("Beginning Load Methods-" + DateTime.Now);
            //Load();
            //Console.WriteLine("Finished Load Methods-" + DateTime.Now);
            #endregion
            Console.ReadLine();
        }

        private static void SetUpInProgress(Action anAction)
        {
            Console.WriteLine($"Beginning {anAction.Method.Name} Methods- " + DateTime.Now.ToLongTimeString());
            anAction();
            Console.WriteLine($"Finished {anAction.Method.Name} Methods- " + DateTime.Now.ToLongTimeString());
            Console.WriteLine();
        }

        private static void Extract()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\tExtract-{i}");
            }
        }

        private static void Initialize()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\tInitialize-{i}");
            }
        }

        private static void Load()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\tLoad-{i}");
            }
        }
    }
}
