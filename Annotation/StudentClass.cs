//-----------------------------------------------------------------------
// <copyright file="StudentClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.Annotation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    /// <summary>
    /// StudentClass as class
    /// </summary>
    public class StudentClass
    {
        /// <summary>
        /// Required as class to use validation purpose
        /// </summary>
        [Required(ErrorMessage = "Enter Student Id")]

        //// Range as class to check minimum and maximum range
        [Range(0, 100, ErrorMessage = "Student Id between 0 to 100 range")]

        /// <summary>
        /// Gets or sets the id.
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
        /// Required as class to use validation purpose
        /// </summary>
        [Required(ErrorMessage = "Enter Student Name")]

        //// StringLength as class to check the string length
        [StringLength(100)]

        //// RegularExpression as class to check the validation. 
        [RegularExpression("@^[A - Z]{0, 20}$")]

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Required as class
        /// </summary>
        [Required(ErrorMessage = "Enter Address")]

        //// StringLength as class to check the string length
        [StringLength(150)]

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        {
            get;
            set;
        }
    }
}
