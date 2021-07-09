using Fiap.Aula06.Exemplo.Exceptions;
using Fiap.Aula06.Exemplo.Services;
using System;

namespace Fiap.Aula06.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tratamento da exception
            try
            {
                //Ler um número
                Console.WriteLine("Digite um número");
                var numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Número inválido");
            }
            //finally -> sempre executa, não é obrigatório no bloco try-catch
            finally
            {
                Console.WriteLine("Sempre executa");
            }

            //Ler a mensagem
            Console.WriteLine("Digite a mensagem");
            var msg = Console.ReadLine();

            //Interface -> diminuir o acoplamento (dependência) entre os objetos
            //Instanciar um EmailMessage
           IMessage message = new SmsMessage();

            try
            {
                //Chamar o método de enviar mensagem
                message.EnviarMensagem(msg);
            }
            //Sempre a exception mais específica primeiro, as genéricas depois
            catch (MensagemInvalidaException e)
            {
                Console.WriteLine($"Erro: " + e.Message);
            }
            catch (Exception e)
            {
                //Exibe a mensagem definida na criação e lançamento da exception
                Console.WriteLine(e.Message);
            }

        }
    }
}
