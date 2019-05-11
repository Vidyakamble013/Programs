//-----------------------------------------------------------------------
// <copyright file="AddressBookClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.AddressofBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// AddressBookClass as class
    /// </summary>
    public class AddressBookClass
    {
        /// <summary>
        /// ViewBookDetails as function
        /// </summary>
        public static void ViewBookDetails()
        {
            try
            {
                AddressBookTypeClass addressBookTypeClass = new AddressBookTypeClass();
                Console.WriteLine("Select Operation \n1. AddNewUser  \n2. UpdateUserDetails \n3. PrintAddressBookDetails \n4. DeleteUser \n5. SortByOrder \n6. SortZipCode");
                int operationChoice = Convert.ToInt32(Console.ReadLine());
                ////switch to perform number of operation
                switch (operationChoice)
                {
                    case 1:
                        addressBookTypeClass.AddNewUser();
                        break;

                    case 2:
                        addressBookTypeClass.UpdateFunction();
                        break;

                    case 3:
                        addressBookTypeClass.PrintAddressBookDetails();
                        break;
                    case 4:
                        addressBookTypeClass.DeleteUserData();
                        break;
                    case 5:
                        addressBookTypeClass.SortByOrder();
                        break;
                    case 6:
                        addressBookTypeClass.SortToZipCode();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
