//-----------------------------------------------------------------------
// <copyright file="BookFacadeClass.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatternPrograms.FacadeDesign
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BookFacadeClass as class
    /// </summary>
    public class BookFacadeClass
    {
        /// <summary>
        /// BookClass as class
        /// </summary>
       private BookClass bookClass;

        /// <summary>
        /// BookTypeClass as class
        /// </summary>
       private BookTypeClass bookTypeClass;

        /// <summary>
        /// BookInfoClass as class
        /// </summary>
       private BookInfoClass bookInfo;

        /// <summary>
        /// UserDataClass as class
        /// </summary>
       private UserDataClass userData;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookFacadeClass"/> class.
        /// </summary>
        public BookFacadeClass()
        {
           this.bookClass = new BookClass();
           this.bookTypeClass = new BookTypeClass();
           this.bookInfo = new BookInfoClass();
           this.userData = new UserDataClass();
        }

        /// <summary>
        /// CreateBookFunction as function
        /// </summary>
        public void CreateBookFunction()
        {
            try
            {
                Console.WriteLine("Call all function according to the class");
               this.bookClass.SetOfBook();
               this.bookTypeClass.SetOfBookDetails();
               this.bookInfo.BookInformation();
               this.userData.UserDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
