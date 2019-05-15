//-----------------------------------------------------------------------
// <copyright file="CustomerClass.cs" company="BridgeLabz">
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
    /// CustomerClass as class
    /// </summary>
    public class CustomerClass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerClass"/> class.
        /// </summary>
        public CustomerClass()
        {
            this.Id = 1;
            this.Name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerClass"/> class.
        /// </summary>
        /// <param name="id">id as parameter</param>
        /// <param name="name">name as parameter</param>
        /// <param name="mobile">mobile as parameter</param>
        public CustomerClass(int id, string name, int mobile)
        {
            this.Id = id;
            this.Name = name;
            this.Contact = mobile;
        }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The id
        /// </value>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The id
        /// </value>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Contact.
        /// </summary>
        /// <value>
        /// The id
        /// </value>
        public int Contact
        {
            get;
            set;
        }

        /// <summary>
        /// PrintId as function
        /// </summary>
        public void PrintId()
        {
            Console.WriteLine("Id = " + this.Id);
        }

        /// <summary>
        /// PrintName as function
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine("Name =  " + this.Name);
        }
    }
}
