//-----------------------------------------------------------------------
// <copyright file="RealClientClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.ProxyDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// RealClientClass as class
    /// </summary>
    public class RealClientClass : IClient
    {
        /// <summary>
        /// data as private field
        /// </summary>
        private string data;

        /// <summary>
        /// Initializes a new instance of the <see cref="RealClientClass"/> class.
        /// </summary>
        public RealClientClass()
        {
            //// Constructor message when called
            Console.WriteLine("Real Client: Initialized");
            this.data = "Dot Net Tricks";
        }

        /// <summary>
        /// GetData as function
        /// </summary>
        /// <returns>return string</returns>
        public string GetData()
        {
            return this.data;
        }
    }
}
