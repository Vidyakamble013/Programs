//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms
{
    using System;

    /// <summary>
    /// Program as class
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Main as function
        /// </summary>
        /// <param name="args">args as parameter</param>
       public static void Main(string[] args)
        {
            try
            {
                int choice = 0;
                
                do
                {
                    Console.WriteLine("1. Singletone designpattern Program");
                    Console.WriteLine("2. Computer Factory Management");
                    Console.WriteLine("3. Prototype design pattern");
                    Console.WriteLine("4. Adapter design pattern");
                    Console.WriteLine("Enter your choice");

                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Singletone.ClientClass.SingleToneClientFunction();
                            break;
                        case 2:
                            FactoryManagement.MainFactoryClass.Factory();
                            break;
                        case 3:
                            PrototypePattern.EmployeeClass.PrototypeFunction();
                            break;
                        case 4:
                            AdapterDesign.ShoppingClass.AdapterFunction();
                            break;
                    }
                }
                while (choice != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
