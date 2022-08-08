using System;
using System.Collections.Generic;


namespace addressbook
{
    
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contact Details\n");
            Class2 obj1 = new Class2();
            obj1.ContactDeatils();
                        
            Class2 obj2 = new Class2();
            obj2.UpdateContact();
        }
    }
   
    class Class2
    {
        int count = 1;
        static String firstName;
        static String lastName;
        static long phoneNumber;
        static String email;
        static String address;
        static String city;
        static String state;
        static int zipCode;
        public static List<String> addressBook = new List<String>();

        public void ContactDeatils()
        {
            string contact;
            Console.Write("First Name : ");
            firstName = Console.ReadLine();
            Console.Write("Last Name : ");
            lastName = Console.ReadLine();
            Console.Write("Phone Number : ");
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email : ");
            email = Console.ReadLine(); ;
            Console.Write("Address : ");
            address = Console.ReadLine();
            Console.Write("City : ");
            city = Console.ReadLine();
            Console.Write("State : ");
            state = Console.ReadLine();
            Console.Write("Zip : ");
            zipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Contact is saved!");
            contact = firstName + " " + lastName + " " + phoneNumber.ToString() + " " + email + " " + address + " " + city + " " + state + " " + zipCode.ToString() + "\n";
            addressBook.Add(contact);
            Console.WriteLine(contact);
        }
        public void CreateContact(List<string> addressBook)
        {
            string contact;
            Console.WriteLine("\nOk, Add New Contact Details: ");
            ContactDeatils();
            count++;
            Console.WriteLine("Total No. Of Contacts: {0} \n", count);
            contact = firstName + " " + lastName + " " + phoneNumber.ToString() + " " + email + " " + address + " " + city + " " + state + " " + zipCode.ToString();
            addressBook.Add(contact);
            UpdateContact();
        }
        public void UpdateContact()
        {
            Console.WriteLine("If you want to explore more in our Address Book,");
            Console.WriteLine("Select one option: ");
            Console.Write("1. Create Contact \n2. Update Contact \n3. Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateContact(addressBook);
                    break;
                case 2:
                    UpdateExistingContacts(addressBook);
                    break;
                default:
                    Environment.Exit(-1);
                    break;
            }
        }
       
        public void UpdateExistingContacts(List<string> addressBook)
        {
            if (addressBook.Count == 0)
            {
                Console.Write("\nAddress Book is empty. \n\n");
                UpdateContact();
            }
            else
            {
                Console.Write("\nFor which Contact FirstName, you want to Update details:  ");
                String name = Console.ReadLine();
                for (int i = 0; i < addressBook.Count; i++)
                {
                    String[] contactArray = addressBook[i].Split(" ");

                    for (int j = 0; j < contactArray.Length; j++)
                    {
                        if (name == contactArray[0])
                        {
                            Console.WriteLine("\nPlease update contact details:  \n");
                            ContactDeatils();
                            String updatedContact = firstName + " " + lastName + " " + phoneNumber.ToString() + " " + email + " " + address + " " + city + " " + state + " " + zipCode.ToString();
                            addressBook[i] = updatedContact;
                            break;
                        }
                    }
                }
                Console.WriteLine("Contact is Updated.\n");

                for (int i = 0; i < addressBook.Count; i++)
                {
                    Console.WriteLine("{0}.  {1}", i + 1, addressBook[i]);
                }
                UpdateContact();
            }
        }
    }
}