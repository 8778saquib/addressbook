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
            Console.WriteLine("4. Delete added person contact using name");

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
                case 4:
                    Addcontact person4 = new Addcontact();
                    person4.AddingContactDetails();
                    person4.DisplayDetails();

                    //Asking user if he/she wanted to edit the contact details or not
                    Console.WriteLine("Edit contact details using name ? 1: Yes/ Other: No");
                    Console.Write("Enter your choice : ");
                    int choice4 = Convert.ToInt32(Console.ReadLine());
                    if (choice4 == 1)
                    {
                        person4.EditContactDetails();
                        person4.DisplayDetails();
                    }

                    //Asking user if he/she wanted to delete the contact details or not
                    Console.WriteLine("Delete person using person name ? 1. Yes/ Other:  No");
                    Console.Write("Enter your choice : ");
                    int choice42 = Convert.ToInt32(Console.ReadLine());
                    person4.DeleteContactDetails();
                    //person4.DisplayDetails();
                    break;


                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;

            }

        }


    }
}


