using POO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPOO_Click(object sender, EventArgs e)
        {

            Persona persona2 = new Persona("12345","Jenifer",19); 
            
            txtNombre.Text = persona2.GetNombre();
            txtCedula.Text = persona2.GetCedula();
            txtEdad.Text = persona2.GetEdad().ToString();


        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Persona persona1 = new Persona();
            persona1.SetCedula(txtCedula.Text);
            persona1.SetNombre(txtNombre.Text);
            persona1.SetEdad(Convert.ToDouble(txtEdad.Text));

            MessageBox.Show(persona1.ObtenerInfoPersona());

        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.raza = txtRaza.Text;
            animal.id = txtIDAnimal.Text;
            animal.edadAnimal = Convert.ToDouble(txtEdadAnimal.Text);

            Console.WriteLine($"{animal.id} {animal.raza} {animal.edadAnimal}"); 
        }
    }
}
