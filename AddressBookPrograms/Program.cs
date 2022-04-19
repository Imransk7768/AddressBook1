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
            Contact con = new Contact();
            con.FirstName=Console.ReadLine();
            con.LastName=Console.ReadLine();
            con.Address=Console.ReadLine();
            con.State=Console.ReadLine();
            con.Email=Console.ReadLine();
            con.Mobile=Convert.ToInt64(Console.ReadLine());
            con.PostalCode= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("FirstName : "+con.FirstName+ "\nLastName : " + con.LastName + "\nAddress : " + con.Address + 
                "\nState : " + con.State + "\nEMail : " + con.Email + "\nMobile : " + con.Mobile + "\nZIPCode : " + con.PostalCode +".");

        }
    }
}
