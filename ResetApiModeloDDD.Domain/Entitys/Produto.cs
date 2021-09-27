
namespace ResetApiModeloDDD.Domain.Entitys
{
    //hedando a Base da base
    public class Produto : Base
    {
        public string Nome { get; set; }

        public decimal Valor { get; set; }
        public bool isDisponivel { get; set; }

    }
}
