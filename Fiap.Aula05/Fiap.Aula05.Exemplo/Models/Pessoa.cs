using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula05.Exemplo.Models
{
    //Classe abstrata -> não pode ser instanciada e pode definir métodos abstratos (sem implementação)
    public abstract class Pessoa
    {
        //Propriedades
        public string Nome { get; set; }
        public string Endereco { get; set; }

        //Métodos
        public abstract void CadastrarEndereco(string endereco);

        public void InformarNome()
        {
            Console.WriteLine("Informe o nome");
            Nome = Console.ReadLine();
        }

    }
}
