using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entidades
{
    public class CuentaCorriente : Cuenta
    {
        // APERTURA
        public override bool AperturaCuenta() => Saldo >= 600;

        public override void PagarInteres()
        {
           
            if (Saldo >= 100)
            {
                Saldo += Saldo * 0.09;
                PagoInteres = true; 
            }
        }

        public override bool Retirar(double cantidad)
        {
           
            if (cantidad <= Saldo && (Saldo - cantidad) >= 100)
            {
                Saldo -= cantidad;
                return true;
            }
            return false;
        }
    }

}