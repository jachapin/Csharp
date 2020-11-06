using System;
using System.Collections.Generic;

namespace ContactList
{
    class ContactList
    {
        static void Main(string[] args)
        {
            // List of Contacts
            var ContactList = new List<Contact>();

            // User adds contacts
            bool addContact = true;
            while(addContact == true)
            {
                Console.WriteLine("CREATE NEW CONTACT: ");
                Console.WriteLine("First name: ");
                var firstName = Console.ReadLine();
                Console.WriteLine("Last name: ");
                var lastName = Console.ReadLine();
                Console.WriteLine("Phone number: ");
                var phoneNumber = Console.ReadLine();
                Console.WriteLine("Email address: ");
                var emailAddress = Console.ReadLine();

                ContactList.Add(new Contact(firstName, lastName, phoneNumber, emailAddress));

                Console.WriteLine("Create another contact? Y/N");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    addContact = false;
                }

            }

            // Iterate through ContactList and print out contacts
            foreach (var contact in ContactList)
            {
                Console.WriteLine(contact.ToString());
            }
        }
    }

    class Contact
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String emailAddress { get; set; }
        public String phoneNumber { get; set; }

        public Contact(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return ($"{firstName} {lastName} / {phoneNumber} / {emailAddress}");
        }
    }
}
