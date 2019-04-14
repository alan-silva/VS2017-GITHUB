//using _05_ByteBank;

namespace ByteBank
{
    public class ContaCorrente
    {

       public static int TotalDeContasCriadas { get; private set; }

       
        private Cliente _titular;
        private int _agencia;
        private int _numero;
        private double _saldo = 100;

        public int Numero { get; set; }
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }

        public Cliente Titular { get; set; }
  

        public double Saldo
        {
            get
            {
               return _saldo;
            }
            set 
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }
        
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;

            }
        }

        public void Despositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            contaDestino.Despositar(valor);
            return true;

        }





    }
}