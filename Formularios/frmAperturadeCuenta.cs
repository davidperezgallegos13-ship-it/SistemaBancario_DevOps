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
    public partial class frmAperturadeCuenta : Form
    {
        ControladorCuenta controlador;

        
        public frmAperturadeCuenta(ControladorCuenta c)
        {
            InitializeComponent();

            controlador = c;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Cuenta cuenta;

            if (comboBox1.Text == "Ahorro")
            {
                cuenta = new CuentaAhorro();
            }
            else
            {
                cuenta = new CuentaCorriente();
            }

            // Asignación de datos
            cuenta.Cedula = textBox1.Text;
            cuenta.Nombre = textBox2.Text;
            cuenta.Direccion = textBox3.Text;
            cuenta.Telefono = textBox4.Text;
            cuenta.Edad = int.Parse(textBox5.Text);
            cuenta.Tipo = comboBox1.Text;
            cuenta.Saldo = double.Parse(textBox6.Text);

            if (cuenta.AperturaCuenta())
            {
                // Se guarda en la lista del controlador, pero la ventana sigue abierta
                controlador.Insertar(cuenta);
                MessageBox.Show("Datos guardados exitosamente. Ahora puede imprimir.");

                // Deshabilitamos guardar para que no lo pulse dos veces
                button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Saldo mínimo incorrecto.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                MessageBox.Show("Imprimiendo comprobante de apertura...");
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Primero debe guardar los datos.");
            }
        }

    }
}

