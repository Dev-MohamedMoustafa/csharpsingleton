/*
 * this code was written by Mohamed Moustafa
 * As a preview of his knowledge in Design Patterns
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    /// <summary>
    /// Lazy Intialization Singleton
    /// </summary>
    public sealed class Singleton
    {

        #region Constructor
        private Singleton()
        {

        }
        #endregion

        //fields
        private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(() => new Singleton());

        //Methods
        /// <summary>
        /// Using Double Check Locking
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            return Instance.Value;
        }
    }
}


/*
 * this code was written by Mohamed Moustafa
 * As a preview of his knowledge in Design Patterns
 * 
 */