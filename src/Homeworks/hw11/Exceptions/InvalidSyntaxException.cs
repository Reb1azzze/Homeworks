using System;

namespace hw11.Exceptions
{
    public class InvalidSyntaxException : Exception
    {
        public InvalidSyntaxException(string message)
            : base(message)
        {
        }
    }
}