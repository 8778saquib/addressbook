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
            Console.WriteLine("5. Add multitple person");

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
                case 5:
                    ContactPersonMultiple person5 = new ContactPersonMultiple();
                Add:
                    Console.WriteLine("You want to enter details ? 1: Yes/ Other: No");
                    Console.Write("Enter your choice : ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 1)
                    {
                        person5.AddingContactDetails();
                        person5.DisplayDetails();
                        goto Add;
                    }

                //Asking user if he/she wanted to edit the contact details or not
                Edit:
                    if (person5.detailsList.Count > 0)
                    {
                        Console.WriteLine("Edit contact details using name ? 1: Yes/ OtherNumber: No");
                        Console.Write("Enter your choice : ");
                        int choice5 = Convert.ToInt32(Console.ReadLine());
                        if (choice5 == 1)
                        {
                            person5.EditContactDetails();
                            person5.DisplayDetails();
                            goto Edit;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No contact details available to edit");
                    }

                //Asking user if he/she wanted to delete the contact details or not
                Delete:
                    if (person5.detailsList.Count > 0)
                    {
                        Console.WriteLine("Delete person using person name ? 1. Yes/ OtherNumber:  No");
                        Console.Write("Enter your choice : ");
                        int choice52 = Convert.ToInt32(Console.ReadLine());
                        if (choice52 == 1)
                        {
                            person5.DeleteContactDetails();
                            person5.DisplayDetails();
                            goto Delete;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No contact details available for deletion");
                    }
                    break;



                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;

            }

        }


    }
}


