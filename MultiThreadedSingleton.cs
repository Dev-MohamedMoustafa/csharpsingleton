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
    /// Multithreaded Singleton
    /// </summary>
    public sealed class Singleton
    {

        #region Constructor
        private Singleton()
        {

        }
        #endregion

        //fields
        private static Singleton Instance = null;
        private static object obj = new object();

        //Methods
        /// <summary>
        /// Using Double Check Locking
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                lock (obj)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                }
            }
            return Instance;
        }
    }
}


/*
 * this code was written by Mohamed Moustafa
 * As a preview of his knowledge in Design Patterns
 * 
 */