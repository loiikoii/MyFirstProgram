//Vilgot Appelquist SUT25
namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Strings Start
            int answ;
            int count = 0;
            //Strings End
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Välj ett nummer mellan 0-20");
                    answ = int.Parse(Console.ReadLine()); //Reads input 1 - int
                    if (answ > 10 && answ < 21) //int higher than 10
                    {
                        Console.WriteLine("Talet ät stort!");
                        break;
                    }
                    else if (answ < 10 && answ >= 0) //int lower than 10
                    {
                        Console.WriteLine("Oj. Lågt tal!");
                        break;
                    }
                    //else if (answ >= 21)
                    //{
                    //    Console.WriteLine("För högt tal.");
                    //}
                }
                catch //Wrong input catch
                {
                    Console.WriteLine("Fel input");
                }
            }
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej {name}!");
            while (count != answ + 1)
            {
                Console.WriteLine(count);
                count++;
            }
        }
    }
}
