//-----------------------------------------------------------------------
// <copyright file="SingleToneClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.Singletone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// SingleToneClass as class
    /// </summary>
   public class SingleToneClass
    {
       
        /// <summary>
        /// counter as parameter
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// create Instance of an SingleToneClass class
        /// </summary>
        private static SingleToneClass instance = null;

        /// <summary>
        /// use Lazy collection as string type
        /// </summary>
        private static readonly Lazy<SingleToneClass> Instancelock = new Lazy<SingleToneClass>(() => new SingleToneClass());

        /// <summary>
        /// Gets a value indicating whether the item is enabled.
        /// </summary>
        public static SingleToneClass GetInstances
        {
            //// get method 
            get
            {
                return Instancelock.Value;
            }
        }

        /// <summary>
        /// Initializes static members of the SingleToneClass class.
        /// </summary>
        private SingleToneClass()
        {
            counter++;
            Console.WriteLine("Counter value is increment by" + counter.ToString());
        }

        /// <summary>
        /// GetInstance as function
        /// </summary>
        /// <returns>return string</returns>
        public static SingleToneClass GetInstance()
        {
            {
                if (instance == null)
                {
                    instance = new SingleToneClass();
                }

                return instance;
            }
        }
    }
}
