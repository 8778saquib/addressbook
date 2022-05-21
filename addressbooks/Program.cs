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
            Console.WriteLine("3.edit add  detail");

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

                case 3:
                    Addcontact person2 = new Addcontact();
                    person2.AddingContactDetails();
                    person2.DisplayDetails();

                    //Asking user if he/she wanted to edit the contact details or not
                    Console.WriteLine("Edit contact details using name ? 1: Yes/ Other: No");
                    Console.Write("Enter your choice : ");
                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    if (choice3 == 1)
                    {
                        person2.EditContactDetails();
                        person2.DisplayDetails();
                    }
                    break;


                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;

            }

        }

    }
}


