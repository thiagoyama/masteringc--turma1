using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula05.Exemplo.Models
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public Genero Sexo { get; set; }

        public override void CadastrarEndereco(string endereco)
        {
            Endereco = endereco;
        }

    }
}
