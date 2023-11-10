using System.Runtime.Serialization;

namespace EjercicioIntegrador2_YouTify.Exceptions
{
    [Serializable]
    internal class EDatabaseConnectionException : Exception
    {
        public EDatabaseConnectionException()
        {
        }

        public EDatabaseConnectionException(string? message) : base(message)
        {
        }

        public EDatabaseConnectionException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EDatabaseConnectionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}