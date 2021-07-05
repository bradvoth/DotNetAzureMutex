using System;

namespace Interfaces
{
    public class LockFailedException : Exception
    {
        public LockFailedException(string description, Exception innerException) : base(description, innerException)
        {
        }

        public LockFailedException(string description) : base(description)
        {
        }
    }
}