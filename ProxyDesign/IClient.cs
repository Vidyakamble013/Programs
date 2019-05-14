//-----------------------------------------------------------------------
// <copyright file="IClient.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.ProxyDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IClient as interface
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// GetData as function.
        /// </summary>
        /// <returns>return string</returns>
        string GetData();
    }
}
