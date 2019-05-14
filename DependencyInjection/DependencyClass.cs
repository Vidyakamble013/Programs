//-----------------------------------------------------------------------
// <copyright file="DependencyClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.DependencyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DependencyClass as class
    /// </summary>
    public class DependencyClass
    {
        /// <summary>
        /// DependencyFunction as function
        /// </summary>
        public static void DependencyFunction()
        {
            try
            {
                //// Create Instance of ConstructorInjectionClass class.
                ConstructorInjectionClass constructorInjection = new ConstructorInjectionClass(new FormatClass());

                //// GetData functio called
                constructorInjection.GetData();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
    }
}
