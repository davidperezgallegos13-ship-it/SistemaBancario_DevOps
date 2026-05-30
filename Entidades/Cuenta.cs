using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entidades
{
    public class Cuenta : Persona
    {
        private static int contador = 1;

        public int Numero { get; set; }
        public double Saldo { get; set; }
        public string Tipo { get; set; }
        public bool PagoInteres { get; set; }

        public Cuenta()
        {
            Numero = contador++;
            PagoInteres = false;
        }

        public virtual bool AperturaCuenta()
        {
            return true;
        }

        public void Depositar(double monto)
        {
            if (monto <= 0) throw new ArgumentException("El monto a depositar debe ser mayor a cero.");
            Saldo += monto;
        }

        public virtual bool Retirar(double monto)
        {
            if (monto <= 0) throw new ArgumentException("El monto a retirar debe ser mayor a cero.");
            if (monto > Saldo) throw new InvalidOperationException("Fondos insuficientes para realizar el retiro.");

            Saldo -= monto;
            return true;
        }

        public virtual void PagarInteres()
        {
        }
    }

    public class CuentaAhorro : Cuenta
    {
        public override bool AperturaCuenta() => Saldo >= 100;

        public override void PagarInteres()
        {
            if (Saldo >= 10)
            {
                Saldo += Saldo * 0.05;
                PagoInteres = true;
            }
        }
    }
}
