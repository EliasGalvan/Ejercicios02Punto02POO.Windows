using Ejercicios02Punto02POO.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios02Punto02POO.Windows
{
    public partial class FrmEjercicios02Punto02 : Form
    {
        public FrmEjercicios02Punto02()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cono cono = new Cono();
                var generatriz = double.Parse(GeneratrizTextBox.Text);
                if (generatriz > 0)
                {
                    cono.Generatriz = generatriz;
                    var altura = double.Parse(AlturaTextBox.Text);
                    if (altura > 0 )
                    {
                        cono.Altura = altura;
                        var radio = double.Parse(RadioTextBox.Text);
                        if (radio > 0)
                        {
                            cono.Radio = radio;
                            MessageBox.Show($"Área :{ cono.GetArea()}" + Environment.NewLine + $"Volumen: {cono.GetVolumen()}");
                            Borar();
                        }
                        else
                        {
                            MessageBox.Show("El radio debe ser mayor a cero");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La altura debe ser mayor a cero");
                    }
                }else
                {
                    MessageBox.Show("La generatriz debe ser mayor a cero");
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Debe ingresar los 3 valores");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Numeros demaciado grandes");
            }
        }

        public void Borar()
        {
            GeneratrizTextBox.Clear();
            AlturaTextBox.Clear();
            RadioTextBox.Clear();
            GeneratrizTextBox.Focus();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Borar();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
