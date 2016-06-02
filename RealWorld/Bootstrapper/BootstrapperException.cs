namespace RealWorld.Bootstrapper
{
    using System;
    using System.Runtime.Serialization;

    public class BootstrapperException : Exception
    {
        public BootstrapperException(string message)
            : base(message)
        {
        }

        public BootstrapperException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
