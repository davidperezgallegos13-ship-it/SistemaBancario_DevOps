using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBancario.Entidades;

namespace SistemaBancario.Controlador
{
    public class ControladorCuenta
    {
        public List<Cuenta> ListaCuentas = new List<Cuenta>();

        public void Insertar(Cuenta c)
        {
            ListaCuentas.Add(c);
        }

        public Cuenta Buscar(string dato)
        {
            return ListaCuentas.FirstOrDefault(x =>
                x.Cedula == dato ||
                x.Numero.ToString() == dato);
        }
    }
}
