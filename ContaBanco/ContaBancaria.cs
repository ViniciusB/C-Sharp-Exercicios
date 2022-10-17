using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ContaBanco
{
    public class ContaBancaria
    {
        public int Numero { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public int TaxaDeSaque = 5;

        public ContaBancaria(int numeroConta, string titular)
        {
            Numero = numeroConta;
            NomeTitular = titular;
        }
        public ContaBancaria(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }
        public double Deposito(double deposito)
        {
            return Saldo += deposito;
        }
        public double Saque(double saque)
        {
            return Saldo -= saque + TaxaDeSaque; 
        }
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + NomeTitular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
