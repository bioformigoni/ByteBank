namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;
        public double Saldo // Primeira letra maiúscula é convenção para propriedades
        {
            get
            {
                return _saldo; // Underline é convenção para campo privado de apenas uma classe
            }

            set
            {
                // O valor não é passado por argumento e sim na variavel value
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        // Tem valor de retorno = função
        public bool Sacar(double valor)
        {
            if (_saldo < valor) // "this" indica uma váriável do escopo da própria classe
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        // Não tem valor de retorno = método
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }

        }
    }
}
