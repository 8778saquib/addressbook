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

    }
}
