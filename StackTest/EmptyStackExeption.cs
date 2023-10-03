using System.Runtime.Serialization;

namespace StackTest
{
    [Serializable]
    public  class EmptyStackExeption : Exception
    {
        public EmptyStackExeption() : base("Stack is empty")
        {
        }

        public EmptyStackExeption(string? message) : base(message)
        {
        }

        public EmptyStackExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmptyStackExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}