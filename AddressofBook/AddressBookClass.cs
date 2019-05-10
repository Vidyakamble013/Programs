namespace ObjectOrientedProgram1.AddressofBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    


   public class AddressBookClass
    {
        public static void ViewBookDetails()
        {
            try
            {
                ConstantClass constant = new ConstantClass();
                using (StreamReader reader = new StreamReader(constant.AddressBook))
                {
                    string jsonString = reader.ReadToEnd();
                    Console.WriteLine(jsonString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
