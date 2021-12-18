using System;
namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
       
        public static int TotalDeContasCriadas { get; private set; }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value >= 0)
                {
                    _agencia = value;
                }
            }
        }

        private double _saldo;
        public Double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value > 0)
                {
                    _saldo = value;
                }
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            bool saque = this.Sacar(valor);

            if (saque)
            {
                contaDestino.Depositar(valor);
            }

            return saque;
        }
    }
}
