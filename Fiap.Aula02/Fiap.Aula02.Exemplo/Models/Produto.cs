
namespace Fiap.Aula02.Exemplo.Models
{
    public class Produto
    {
        //Atributos
        private int _id;
        
        //Getters e Setters (Propriedades)
        public string Nome { get; set; }// padrão null

        public decimal Valor { get; set; } //números padrão é 0

        public Fabricante Fabricante { get; set; } //Classes padrão null

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //Métodos
        //Calcular o valor do produto com desconto e retornar o valor calculado
        public decimal CalcularDesconto(decimal porcentagem)
        {
            return Valor - Valor * porcentagem /100;
        }

        //"Cadastrar" um produto, não recebe e não retorna nenhuma informação
        public void Cadastrar()
        {
            System.Console.WriteLine("Produto sendo cadastrado..");
        }
    }
}
