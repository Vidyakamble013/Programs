//-----------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// VendingMachine as class
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// VendingMachineFunction as class
        /// </summary>
        public static void VendingMachineFunction()
        {
            try
            {
                int amount = 0;
                Utility.VendingMachineMethod(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
