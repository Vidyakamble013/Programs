//-----------------------------------------------------------------------
// <copyright file="MainClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    /// <summary>
    /// MainClass as class
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// ReflectionFunction as function
        /// </summary>
        public static void ReflectionFunction()
        {
            try
            {
                //// Type as class 
                Type type = typeof(CustomerClass);
                Console.WriteLine("class name = " + type.Name);

                //// PropertyInfo is methos of an Reflection class
                PropertyInfo[] properties = type.GetProperties();

                Console.WriteLine("number of data members in customer class");
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine(property.Name);
                }

                Console.WriteLine("Method of customer class");

                //// MethodInfo is a method of an Reflection class
                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine(method.ReflectedType.Name + " " + method.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
