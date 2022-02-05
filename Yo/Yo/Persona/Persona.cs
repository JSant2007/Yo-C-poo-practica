using System;

namespace Yo.Persona
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public char genero;
        
        public char Genero
        {
            get { return Convert.ToChar(genero); }
            set { genero = value; }
        }
            
        public string personalidad { get; set; }
        
        public Persona(string nombre, int año)
        {
            this.nombre = nombre;
            this.edad = año;
        }
        
        public override string ToString()
        {
            return $"Nombre: {nombre}, edad: {edad} ";
        }

    }
}