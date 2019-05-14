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
        /// create Instance of an SingleToneClass class
        /// </summary>
        private static SingleToneClass instance = null;

        /// <summary>
        /// counter as parameter
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// Prevents a default instance of the <see cref="SingleToneClass"/> class from being created.
        /// </summary>
        private SingleToneClass()
        {
            counter++;
            Console.WriteLine("Counter value is increment by" + counter.ToString());
        }

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
        /// use Lazy collection as string type
        /// </summary>
        private static readonly Lazy<SingleToneClass> Instancelock = new Lazy<SingleToneClass>(() => new SingleToneClass());

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
