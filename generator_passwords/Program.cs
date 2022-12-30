

namespace generator_password
{

    class Program
    {

        static void Main(string[] args)
        {
            app();
        }

        static void app()
        {

            Console.WriteLine("***********************\n" +
                              "* Generator passwords *\n" +
                              "***********************\n");


            Console.Write("Password length : ");

            int passSize;
            int.TryParse(Console.ReadLine(), out passSize);

            List<string> menu = new List<string>() 
            { 
                "Only lowercase characters", 
                "Lowercase and uppercase characters", 
                "Characters and numbers", 
                "Characters, numbers and special characters"
            };

            Console.WriteLine("\nMenu\n");

            for(int index = 0; index < menu.Count; index++)
            {
                Console.WriteLine(" {0} - {1}\n", index, menu[index]);
            }


            while(true)
            {
                Console.Write("\nChoice : ");

                int choice;

                if(int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine(generator(choice, passSize));
                }
                else
                {
                    Console.WriteLine("Write a number valid");
                }
            }

            static string generator(int choice, int length)
            {
                List<string> alphabet = new List<string>()
                {
                    "a","b","c","d","e",
                    "f","g","h","i","a",
                    "a","a","a","a","a",
                    "a","a","a","a","a",
                    "a","a","a","a","a",
                    "a",
                };

                switch (choice)
                {
                    case 1:

                }

                return "s";
            }

        }

        

    }

}