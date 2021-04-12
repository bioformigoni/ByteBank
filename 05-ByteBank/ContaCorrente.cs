namespace _05_ByteBank
{
    public class ContaCorrente
    {

        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        // Tem valor de retorno = função
        public bool Sacar(double valor)
        {
            if (this.saldo < valor) // "this" indica uma váriável do escopo da própria classe
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        // Não tem valor de retorno = método
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }

        }
    }
}
