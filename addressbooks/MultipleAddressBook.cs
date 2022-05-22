using System;
using System.Collections.Generic;

namespace addressbooks
{
    public class MultipleAddressBook
    {
        public int need;
        public string choose;
        public int addressBookIndex;
        public int count = 0;
        //Declaring list to add multiple data type information
        public List<createcontact>[] detailsList;

        //Declaring dictionary for maintaining multiple Address book
        public Dictionary<string, int> AddrBook;

        public MultipleAddressBook(int need)
        {
            this.need = need;
            detailsList = new List<createcontact>[need];

            //Initializing all values of the array of List detailsList with objects of Details
            //If we dont initialize the array it will contail null references
            for (int i = 0; i < detailsList.Length; i++)
            {
                detailsList[i] = new List<createcontact>();
                Console.WriteLine(detailsList[i]);
            }

            AddrBook = new Dictionary<string, int>();
        }

        //Adding Address Books one by one
        public void AddingMultipleAddressBooks()
        {
        AddAddresBook:
            Console.Write("Add new Address Book ? ( Press 1 for Yes / OtherNumber for No) : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
            doit:

                //Adding Address books less than or equal to the number we need
                if (AddrBook.Count < need)
                {
                    Console.Write("Address book name : ");
                    string addressBookName = Console.ReadLine();

                    //If entered value is null
                    if (addressBookName == "")
                    {
                        Console.WriteLine("Please write Address Book name");
                        goto doit;
                    }

                    //If entered value already present
                    if (AddrBook.ContainsKey(addressBookName))
                    {
                        Console.WriteLine("Entered Address Book name already present please enter again");
                        goto doit;
                    }
                    else
                    {
                        AddrBook.Add(addressBookName, count);
                        count++;
                        goto AddAddresBook;
                    }
                }
                else
                {
                    Console.WriteLine("Cannot add new Address Book beyond " + need);
                }
            }
        }

        //Asking user to choose which Address book to access
        public void AccessingAddressBook()
        {
        repeatAccessingAddressBook:
            Console.Write("Enter the name of the Address Book you want to access : ");
            string choose = Console.ReadLine();

            //Check if entered AddressBook name(here key) is available in dictionary or entered Address book is empty
            if (AddrBook.ContainsKey(choose) && choose != "")
            {
                this.choose = choose;

                //For storing the index of the Address Book we have choosen
                addressBookIndex = AddrBook[choose];
            }
            //Check again
            else
            {
                Console.WriteLine("Choose from available names");

                //If entered credentials are wrong enter values again
                goto repeatAccessingAddressBook;
            }
        }

        //Displaying all Address Books available and their index numbers
        public void DisplayAllAddressBooks()
        {
            if (AddrBook.Count > 0)
            {
                foreach (KeyValuePair<string, int> pair in AddrBook)
                {
                    Console.WriteLine("Name : {0}\tIndex Number : {1}", pair.Key, pair.Value);
                }
            }
            else
            {
                Console.WriteLine("Address Book records are empty");
            }
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
            int flag = 0;
            if (detailsList[addressBookIndex].Count > 0)
            {
                foreach (createcontact d in detailsList[addressBookIndex])
                {
                    if (d.firstName == firstName)
                    {
                        //Setting flag to 1 if same firstName is present
                        flag = 1;
                        Console.WriteLine("First Name : " + d.firstName);
                    }
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Same first name already present in Address book");
            }

            //If not add it to the list of the current Address Book
            else
            {
                detailsList[addressBookIndex].Add(details);
            }
        }

        //Displaying the details
        public void DisplayDetails()
        {
            //Checking if detailsList List of current Address Book contains something or not
            if (detailsList[addressBookIndex].Count > 0)
            {
                foreach (createcontact d in detailsList[addressBookIndex])
                {
                    Console.WriteLine("\nContact details of Address Book " + choose + " are as shown below");
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

            //If List is empty then there is nothing to show
            else
            {
                Console.WriteLine("No contact details available to display");
            }
        }

        //Editing in existing contact details
        public void EditContactDetails()
        {
            Console.Write("Enter the First Name of the contact for which you want to edit : ");
            string fName = Console.ReadLine();
            foreach (createcontact detail in detailsList[addressBookIndex])
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
            foreach (createcontact detail in detailsList[addressBookIndex])
            {
                if (detail.firstName == deleteName)
                {
                    detailsList[addressBookIndex].Remove(detail);
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
