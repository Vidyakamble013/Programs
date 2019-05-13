//-----------------------------------------------------------------------
// <copyright file="EmployeeClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.PrototypePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// EmployeeClass as class
    /// </summary>
    public class EmployeeClass
    {
        /// <summary>
        /// PrototypeFunction as function
        /// </summary>
        public static void PrototypeFunction()
        {
            try
            {
                //// create Instance of an SoftwareDeveloperclass
                SoftwareDeveloper software = new SoftwareDeveloper();
                software.EmployeeName = "Boby";
                software.EmployeeId = "1";
                software.preferredTechnology = "Fullstack";

                //// Again create Instance of an SoftwareDeveloperclass
                SoftwareDeveloper developer = (SoftwareDeveloper)software.Clone();
                developer.EmployeeId = "2";
                developer.EmployeeName = "Sahil";

                Console.WriteLine(software.GetEmployeeDetails());
                Console.WriteLine(developer.GetEmployeeDetails());

                //// create Instance of an Department
                Department department = new Department();
                department.DeptName = "Testing";
                department.DId = "T-01";
                department.preferredTechnology = "Testing";
                department.WordsPerMinute = 100;

                //// Again create Instance of an Department
                Department department1 = (Department)department.Clone();
                department1.DeptName = "Development";
                department1.DId = "T-02";
                department1.WordsPerMinute = 150;

                Console.WriteLine(department.GetEmployeeDetails());
                Console.WriteLine(department1.GetEmployeeDetails());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
