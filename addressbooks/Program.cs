using System;

namespace addressbooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book program");

            Console.WriteLine("Enter the choice");
            Console.WriteLine(" 1. adding detail");
            Console.WriteLine("2. Add new contact");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    createcontact a = new createcontact("saquib", "nawaz", "Warje", "chennai", "tamilnadu", "saquib.nawaz009@gmail.com", 274001, 8778225600);
                    a.DisplayDetails();
                    break;
                case 2:
                    Addcontact person = new Addcontact();
                    person.AddingContactDetails();
                    person.DisplayDetails();
                    break;

                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;

            }

        }

    }
}


