using System;

namespace BazeDeDate.Exceptions
{
    public class ConnectionException : Exception
    {
        public ConnectionException(string message) : base(message)
        {
        }
    }
}
