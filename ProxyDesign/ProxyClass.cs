//-----------------------------------------------------------------------
// <copyright file="ProxyClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.ProxyDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ProxyClass as class
    /// </summary>
    public class ProxyClass 
    {
        /// <summary>
        /// ProxyFunction as function
        /// </summary>
        public void ProxyFunction()
        {
            try
            {
                //// create Instancr of an ProxyClientClass class.
                ProxyClientClass proxy = new ProxyClientClass();
                Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());
            }           
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
