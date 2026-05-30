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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaBancario.Formularios
{
    public partial class MejorCliente : Form
    {
        ControladorCuenta controlador;

        // CONSTRUCTOR
        public MejorCliente(ControladorCuenta c)
        {
            InitializeComponent();

            controlador = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mejorAhorro = controlador.ListaCuentas
         .Where(c => c.Tipo == "Ahorro")
         .OrderByDescending(c => c.Saldo)
         .FirstOrDefault();

            // 2. Llenamos los campos del primer GroupBox (Ahorros)
            if (mejorAhorro != null)
            {
                textBox2.Text = mejorAhorro.Numero.ToString();
                textBox3.Text = mejorAhorro.Nombre;
                textBox4.Text = mejorAhorro.Tipo;
                textBox5.Text = mejorAhorro.Saldo.ToString();
            }
            else
            {
                MessageBox.Show("No existen cuentas de ahorro registradas.");
            }

            // 3. Buscamos el mejor cliente de Cuenta Corriente usando LINQ
            var mejorCorriente = controlador.ListaCuentas
                .Where(c => c.Tipo == "Corriente")
                .OrderByDescending(c => c.Saldo)
                .FirstOrDefault();

            // 4. Llenamos los campos del segundo GroupBox (Corriente)
            if (mejorCorriente != null)
            {
                textBox8.Text = mejorCorriente.Numero.ToString();
                textBox7.Text = mejorCorriente.Nombre;
                textBox6.Text = mejorCorriente.Tipo;
                textBox1.Text = mejorCorriente.Saldo.ToString();
            }
            else
            {
                MessageBox.Show("No existen cuentas corrientes registradas.");
            }
        }
    }

}
      
