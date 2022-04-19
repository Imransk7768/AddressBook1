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
            AddressBookContact1 ad = new AddressBookContact1();
            ad.Display();
        }
    }
}
