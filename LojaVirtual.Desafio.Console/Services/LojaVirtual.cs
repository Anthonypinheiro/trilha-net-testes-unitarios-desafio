namespace LojaVirtual.Core
{
    public class DescontoService
    {
        public decimal AplicarDesconto(decimal valor, bool isVip)
        {
            if (isVip)
            {
                return valor * 0.90m; // Aplica 10% de desconto
            }
            return valor;
        }
    }
}
