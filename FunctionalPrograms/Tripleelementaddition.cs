//-----------------------------------------------------------------------
// <copyright file="TripleElementAddition.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// TripleElementAddition as class
    /// </summary>
    public class TripleElementAddition
    {
        /// <summary>
        /// Triple as addition
        /// </summary>
        public static void Triple()
        {
            try
            {
                int range = 0;
                Utility u = new Utility();
                u.TripleAddition(range);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
