using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula06.Exemplo.Services
{
    //Define o contrato, os métodos que a classe deve implementar
    interface IMessage
    {
        void EnviarMensagem(string mensagem);
    }
}
