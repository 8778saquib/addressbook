using System;
using System.Collections.Generic;

namespace addressbooks
{
    public class Addcontact
    {
        List<createcontact> detailsList;

        public Addcontact()
        {
            detailsList = new List<createcontact>();
        }


        public void AddingContactDetails()
        {
            //Filling the contact details
            Console.WriteLine("Add details one by one");
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Address : ");
            string address = Console.ReadLine();
            Console.Write("Enter City : ");
            string city = Console.ReadLine();
            Console.Write("Enter State : ");
            string state = Console.ReadLine();
            Console.Write("Enter zip code : ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter phone number : ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Email id : ");
            string email = Console.ReadLine();

            //Passing values to the details object
            createcontact details = new createcontact(firstName, lastName, address, city, state, email, zip, phoneNumber);

            //Checking if entered details already present or not
            if (detailsList.Contains(details))
            {
                Console.WriteLine("These details already present in Address book");
            }

            //If not add it to the list
            else
            {
                detailsList.Add(details);
            }
        }

        //Displaying the details
        public void DisplayDetails()
        {
            foreach (createcontact d in detailsList)
            {
                Console.WriteLine("\nContact details are as shown below");
                Console.WriteLine("First Name : " + d.firstName);
                Console.WriteLine("Last Name : " + d.lastName);
                Console.WriteLine("Address : " + d.address);
                Console.WriteLine("City : " + d.city);
                Console.WriteLine("State : " + d.state);
                Console.WriteLine("Zip code : " + d.zip);
                Console.WriteLine("Phone number : " + d.phoneNumber);
                Console.WriteLine("Email id : " + d.email);
            }
        }



        //Editing in existing contact details
        public void EditContactDetails()
        {
            Console.Write("Enter the First Name of the contact for which you want to edit : ");
            string fName = Console.ReadLine();
            foreach (createcontact detail in detailsList)
            {
                if (detail.firstName == fName)
                {
                    Console.WriteLine("1. First Name");
                    Console.WriteLine("2. Last Name");
                    Console.WriteLine("3. Address");
                    Console.WriteLine("4. City");
                    Console.WriteLine("5. State");
                    Console.WriteLine("6. Zip code");
                    Console.WriteLine("7. Phone number");
                    Console.WriteLine("8. Email id");
                    Console.WriteLine("Other. Exit to display contact details");
                    Console.Write("Choose what you want to edit : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter new First Name : ");
                            string newName = Console.ReadLine();
                            detail.firstName = newName;
                            break;
                        case 2:
                            Console.Write("Enter new Last Name : ");
                            string newLast = Console.ReadLine();
                            detail.lastName = newLast;
                            break;
                        case 3:
                            Console.Write("Enter new Address : ");
                            string newAdd = Console.ReadLine();
                            detail.address = newAdd;
                            break;
                        case 4:
                            Console.Write("Enter new City : ");
                            string newCity = Console.ReadLine();
                            detail.city = newCity;
                            break;
                        case 5:
                            Console.Write("Enter new State : ");
                            string newState = Console.ReadLine();
                            detail.state = newState;
                            break;
                        case 6:
                            Console.Write("Enter new zip code : ");
                            int newZip = Convert.ToInt32(Console.ReadLine());
                            detail.zip = newZip;
                            break;
                        case 7:
                            Console.Write("Enter new Phone number : ");
                            long newPhone = Convert.ToInt64(Console.ReadLine());
                            detail.phoneNumber = newPhone;
                            break;
                        case 8:
                            Console.Write("Enter new Email id : ");
                            string newEmail = Console.ReadLine();
                            detail.email = newEmail;
                            break;
                        default:
                            Console.WriteLine("\nEnter correct choice");
                            break;
                    }
                }

                //If input does not match with the contact list detail
                else
                {
                    Console.WriteLine("Entered input does not match with contact details");
                }
            }
        }
        //For deleting person details
        public void DeleteContactDetails()
        {
            Console.Write("Enter First name of the contact detail you want to delete : ");
            string deleteName = Console.ReadLine();
            foreach (createcontact detail in detailsList)
            {
                if (detail.firstName == deleteName)
                {
                    detailsList.Remove(detail);
                    Console.WriteLine("Person details deleted");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong credentials");
                }
            }
        }

    }
}
