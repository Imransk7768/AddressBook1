using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPrograms
{
    public class AddressBookEdit
    {
        List<Contact> addressBook = new List<Contact>();
        public AddressBookEdit()
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
            /*Contact address2 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                State = Console.ReadLine(),
                Email = Console.ReadLine(),
                Mobile = Convert.ToInt64(Console.ReadLine()),
                PostalCode = Convert.ToInt32(Console.ReadLine()),
            };*/
            addressBook.Add(address1);
            //addressBook.Add(address2);
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
                    "\nAddress : " + con.Address + "\nState : " + con.State + "\nEMail : " + con.Email +
                    "\nMobile : " + con.Mobile + "\nZIPCode : " + con.PostalCode + ".");
            }
        }
        public void EditContact(string name)
        {
            foreach (var con in addressBook)
            {
                if (con.FirstName.Equals(name))
                {
                    Console.WriteLine("Enter the Option To Update");
                    Random random = new Random();
                    int option = random.Next(1, 7);
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the Information to Update");
                            con.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the Information to Update");
                            con.Address = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the Information to Update");
                            con.State = Console.ReadLine(); 
                            break;
                        case 4:
                            Console.WriteLine("Enter the Information to Update");
                            con.Email = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the Information to Update");
                            con.PostalCode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter the Information to Update");
                            con.Mobile = Convert.ToInt64(Console.ReadLine()); 
                            break;
                        default:
                            Console.WriteLine("Enter Correct Option for Edit to Update");
                            con.Mobile = Convert.ToInt64(Console.ReadLine());
                            break;
                    }
                }
                Display();
            }
        }
    }
}
