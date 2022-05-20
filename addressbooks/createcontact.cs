using System;
namespace addressbooks
{
    public class createcontact
    {

        //variable initialization

        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string email;
        public int zip;
        public long phoneNumber;

        // parameterized construstor 

        public createcontact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)
        {

            //set values of class level variables from the constructor

            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.email = email;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("First Name : " + this.firstName);
            Console.WriteLine("Last Name : " + this.lastName);
            Console.WriteLine("Address : " + this.address);
            Console.WriteLine("City : " + this.city);
            Console.WriteLine("State : " + this.state);
            Console.WriteLine("Email id : " + this.email);
            Console.WriteLine("Zip code : " + this.zip);
            Console.WriteLine("Phone number : " + this.phoneNumber);
        }

    }
}
