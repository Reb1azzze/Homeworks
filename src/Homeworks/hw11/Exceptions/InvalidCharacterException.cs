using System;

namespace hw11.Exceptions
{
    public class InvalidCharacterException : Exception
    {
        public InvalidCharacterException(string message)
            : base(message)
        {
        }
    }
}