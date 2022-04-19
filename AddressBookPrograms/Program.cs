using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPrograms
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(">>>> Welcome to Address-Book Details <<<<\n");
            Console.WriteLine("Enter Contact Details");
           
            AddressBookEdit  edit = new AddressBookEdit();
            edit.Display();
            Console.WriteLine("\nEdit The information Here : ");
            string name = Console.ReadLine();
            edit.EditContact(name);
        }
    }
}
