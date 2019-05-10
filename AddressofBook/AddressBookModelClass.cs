namespace ObjectOrientedProgram1.AddressofBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;


   public class AddressBookModelClass
    {
        private string firstname;

        private string lastname;

        private string address;

        private string city;

        private string state;

        private int zip;

        private int phonenumber;

        public string Firstname
        {
            get => this.firstname;
            set => this.firstname = value;
        }

        public string Lastname
        {
            get => this.lastname;
            set => this.lastname = value;
        }

        public string Address
        {
            get => this.address;
            set => this.address = value;
        }

        public string City
        {
            get => this.city;
            set => this.city = value;
        }

        public string State
        {
            get => this.state;
            set => this.state = value;
        }

        public int Zip
        {
            get => this.zip;
            set => this.zip = value;
        }

        public int Phonenumber
        {
            get => this.phonenumber;
            set => this.phonenumber = value;
        }
    }
}
