using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPrograms
{
    public class AddressBookContact1
    {
        List<Contact> addressBook = new List<Contact>();
        public AddressBookContact1()
        {
            Contact address1 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                State = Console.ReadLine(),
                Email = Console.ReadLine(),
                Mobile = Convert.ToInt64(Console.ReadLine()),
                PostalCode = Convert.ToInt32(Console.ReadLine()),
            };
            Contact address2 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                State = Console.ReadLine(),
                Email = Console.ReadLine(),
                Mobile = Convert.ToInt64(Console.ReadLine()),
                PostalCode = Convert.ToInt32(Console.ReadLine()),
            };
            addressBook.Add(address1);
            addressBook.Add(address2);
        }
        public void AddContactToAddressBook(Contact con)
        {
            addressBook.Add(con);
        }
        public void Display()
        {
            foreach (var con in addressBook)
            {
                Console.WriteLine("FirstName : " + con.FirstName + "\nLastName : " + con.LastName + 
                    "\nAddress : " + con.Address +"\nState : " + con.State + "\nEMail : " + con.Email + 
                    "\nMobile : " + con.Mobile + "\nZIPCode : " + con.PostalCode + ".");
            }
        }
    }
}
