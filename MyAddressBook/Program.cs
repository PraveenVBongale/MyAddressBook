using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewContact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME - ADDRESS BOOK");
            AddressBook address = new AddressBook();
            address.CreateContact();
            address.Display();
            Console.ReadKey();
        }
    }
}