using Fiap.Aula06.Exemplo.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula06.Exemplo.Services
{
    //Classe implementa a interface
    class SmsMessage : IMessage
    {
        public void EnviarMensagem(string mensagem)
        {
            //Validar se a mensagem tem menos de 10 caractesres e lançar a MensagemInvalidaException
            if (mensagem.Length < 10)
                throw new MensagemInvalidaException("Mensagem com menos de 10 caracteres");
            Console.WriteLine($"Enviando um sms: {mensagem}");
        }
    }
}
