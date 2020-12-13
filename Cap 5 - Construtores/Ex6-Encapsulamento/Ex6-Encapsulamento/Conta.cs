using System;
using System.Globalization;


namespace Ex6_Encapsulamento
{
    class Conta
    {
        // Atributos privados

        // Propriedades autoimplementadas
        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        public string Nome { get; set; }

        //Construtores
        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }
        public Conta(int numero, string nome, double depInicial) : this(numero, nome)
        {
            // Preferivel não usar "Saldo = depinicial" pois a regra de depósito é definida no método Depositar;
            Depositar(depInicial);
        }

        // Propriedades customizadas

        // Outros métodos da classe
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            Saldo -= valor + 5.0;
        }
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
