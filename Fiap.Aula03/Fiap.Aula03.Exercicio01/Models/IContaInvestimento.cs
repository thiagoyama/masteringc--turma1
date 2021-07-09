using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula03.Exercicio01.Models
{
    interface IContaInvestimento
    {
        decimal CalcularRetornoInvestimento(decimal taxa);
    }
}
