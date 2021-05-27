using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Exceptions
{
    public class InsertIntoException : Exception
    {
        #region Constructor
        public InsertIntoException(string message) : base(message)
        {

        }
        #endregion
    }
}
