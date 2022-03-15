using System;

namespace App.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : this("Validation Error occured")
        {
        }

        public ValidationException(Exception exception) : this(exception.Message)
        {
        }

        public ValidationException(string message) : base(message)
        {
        }
    }
}