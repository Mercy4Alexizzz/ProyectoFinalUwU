using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalUwU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operaciones obj= new Operaciones();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(Valor1.Text) && !obj.IsNumeric(Valor2.Text))
            {
                lblshowresult.Text = "Ingrese un valor valido";
            }
            else
            {
                int suma = obj.Suma(Convert.ToInt32(Valor1.Text), Convert.ToInt32(Valor2.Text));
                lblshowresult.Text = Convert.ToString(suma);
            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(Valor1.Text) && !obj.IsNumeric(Valor2.Text))
            {
                lblshowresult.Text = "Ingrese un valor valido";
            }
            else
            {
                int resta = obj.Resta(Convert.ToInt32(Valor1.Text), Convert.ToInt32(Valor2.Text));
                lblshowresult.Text = Convert.ToString(resta);
            }

        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(Valor1.Text) && !obj.IsNumeric(Valor2.Text))
            {
                lblshowresult.Text = "Ingrese un valor valido";
            }
            else
            {
                int mult = obj.Multiplicar(Convert.ToInt32(Valor1.Text), Convert.ToInt32(Valor2.Text));
                lblshowresult.Text = Convert.ToString(mult);
            }
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(Valor1.Text) && !obj.IsNumeric(Valor2.Text))
            {
                lblshowresult.Text = "Ingrese un valor valido";
            }
            else
            {
                int division = obj.Division(Convert.ToInt32(Valor1.Text), Convert.ToInt32(Valor2.Text));
                lblshowresult.Text = Convert.ToString(division);
            }
        }
    }
}
