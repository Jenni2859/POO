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

            txtIDAnimal.Text = "";
            txtRaza.Text = "";
            txtEdadAnimal.Text = "";


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtIDAnimal.Text = "";
            txtRaza.Text = "";
            txtEdadAnimal.Text = "";

            CajaImprimir.Rows.Clear();

            //MessageBox.Show($"Id: {animal.id} Raza: {animal.raza} Edad: {animal.edadAnimal}");
            //CajaImprimir.Rows.Add(animal.id, animal.raza, animal.edadAnimal);

            for(int i = 0; i < animalitos.Count; i++)
            {
                CajaImprimir.Rows.Add(animalitos[i].id, animalitos[i].raza, animalitos[i].edadAnimal);
            }

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
            btnImprimir_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDAnimal.Text))
            {
                if (CajaImprimir.SelectedRows.Count > 0)
                {
                    string borrar = (string)CajaImprimir.SelectedCells[0].Value;
                    DialogResult opcionUsuario = MessageBox.Show($"Estas seguro de eliminar a {CajaImprimir.SelectedCells[0].Value}?",
                    "Advertencia", MessageBoxButtons.YesNo);
                    switch (opcionUsuario)
                    {
                        case DialogResult.Yes:

                            DataGridViewRow filaseleccionada = CajaImprimir.SelectedRows[0];
                            var idPerroEliminar = filaseleccionada.Cells["id"].Value.ToString();

                            animalitos.RemoveAll(animalRegistrado => animalRegistrado.id == idPerroEliminar);
                            break;
                        case DialogResult.No:
                            break;


                    }
                }
                else
                {
                    MessageBox.Show("Debes especifiar un id de animal o seleccionar una fila");
                }

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
            btnImprimir_Click(sender, e);


        }

        private void txtIDAnimal_Click(object sender, EventArgs e)
        {
            

            if (txtIDAnimal.Text == "ID")
            {
                txtIDAnimal.Clear();

                txtIDAnimal.ForeColor = Color.Black;
            }
        }

        private void txtRaza_Click(object sender, EventArgs e)
        {
            if (txtRaza.Text == "Raza")
            {
                txtRaza.Clear();
                txtRaza.ForeColor = Color.Black;    
            }
        }

        private void txtEdadAnimal_Click(object sender, EventArgs e)
        {
            if (txtEdadAnimal.Text == "Edad")
            {
                txtEdadAnimal.Clear();
                txtEdadAnimal.ForeColor= Color.Black;
            }
        }
    }
}
