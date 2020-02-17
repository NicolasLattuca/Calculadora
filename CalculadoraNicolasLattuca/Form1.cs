using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string auxiliar;//Va a tener los numeros que se ingresan
        double primero;
        double segundo;
        string signo = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            mostrar.Text = "";
            auxiliar = null;
            Deshabilitar();
            parentesisIzquierdo.Enabled = true;
            borrar.Enabled = false;
            sumar.Enabled = true;
            restar.Enabled = true;
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (mostrar.Text != "")//bug de borrar el ultimo
            {
                mostrar.Text = mostrar.Text.Substring(0, mostrar.Text.Length - 1);
                if (auxiliar.Length != 0)
                {
                    auxiliar = auxiliar.Remove(auxiliar.Length - 1);
                }

            }
            else if (mostrar.Text == "")
            {
                primero = 0;
                segundo = 0;
                signo = "";
                auxiliar = "";
            }


        }
        public void eliminarUltimo()
        {


        }
        private void igual_Click(object sender, EventArgs e)
        {
            segundo = Double.Parse(auxiliar);
            mostrar.Text = Operacion.obtenerResultado(primero, segundo, signo).ToString();
            auxiliar = Operacion.obtenerResultado(primero, segundo, signo).ToString();
            signo = "";
            parentesisIzquierdo.Enabled = true;
            parentesisDerecho.Enabled = false;
            //Deshabilitar(); no cumple 2+2=4+2
        }

        private void mostrar_TextChanged(object sender, EventArgs e)
        {

        }
        public void Habilitar()
        {
            sumar.Enabled = true;
            restar.Enabled = true;
            multiplicar.Enabled = true;
            dividir.Enabled = true;
            coma.Enabled = true;
            igual.Enabled = true;
            borrar.Enabled = true;
        }
        public void Deshabilitar()
        {
            sumar.Enabled = false;
            restar.Enabled = false;
            multiplicar.Enabled = false;
            dividir.Enabled = false;
            coma.Enabled = false;
            igual.Enabled = false;
            parentesisIzquierdo.Enabled = false;
        }
        private void uno_Click(object sender, EventArgs e)
        {
            multParentesis();
            mostrar.Text += "1";
            auxiliar += "1";
            Habilitar();
        }

        private void dos_Click(object sender, EventArgs e)
        {
            multParentesis();
            mostrar.Text += "2";
            auxiliar += "2";
            Habilitar();
        }

        private void tres_Click(object sender, EventArgs e)
        {
            multParentesis();
            mostrar.Text += "3";
            auxiliar += "3";
            Habilitar();
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            multParentesis();
            mostrar.Text += "4";
            auxiliar += "4";
            Habilitar();
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            multParentesis();
            mostrar.Text += "5";
            auxiliar += "5";
            Habilitar();
        }

        private void seis_Click(object sender, EventArgs e)
        {
            multParentesis();
            mostrar.Text += "6";
            auxiliar += "6";
            Habilitar();
        }

        private void siete_Click(object sender, EventArgs e)
        {
            multParentesis();
            mostrar.Text += "7";
            auxiliar += "7";
            Habilitar();
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            multParentesis();
            mostrar.Text += "8";
            auxiliar += "8";
            Habilitar();
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            multParentesis();
            mostrar.Text += "9";
            auxiliar += "9";
            Habilitar();
        }

        private void cero_Click(object sender, EventArgs e)
        {
            multParentesis();
            mostrar.Text += "0";
            auxiliar += "0";
            Habilitar();
        }

        private void coma_Click(object sender, EventArgs e)
        {

            mostrar.Text += ",";
            auxiliar += ",";
            Deshabilitar();
        }

        private void sumar_Click(object sender, EventArgs e)
        {

            agregarOperador("+");
            Deshabilitar();
        }

        private void restar_Click(object sender, EventArgs e)
        {
            agregarOperador("-");
            Deshabilitar();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            agregarOperador("*");
            Deshabilitar();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            agregarOperador("/");
            Deshabilitar();
        }
        public void agregarOperador(string operador)
        {


            if (!signo.Equals(""))
            {
                segundo = Double.Parse(auxiliar);
                primero = Operacion.obtenerResultado(primero, segundo, signo);

            }
            else if (auxiliar == null)
            {
                primero = 0;
                signo = operador;
            }
            else
            {

                primero = Double.Parse(auxiliar);
            }
            auxiliar = "";
            signo = operador;
            mostrar.Text += operador;
        }

        private void parentesisIzquierdo_Click(object sender, EventArgs e)
        {

            if (parentesisDerecho.Visible == false)
            {
                agregarOperador("*");
            }
            mostrar.Text += "(";
            Deshabilitar();
            parentesisDerecho.Enabled = true;
            parentesisDerecho.Visible = true;
            //parentesisIzquierdo.Visible = false;
        }

        private void parentesisDerecho_Click(object sender, EventArgs e)
        {
            //Deshabilitar();
            mostrar.Text += ")";
            //signo = "*";
            parentesisIzquierdo.Enabled = true;
            parentesisDerecho.Visible = false;
            //parentesisIzquierdo.Visible = true;

        }
        private void multParentesis()
        {
            if (mostrar.Text.Length >= 2)
            {
                if (mostrar.Text.Substring(mostrar.Text.Length - 1, 1) == ")")
                {
                    agregarOperador("*");
                }
            }
        }
    }
}

