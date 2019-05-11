//-----------------------------------------------------------------------
// <copyright file="AddressBookModelClass.cs" company="BridgeLabs">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedProgram1.AddressofBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// AddressBookModelClass as class
    /// </summary>
    public class AddressBookModelClass
    {
        /// <summary>
        /// The firstName as field 
        /// </summary>
        private string firstName;

        /// <summary>
        /// The lastName as field
        /// </summary>
        private string lastName;

        /// <summary>
        /// The address as field
        /// </summary>
        private string address;

        /// <summary>
        /// The city as field
        /// </summary>
        private string city;

        /// <summary>
        /// The state as field
        /// </summary>
        private string state;

        /// <summary>
        /// The zip as field
        /// </summary>
        private string zip;

        /// <summary>
        /// The phoneNumber as field
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Gets or sets the name of the Address.
        /// </summary>
        public string Firstname
        {
            get => this.firstName;
            set => this.firstName = value;
        }

        /// <summary>
        /// Gets or sets the name of the Address.
        /// </summary>
        public string Lastname
        {
            get => this.lastName;
            set => this.lastName = value;
        }

        /// <summary>
        /// Gets or sets the name of the Address.
        /// </summary>
        public string Address
        {
            get => this.address;
            set => this.address = value;
        }

        /// <summary>
        /// Gets or sets the name of the Address.
        /// </summary>
        public string City
        {
            get => this.city;
            set => this.city = value;
        }

        /// <summary>
        /// Gets or sets the name of the Address.
        /// </summary>
        public string State
        {
            get => this.state;
            set => this.state = value;
        }

        /// <summary>
        /// Gets or sets the name of the Address.
        /// </summary>
        public string Zip
        {
            get => this.zip;
            set => this.zip = value;
        }

        /// <summary>
        /// Gets or sets the name of the Address.
        /// </summary>
        public string Phonenumber
        {
            get => this.phoneNumber;
            set => this.phoneNumber = value;
        }
    }
}
