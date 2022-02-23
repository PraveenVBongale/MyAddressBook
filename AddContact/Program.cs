﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddContact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME - ADDRESS BOOK");
            AddressBook address = new AddressBook();
            //address.CreateContact();
            //address.Display();
            //Console.ReadKey();


            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter a Number to Execute the Address Book Program \n1.Create \n2.Add \n3.Edit \n4.Quit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.CreateContact();
                        address.Display();
                        break;

                    case 2:
                        address.AddContacts();
                        address.Display();
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }

        }
    }
}