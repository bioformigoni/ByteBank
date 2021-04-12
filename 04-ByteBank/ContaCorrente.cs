public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;
    
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

}