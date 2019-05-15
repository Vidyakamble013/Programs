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
                    Console.WriteLine("1. Singletone designpattern program");
                    Console.WriteLine("2. Computer Factory Management");
                    Console.WriteLine("3. Prototype design pattern");
                    Console.WriteLine("4. Adapter design pattern");
                    Console.WriteLine("5. Facade design pattern");
                    Console.WriteLine("6. Proxy design pattern");
                    Console.WriteLine("7. Observer design pattern");
                    Console.WriteLine("8. Visitor design pattern");
                    Console.WriteLine("9. Annotation program");
                    Console.WriteLine("10. Dependency Injection program");
                    Console.WriteLine("11. Reflection program");
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
                        case 5:
                            FacadeDesign.MainClass mainClass = new FacadeDesign.MainClass();
                            mainClass.MinFunction();
                            break;
                        case 6:
                            ProxyDesign.ProxyClass proxyClass = new ProxyDesign.ProxyClass();
                            proxyClass.ProxyFunction();
                            break;
                        case 7:
                            ObserverDesign.ObserverClass.ObserverFunction();
                            break;
                        case 8:
                            VisitorDesign.MainVisitorClass.VisitorFunction();
                            break;
                        case 9:
                            Annotation.AnnotationClass.AnnotationFunction();
                            break;
                        case 10:
                            DependencyInjection.DependencyClass.DependencyFunction();
                            break;
                        case 11:
                            Reflection.MainClass.ReflectionFunction();
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
