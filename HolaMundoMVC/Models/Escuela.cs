using HolaMundoMVC.Models;
using System.Collections.Generic;

namespace HolaMundoMVC.Models
{
    public class Escuela: ObjetoEscuelaBase
    {

        public int AñoDeCreacion{get;set;}

        public string Pais{get;set;}
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        
        public TiposEscuela TipoEscuela{get;set;}

        public List<Curso> Cursos {get;set;}


        public Escuela(){}

        
        public Escuela (string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
        public Escuela (string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            //asignación de tuplas
            (Nombre, AñoDeCreacion) = (nombre, año);
            this.Pais = pais;
            this.Ciudad = ciudad;
        }

        public override string ToString()
        {                                                 //esto es igual a '\n' 
            return $"Nombre:{Nombre}, Tipo:{TipoEscuela} {System.Environment.NewLine} Pais:{Pais}, Ciudad:{Ciudad}";
        }

        

    }
}