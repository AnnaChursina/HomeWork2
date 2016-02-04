using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class CategoryOfDriverException : ApplicationException
    {
        public CategoryOfDriverException()
        {
        }

        public CategoryOfDriverException(string message) : base(message)
        {
        }

        public CategoryOfDriverException(string message, Exception ex) : base(message)
        {
        }

        // Конструктор для обработки сериализации типа
        protected CategoryOfDriverException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex)
        {
        }
    }
}

