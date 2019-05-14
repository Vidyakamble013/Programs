//-----------------------------------------------------------------------
// <copyright file="ConstructorInjectionClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.DependencyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ConstructorInjectionClass as class
    /// </summary>
    public class ConstructorInjectionClass
    {
        /// <summary>
        /// ITextInterface as interface
        /// </summary>
        private ITextInterface textInterface;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructorInjectionClass"/> class.
        /// </summary>
        /// <param name="text">text as parameter</param>
        public ConstructorInjectionClass(ITextInterface text)
        {
            this.textInterface = text;
        }

        /// <summary>
        /// GetData as function
        /// </summary>
        public void GetData()
        {
            this.textInterface.Display();
        }
    }
}
