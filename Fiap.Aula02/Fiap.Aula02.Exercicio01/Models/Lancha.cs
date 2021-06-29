using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula02.Exercicio01.Models
{
    class Lancha
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Comprimento { get; set; }
        public Cor Cor { get; set; }
        public float Peso { get; set; }
        public decimal Valor { get; set; }
        public float AlturaCarreta { get; set; }
        public int QuantidadeMotores { get; set; }
    }
}
