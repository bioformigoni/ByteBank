namespace _06_ByteBank
{
    public class ContaCorrente
    {

        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;


        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0) 
            {
                return;
            }
            
            this.saldo = saldo;
        }

        public double ObterSaldo() 
        {
            return saldo;
        }

        // Tem valor de retorno = função
        public bool Sacar(double valor)
        {
            if (saldo < valor) // "this" indica uma váriável do escopo da própria classe
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
            saldo += valor;
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
