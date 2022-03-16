@@ -0,0 + 1,23 @@
using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book \n");

            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookMain.AddressBook();

            //AddUsingConsole addUsingConsole = new AddUsingConsole();
            //addUsingConsole.readUserDetails();

            EditPersonDetails editPersonDetails = new EditPersonDetails();
            editPersonDetails.editUserDetails();

        }
    }

}
0 comments on commit 2c6ab36

