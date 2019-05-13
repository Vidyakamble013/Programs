//-----------------------------------------------------------------------
// <copyright file="ClientClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.Singletone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ClientClass as class
    /// </summary>
    public class ClientClass
    {
        /// <summary>
        /// SingleToneClientFunction as function
        /// </summary>
        public static void SingleToneClientFunction()
        {
            try
            {
                SingleToneClass singletone1 = SingleToneClass.GetInstance();
                SingleToneClass singletone2 = SingleToneClass.GetInstance();
                SingleToneClass singletone = SingleToneClass.GetInstances;

                if (singletone1 == singletone2)
                {
                    Console.WriteLine("Here we implament the singletone design pattern");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
