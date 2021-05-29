/**************************************************************************
 *                                                                        *
 *  File:        InsertIntoException.cs                                   *
 *  Copyright:   (c) 2021, Paraschiv Florin-Vladut                        *
 *  E-mail:      florin-vladut.paraschiv@student.tuiasi.ro                *
 *  Description: Exception for inserting into Oracle db                   *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;

namespace DataBase.Exceptions
{
    public class InsertIntoException : Exception
    {
        #region Constructor
        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="message"> the message of the exception </param>
        public InsertIntoException(string message) : base(message)
        {

        }
        #endregion
    }
}
