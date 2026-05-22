using System;
using System.Collections.Generic;
using System.Text;

namespace L14_JCAA_1227526
{
    internal class CuentaBancaria
    {
        public string titular;
        public string numeroCuenta;
        public decimal saldo;

        public CuentaBancaria(string titular, string numeroCuenta, decimal saldo)
        {
            this.titular = titular;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
        }
        public void mostrarInformacion()
        {
            Console.WriteLine("El titular es: "+titular + "\nEl numero de cuenta es: "+numeroCuenta + "\nEl saldo es: Q"+saldo);
        }
        public void depositar(decimal monto) {
            saldo += monto;
        }
        public void retirar(decimal monto)
        {
            if (saldo >= monto)
            {
                saldo -= monto;
            }
            else
            {
                Console.WriteLine("El saldo es insuficiente");
            }
        }
    }
}
