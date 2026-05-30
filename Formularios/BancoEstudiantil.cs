using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBancario.Controlador;
using SistemaBancario.Entidades;

namespace SistemaBancario.Formularios
{
    public partial class BancoEstudiantil : Form
    {
        ControladorCuenta controlador = new ControladorCuenta();

        public BancoEstudiantil()
        {
            InitializeComponent();
            CargarDatosEjemplo();
            ActualizarTabla();

        }
        private void CargarDatosEjemplo()
        {
            // Cuenta 1: Ahorro
            CuentaAhorro e1 = new CuentaAhorro(); e1.Cedula = "0701234567"; // MISMA CÉDULA
            e1.Nombre = "Tatiana Silva";
            e1.Tipo = "Ahorro";
            e1.Saldo = 500;
            e1.Direccion = "Guabo";
            e1.Telefono = "0888888888";
            controlador.Insertar(e1);

            // Cuenta 2: Corriente (Para la misma persona)
            CuentaCorriente e2 = new CuentaCorriente();
            e2.Cedula = "0701234567"; // MISMA CÉDULA
            e2.Nombre = "Tatiana Silva";
            e2.Tipo = "Corriente";
            e2.Saldo = 1000;
            e2.Direccion = "Pasaje";
            e2.Telefono = "0777777778";
            controlador.Insertar(e2);


            CuentaCorriente e3 = new CuentaCorriente();
            e3.Cedula = "0707654321";
            e3.Nombre = "Juan Perez";
            e3.Tipo = "Corriente";
            e3.Saldo = 1200.00;
            e3.Direccion = "Machala";
            e3.Telefono = "0888888888";
            e3.Edad = 22;
            controlador.Insertar(e3);

           
        }
        private void ActualizarTabla()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controlador.ListaCuentas
                .Select(c => new {
                    c.Numero,
                    c.Cedula,
                    c.Nombre,
                    c.Direccion,
                    c.Telefono,
                    c.Edad,
                    c.Tipo,
                    c.Saldo
                })
                .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAperturadeCuenta f = new frmAperturadeCuenta(controlador);
            f.ShowDialog();
            ActualizarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDespositosRetiros f = new frmDespositosRetiros(controlador);
            f.ShowDialog();
            ActualizarTabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MejorCliente f = new MejorCliente( controlador);

            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var cuenta in controlador.ListaCuentas)
            {
             
                if (cuenta.Tipo == "Ahorro" && cuenta.Saldo >= 10)
                {
                    cuenta.Saldo += (cuenta.Saldo * 0.05);
                    cuenta.PagoInteres = true; // Marcamos que recibió el beneficio
                }
                // Regla Corriente: saldo >= 100 paga 0.09%
                else if (cuenta.Tipo == "Corriente" && cuenta.Saldo >= 100)
                {
                    cuenta.Saldo += (cuenta.Saldo * 0.09);
                    cuenta.PagoInteres = true;
                }
            }

           
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controlador.ListaCuentas
                .Where(x => x.PagoInteres == true)
                .Select(x => new {
                    x.Numero,
                    x.Nombre,
                    x.Tipo,
                    SaldoConInteres = x.Saldo,
                    Estado = "PAGO EXITOSO"
                })
                .ToList();

            MessageBox.Show("Intereses aplicados correctamente a las cuentas que cumplen el saldo mínimo.");
        }

        private void consulta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controlador.ListaCuentas
                .OrderByDescending(c => c.Saldo)
                .Select(c => new { c.Tipo, c.Nombre, c.Saldo, c.Numero })
                .ToList();
        }

        private void consulta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var promedios = controlador.ListaCuentas
        .GroupBy(c => c.Tipo)
        .Select(g => new {
            TipoCuenta = g.Key,
            Promedio = g.Average(c => c.Saldo)
        })
        .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = promedios;
        }

        private void consulta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controlador.ListaCuentas
                .GroupBy(c => c.Cedula)
                .Where(g => g.Count() > 1)
                .Select(g => new {
                    Cliente = g.First().Nombre,
                    Cedula = g.Key,
                    TotalCuentas = g.Count()
                })
                .ToList();
        }

        private void consulta4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double promedioGeneral = controlador.ListaCuentas.Average(c => c.Saldo);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controlador.ListaCuentas
                .Where(c => c.Saldo < promedioGeneral)
                .Select(c => new { c.Nombre, c.Saldo, PromedioGlobal = promedioGeneral })
                .ToList();
        }

        private void consulta5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador.ListaCuentas
        .Where(c => c.Tipo == "Ahorro")
        .ToList()
        .ForEach(c => c.Depositar(50));

            MessageBox.Show("Se han depositado $50 a todas las cuentas de ahorro.");

            // Actualizamos la tabla para ver los nuevos saldos
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controlador.ListaCuentas.ToList();
        }

        private void consulta6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ambosTipos = controlador.ListaCuentas
          .GroupBy(c => c.Cedula)
          .Where(g => g.Any(c => c.Tipo == "Ahorro") && g.Any(c => c.Tipo == "Corriente"))
          .Select(g => new {
              Cliente = g.First().Nombre,
              Cedula = g.Key,
              Mensaje = "Posee Ahorro y Corriente"
          })
          .ToList();

            dataGridView1.DataSource = null;

            if (ambosTipos.Count > 0)
            {
                dataGridView1.DataSource = ambosTipos;
            }
            else
            {
                MessageBox.Show("No se encontraron clientes con ambos tipos de cuenta.");
            }
        }

        private void consulta7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controlador.ListaCuentas
                .GroupBy(c => c.Cedula)
                .Select(g => new {
                    Cliente = g.First().Nombre,
                    CantidadCuentas = g.Count(),
                    SaldoTotal = g.Sum(c => c.Saldo),
                    Promedio = g.Average(c => c.Saldo)
                })
                .ToList();
        }
    }
}

