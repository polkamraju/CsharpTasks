using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int textdisplaycounter = 0;
                Person[] persons = new Person[3];
                for (int i = 0; i < persons.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Please enter Teacher Name.");
                        persons[i] = new Teacher(Convert.ToString(Console.ReadLine()));
                    }
                    else
                    {
                        if(textdisplaycounter == 0)
                        Console.WriteLine("Please enter Two Students Names.");
                        textdisplaycounter += 1;
                        persons[i] = new Student(Convert.ToString(Console.ReadLine()));
                    }
                }
                for (int i = 0; i < persons.Length; i++)
                {
                    if (i==0)
                    {
                        Console.WriteLine(((Teacher)persons[i]).ToString());
                        ((Teacher)persons[i]).Explain();
                    }
                    else
                    {
                        Console.WriteLine(((Student)persons[i]).ToString());
                        ((Student)persons[i]).Study();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                throw;
            }
        }
    }
}
