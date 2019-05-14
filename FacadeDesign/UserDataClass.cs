//-----------------------------------------------------------------------
// <copyright file="UserDataClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FacadeDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// UserDataClass as class
    /// </summary>
    public class UserDataClass
    {
        /// <summary>
        /// UserDetails as function
        /// </summary>
        public void UserDetails()
        {
            try
            {
                Console.WriteLine("Enter your Id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your first name");
                string fname = Console.ReadLine();
                Console.WriteLine("Enetr last name");
                string lname = Console.ReadLine();
                Console.WriteLine("Enter contact number");
                double contact = Convert.ToDouble(Console.ReadLine());   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
