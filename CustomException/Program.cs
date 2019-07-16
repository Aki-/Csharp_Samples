using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name. (Other than Steve)");

            string name = "";

            try
            {
                name = Convert.ToString(Console.ReadLine());

                if(name=="Steve")
                {
                    throw new SteveException("Enter other than Steve.");
                }
                else
                {
                    Console.WriteLine("Your name:- " + name);
                    Console.Read();
                }
            }
            catch(SteveException sE)
            {
                Console.WriteLine("SteveException fired !!");
                Console.WriteLine(sE.Message);
            }
            catch (Exception ex)
            {
                throw;
            }

            Console.Read();


            

        }
    }
}
