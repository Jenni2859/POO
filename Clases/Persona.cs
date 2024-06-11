using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Persona
    {
        //Está compuesta por:

        // 1. PROPIEDADES o ATRIBUTOS:
        private string cedula;
        private string nombre;
        private double edad;

        // 2. CONSTRUCTORES: constructor de la clase por DEFECTO

        public Persona()
        {
                
        }

        // 2. CONSTRUCTORES: constructor de la clase por PARÁMETROS
        public Persona(string cedula_p, string nombre_p, double edad_p)
        {
            this.cedula = cedula_p;
            this.nombre = nombre_p;
            this.edad = edad_p;
        }

        // MÉTODOS GET de la clase:

        /// <summary>
        /// Método que retorna el nombre de la persona
        /// </summary>
        /// <returns>String(nombre de la persona)</returns>
        public string GetNombre() { return this.nombre; }

        /// <summary>
        /// Método que retorna el numero de cedula de la person
        /// </summary>
        /// <returns>String(cedulo de la persona)</returns>
        public string GetCedula () { return this.cedula; }

        /// <summary>
        /// Método que retorna la edad de la persona
        /// </summary>
        /// <returns>Double(edad de la perona)</returns>
        public double GetEdad () { return this.edad; }


        // MÉTODOS SET de la clase: para establecer valores a los atributos

        /// <summary>
        /// Estable el valor que se le asignará a la cedula
        /// </summary>
        /// <param name="cedula_p">Valor del tipo cadena</param>
        public void SetCedula(string cedula_p) { this.cedula= cedula_p; }

        /// <summary>
        /// Estable el valor que se le asignará al nombre
        /// </summary>
        /// <param name="nombre_p">Valor del tipo cadena</param>
        public void SetNombre(string nombre_p) { this.nombre= nombre_p; }

        /// <summary>
        /// Estable el valor que se le asignará a la edad
        /// </summary>
        /// <param name="edad_p">Valor del tipo double</param>
        public void SetEdad(double edad_p) { this.edad= edad_p;}

        public string ObtenerInfoPersona()
        {
            return $"Ced: {GetCedula()} Nombre: {GetNombre()} Edad: {GetEdad()}";

        }
    }
}
