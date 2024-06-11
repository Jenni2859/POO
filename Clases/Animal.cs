using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    internal class Animal
    {
      
        /// <summary>
        /// Obtiene y establece el id del animal
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Obtiene y establece la raza del animal
        /// </summary>
        public string raza { get; set; }

        /// <summary>
        /// Obtiene y establece la edad del animal
        /// </summary>
        public double edadAnimal { get; set; }

        /// <summary>
        /// Constructor por defecto de la clase
        /// </summary>
        public Animal() { }

       
        public Animal(string id, string raza, double edadAnimal)
        {
            this.id = id;
            this.raza = raza;
            this.edadAnimal = edadAnimal;
        }
    }
}
