using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula05.Exemplo.Models
{
    class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }

        public override void CadastrarEndereco(string endereco)
        {
            Console.WriteLine("Cadastrando endereço PJ");
            Endereco = endereco;
        }

    }
}
