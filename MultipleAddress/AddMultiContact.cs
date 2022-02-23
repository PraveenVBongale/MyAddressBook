using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleAddress
{
    internal class AddMultiContact
    {
        public Dictionary<string, AddressBook> Library;


        public AddMultiContact()
        {
            Library = new Dictionary<string, AddressBook>();
        }

        public void AddAddressBook(AddressBook addressBook)
        {
            Console.WriteLine("Enter name of new addressbook");
            string name = Console.ReadLine();

        }
    }
}
