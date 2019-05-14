//-----------------------------------------------------------------------
// <copyright file="IEmployee.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.PrototypePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IEmployee as interface
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Clone as function
        /// </summary>
        /// <returns>return type interface</returns>
        IEmployee Clone();

        /// <summary>
        /// GetEmployeeDetails as function
        /// </summary>
        /// <returns>return string</returns>
        string GetEmployeeDetails();
    }

    /// <summary>
    /// SoftwareDeveloper as class
    /// </summary>
    public class SoftwareDeveloper : IEmployee
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public int WordsPerMinute { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string PreferredTechnology { get; set; }

        /// <summary>
        /// Clone as function
        /// </summary>
        /// <returns>return interface</returns>
        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        /// <summary>
        /// GetEmployeeDetails as function
        /// </summary>
        /// <returns>return string</returns>
        public string GetEmployeeDetails()
        {
            return string.Format("{0} {1} {2}", this.EmployeeName, this.EmployeeId, this.PreferredTechnology);
        }
    }

    /// <summary>
    /// Department as class
    /// </summary>
    public class Department : IEmployee
    {
        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public int WordsPerMinute { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether SA1623 works with {para} tags.
        /// </summary>
        public string DeptName { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string DId { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string PreferredTechnology { get; set; }

        /// <summary>
        /// Clone as function
        /// </summary>
        /// <returns>return as interface type</returns>
        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        /// <summary>
        /// GetEmployeeDetails as function
        /// </summary>
        /// <returns>return string type</returns>
        public string GetEmployeeDetails()
        {
            return string.Format("{0} {1} {2} ", this.DeptName, this.DId, this.WordsPerMinute);
        }
    }
}
