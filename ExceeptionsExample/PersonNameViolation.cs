using System;

namespace ExceptionsExample
{
    class NameContentViolationException : Exception
    {
        public NameContentViolationException()
        {
        }

        public NameContentViolationException(String message) : base(message)
        {
        }

        public NameContentViolationException(String message, Exception e) : base(message, e)
        {
        }

    }

}
