using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entidades
{
    public class CuentaAhorro : Cuenta
    {
        public override bool AperturaCuenta() => Saldo >= 0;

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
