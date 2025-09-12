//Vilgot Appelquist SUT25
namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answ;
            while (true)
            {
                Console.WriteLine("Skriv in ett tal mellan 1-20");
                try
                {
                    answ = int.Parse(Console.ReadLine()); //Read int input
                    if (answ > 10)
                    {
                        Console.WriteLine("För högt tal");
                    }
                    else if (answ < 0)
                    {
                        Console.WriteLine("Inga negativa tal tack.");
                    }
                    else
                    {
                        if (answ >= 10) //if statement to see size - Start
                        {
                            Console.WriteLine("Talet är över 10");
                        }
                        else if (answ <= 10)
                        {
                            Console.WriteLine("Talet är under 10");
                        }
                        //If end
                        Console.WriteLine("Vad heter du?");
                        String name = Console.ReadLine() ?? string.Empty; //Read string input: name.
                        Console.WriteLine($"Hej {name}! ");
                        int num = 0; //Print numbers 0-answer - Start
                        while (num != answ + 1)
                        {
                            Console.Write(num + ", ");
                            num++;
                        } //Print number 0-answer - End */
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Fel input");
                }
            }
            }
        }
        }
