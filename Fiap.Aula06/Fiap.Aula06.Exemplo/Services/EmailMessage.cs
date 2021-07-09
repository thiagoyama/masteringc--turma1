using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula06.Exemplo.Services
{
    //Classe implementa a interface
    class EmailMessage : IMessage
    {
        public void EnviarMensagem(string mensagem)
        {
            //Mensagem não pode ter menos do que 5 caracteres
            if (mensagem.Length < 5)
            {
                //Lança uma exception, "retorna" o objeto da exceção
                throw new Exception("Número de caracteres inválido");
            }
            Console.WriteLine($"Enviando e-mail: {mensagem}");
        }
    }
}
