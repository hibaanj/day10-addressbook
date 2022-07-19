using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_addressbook
{
    class Contactadd
    {
        public static void Main(string[] args)
        {



            // printing Welcome Message
            Console.WriteLine("\t\t\t******* WELCOME TO ADDRESS BOOK SYSTEM PROGRAM ******");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Addressbook addressbook = new Addressbook();
            addressbook.create();

            //to holde the screen
            Console.ReadKey();
        }



        
    }
}
  