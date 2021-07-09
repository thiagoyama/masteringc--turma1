using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula06.Exemplo.Exceptions
{
    //exception -> tab tab

    [Serializable]
    public class MensagemInvalidaException : Exception
    {
        public MensagemInvalidaException() { }
        public MensagemInvalidaException(string message) : base(message) { }
        public MensagemInvalidaException(string message, Exception inner) : base(message, inner) { }
        protected MensagemInvalidaException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
