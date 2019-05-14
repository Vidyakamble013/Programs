//-----------------------------------------------------------------------
// <copyright file="ProxyClientClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.ProxyDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ProxyClientClass as class
    /// </summary>
    public class ProxyClientClass : IClient
    {
        /// <summary>
        /// RealClientClass as class
        /// </summary>
       private RealClientClass client = new RealClientClass();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyClientClass"/> class.
        /// </summary>
        public ProxyClientClass()
        {
            try
            {
                //// Prints the message
                Console.WriteLine("ProxyClient: Initialized");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// GetData as function
        /// </summary>
        /// <returns>return string</returns>
        public string GetData()
        {
            return this.client.GetData();
        }
    }
}
