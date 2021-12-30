using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace figuras_examen
{
    public partial class Form1 : Form
    {
        validacion v = new validacion();
        int m, mx, my;
        //se crean los botones para cerrar, minimizar, restaurar y maximizar la ventana
        public Form1()
        {
            InitializeComponent();
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }
        //tablas de multiplicar
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtTabla.Text != "" || txtLimite.Text != "")
            {
                listBox1.Items.Clear();
                int Tabla = int.Parse(txtTabla.Text);
                int Limite = int.Parse(txtLimite.Text);
                int resultado;
                if (Tabla > 10 || Limite > 20)
                {
                    MessageBox.Show("Los valores de (Tabla) deben estar dentro del rango de 0 y 10" +
                        "\ny los valores de (Limite) entre 0 y 20");
                }
                else
                {
                    for (int i = 1; i <= Limite; i++)
                    {
                        resultado = Tabla * i;
                        listBox1.Items.Add(Tabla + " X " + i + " = " + resultado);
                    }
                }
            }
            else {
                MessageBox.Show("Ingrese números");
            }
        }
        //inicio del calculo de areas
        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            if (txtLadoCua1.Text != "" || txtLadoCua2.Text != "")
            {
                int Lado1 = int.Parse(txtLadoCua1.Text);
                int Lado2 = int.Parse(txtLadoCua2.Text);
                int resultado;
                resultado = Lado1 * Lado2;
                AreaCuadrado.Text = Convert.ToString(resultado + " cm²");
            }
            else {
                MessageBox.Show("Ingrese números");
            }
        }
        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            if (txtBaseTrian.Text != "" || txtAlturaTrian.Text != "")
            {
                double Base = Convert.ToDouble(txtBaseTrian.Text);
                double Altura = Convert.ToDouble(txtAlturaTrian.Text);
                double Resultado = (Base * Altura) / 2;
                AreaTriangulo.Text = Convert.ToString(Resultado + " cm²");
            }
            else {
                MessageBox.Show("Ingrese números");
            }
        }
        private void btnPentagono_Click(object sender, EventArgs e)
        {
            if (txtApotemaPenta.Text != "" || txtLadoPenta.Text != "")
            {
                double Lado = Convert.ToDouble(txtLadoPenta.Text);
                double Apotema = Convert.ToDouble(txtApotemaPenta.Text);
                double Perimetro = Lado * 5;
                double Resultado = (Perimetro * Apotema) / 2;
                AreaPentagono.Text = Convert.ToString(Resultado + " cm²");
            }
            else {
                MessageBox.Show("Ingrese números");
            }
        }
        private void btnCirculo_Click(object sender, EventArgs e)
        {
            if (txtRadioCirculo.Text != "")
            {
                double Radio = Convert.ToDouble(txtRadioCirculo.Text);
                double Resultado = Math.PI * Math.Pow(Radio, 2);
                AreaCirculo.Text = Convert.ToString(Resultado + " cm²");
            }
            else {
                MessageBox.Show("Ingrese números");
            }
        }
        //fin del cálculo de áreas

        //en esta parte estan los botones con los que puedes moverte entre secciones
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            txtTabla.Clear();
            txtLimite.Clear();
            listBox1.Items.Clear();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
        //muestra la fecha y hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToShortTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }
        // valida si se ingresaron numeros
        private void txtTabla_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e) 
        {
            v.SoloNumeros(e);
        }
        private void txtLadoCua1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
        private void txtLadoCua2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
        private void txtBaseTrian_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
        private void txtAlturaTrian_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
        private void txtLadoPenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
        private void txtApotemaPenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
        private void txtRadioCirculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        //permite mover la ventana
        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        private void pnlTitulo_MouseHover(object sender, EventArgs e)
        {
            if (m == 1) {
                this.SetDesktopLocation(MousePosition.X -mx, MousePosition.Y - my);
            }
        }
        private void pnlTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}