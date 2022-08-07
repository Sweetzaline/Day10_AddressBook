using System;
namespace UC1
{
    class ContactBook
    {
        static void Main(string[] args)
        {
            ContactBook createContacts = new ContactBook();
            createContacts.AddYourContact();
        }
        public void AddYourContact()
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
            contact = FirstName + " " + LastName + " " + Phone_Number.ToString() + " " + Email + " " + Address + " " + City + " " + State + " " + PinCode.ToString();
           
            Console.WriteLine("Thanks! Your contact details are saved in our Book.");
            Console.WriteLine(contact);
        }
    }
}