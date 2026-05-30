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
    public partial class frmDespositosRetiros : Form
    {
        ControladorCuenta controlador;

        // CUENTA ENCONTRADA
        Cuenta cuenta;

        // CONSTRUCTOR
        public frmDespositosRetiros(ControladorCuenta c)
        {
            InitializeComponent();

            controlador = c;
        }

        // BOTON BUSCAR
        private void button1_Click(
            object sender,
            EventArgs e)
        {
            cuenta =
                controlador.Buscar(
                    textBox1.Text);

            if (cuenta != null)
            {
                textBox2.Text =
                    cuenta.Numero.ToString();

                textBox3.Text =
                    cuenta.Nombre;

                textBox4.Text =
                    cuenta.Tipo;

                textBox5.Text =
                    cuenta.Saldo.ToString();
            }
            else
            {
                MessageBox.Show(
                    "Cuenta no encontrada");
            }
        }

        // BOTON REALIZAR TRANSACCION
        private void button2_Click(
            object sender,
            EventArgs e)
        {
            double cantidad =
        double.Parse(
            textBox6.Text);

            // DEPOSITO
            if (radioButton1.Checked)
            {
                cuenta.Depositar(
                    cantidad);

                MessageBox.Show(
                    "Deposito realizado correctamente\n" +
                    "Nuevo saldo: $" +
                    cuenta.Saldo);
            }

            // RETIRO
            else if (radioButton2.Checked)
            {
                if (cuenta.Retirar(
                    cantidad))
                {
                    MessageBox.Show(
                        "Retiro realizado correctamente\n" +
                        "Nuevo saldo: $" +
                        cuenta.Saldo);
                }
                else
                {
                    MessageBox.Show(
                        "No se puede realizar el retiro\n" +
                        "Saldo insuficiente o saldo menor a $100");
                }
            }

            // ACTUALIZAR SALDO
            textBox5.Text =
                cuenta.Saldo.ToString();
        }
        


        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

