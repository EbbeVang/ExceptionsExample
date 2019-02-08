using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            // TRY-CATCH EXAMPLE:
            try
            {
                person.Name = "dipshit";

                // trying to set the age lower than 0
                person.Age = -8;
            }

            // catching an exception - You can have many catch blocks or just one
            catch (NameContentViolationException e)
            {
                Console.WriteLine("Sorry you can't name a person shit");
            }

            // 'Catching' the argumentOofRange exception:
            catch (ArgumentOutOfRangeException e)
            {
                // Inform the user about what went wrong
                Console.WriteLine("Sorry, But a Person's age must be zero or more");
            }

            // finally block can be omitted - but if you add it it will always be executed!
            finally
            {
                if (person.Name == null) Console.WriteLine("You didn't manage to set the name!");
                if (person.Age == 0) Console.WriteLine("You didn't manage to set the age!");
            }
        }
    }
}