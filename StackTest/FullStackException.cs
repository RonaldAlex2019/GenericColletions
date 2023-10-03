using System.Runtime.Serialization;

namespace StackTest
{
    [Serializable]
    public  class FullStackException : Exception
    {
        // parameterless contructor 
        public FullStackException() : base("Stack is full")
        {
        }

        public FullStackException(string? message) : base(message)
        {
        }

        public FullStackException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FullStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}