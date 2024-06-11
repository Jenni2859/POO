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
        Animal animal = new Animal();

        List<Animal> animalitos = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPOO_Click(object sender, EventArgs e)
        {

            Persona persona2 = new Persona("12345", "Jenifer", 19);

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

            animal.raza = txtRaza.Text;
            animal.id = txtIDAnimal.Text;
            animal.edadAnimal = Convert.ToDouble(txtEdadAnimal.Text);


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Id: {animal.id} Raza: {animal.raza} Edad: {animal.edadAnimal}");


        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // creamo la instancia de la clase con los valore que tienen los txt
            Animal animalitoGuardar = new Animal(
                txtIDAnimal.Text, txtRaza.Text, Convert.ToDouble(txtEdadAnimal.Text));

            animalitos.Add(animalitoGuardar);
            txtIDAnimal.Text = "";
            txtRaza.Text = "";
            txtEdadAnimal.Text = "";

            Console.WriteLine("----------------------- Imprimiendo animalitos -----------------------");

            foreach (Animal animal in animalitos)
            {
                Console.WriteLine(animal.ObtenerInfoAnimal());
            }
            Console.WriteLine("--------------------- Fin de impresión animalitos ---------------------");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDAnimal.Text))
            {
                MessageBox.Show("Debes especifiar un id de animal");
            }
            else
            {
                animalitos.RemoveAll(animalRegistrado => animalRegistrado.id == txtIDAnimal.Text);
                Console.WriteLine("-------------------------------- Animalito eliminado---------------------------------------");

                foreach (Animal animal in animalitos)
                {

                    Console.WriteLine(animal.ObtenerInfoAnimal());
                }
                Console.WriteLine("--------------------------------Fin de impresión de animalitos---------------------------------------");

                txtIDAnimal.Text = "";
                txtRaza.Text = "";
                txtEdadAnimal.Text = "";

            }
        }
    }
}
