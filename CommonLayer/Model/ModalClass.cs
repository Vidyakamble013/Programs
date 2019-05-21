using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CommonLayer.Model
{
   public class ModalClass
    {
       
       public int ? EmployeeId 
       { get; set; }

        public string Firstname
        { get; set; }

        public string Lastname
        { get; set; }

        public string City
        { get; set; }

        public string Contact
        { get; set; }

        public string Gender
        { get; set; }
    }
}
