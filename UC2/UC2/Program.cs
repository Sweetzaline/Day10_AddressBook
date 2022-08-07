using System;
using System.Collections.Generic;
namespace UC2
{
   class Class1
    {
        //Declarations:
        static String FirstName;
        static String LastName;
        static long Phone;
        static String Email;
        static String Address;
        static String City;
        static String State;
        static int PinCode;
        public static List<String> addressBook = new List<String>();

        //Main method:
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Enter your Contact Details:");      
            Class1 obj = new Class1();
            obj.addNewContact();
        }
      
        // Adding New Contact 
        public void addNewContact()
        {
            CreateContact(addressBook);
        }

        // This method will create new contact in address book
        public void CreateContact(List<string> addressBook)
        {
            char ch;
            int count = 0;
            string contact;
            do
            {
                Console.WriteLine("Enter Contact Details: ");
                Details();
                Console.WriteLine("Contact is Saved!");
                Console.WriteLine("\n");

                contact = FirstName + " " + LastName + " " + Phone.ToString() + " " + Email + " " + Address + " " + City + " " + State + " " + Code.ToString();
                addressBook.Add(contact);
                count++;

                Console.WriteLine("Do you want to continue Adding New Contact Details?  Type Y/N");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while (ch == 'Y');
            Console.WriteLine(" {0} Total contacts", count);
            Console.WriteLine("Address Book has these contacts:");
            for (int i = 0; i < addressBook.Count; i++)
            {
                Console.WriteLine("{0}.  {1}", i + 1, addressBook[i]);
            }
        }

        // This method will take user-inputs whenever any contact has to be created.
        public void Details()
        {
            string contact;
            Console.WriteLine("Please Enter Contact Details: ");
            Console.Write("First Name : ");
            String FirstName = Console.ReadLine();
            Console.Write("Last Name : ");
            String LastName = Console.ReadLine();
            Console.Write("Phone Number : ");
            long Phone_Number = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email : ");
            String Email = Console.ReadLine(); ;
            Console.Write("Address : ");
            String Address = Console.ReadLine();
            Console.Write("City : ");
            String City = Console.ReadLine();
            Console.Write("State : ");
            String State = Console.ReadLine();
            Console.Write("Pincode : ");
            int PinCode = Convert.ToInt32(Console.ReadLine());
            contact = FirstName + " " + LastName + " " + Phone_Number.ToString() + " " + Email + " " + Address + " " + City + " " + State + " " + PinCode.ToString(); Console.WriteLine(contact);
            Console.WriteLine(contact);
        }
    }
}