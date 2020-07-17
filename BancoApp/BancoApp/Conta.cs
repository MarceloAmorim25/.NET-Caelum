using System;

namespace BancoApp
{
    internal class Conta
    {

        public int Numero { get; internal set; }

        public double Saldo { get; private set; }

        public Cliente Titular { get; internal set; }

        internal void Deposita(double operacao)
        {
            throw new NotImplementedException();
        }
    }
}