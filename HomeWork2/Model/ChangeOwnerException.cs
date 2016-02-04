using System;

namespace Model
{
    [Serializable]
    public class ChangeOwnerException : ApplicationException
    {
        public ChangeOwnerException()
        {
        }

        public ChangeOwnerException(string message) : base(message)
        {
        }

        public ChangeOwnerException(string message, Exception ex) : base(message)
        {
        }

        // Конструктор для обработки сериализации типа
        protected ChangeOwnerException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex) : base(info, contex)
        {
        }
    }
}