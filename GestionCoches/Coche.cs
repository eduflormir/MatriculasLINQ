using System;

namespace GestionCoches
{
    public class Coche
    {
        public String Matricula { get; set; }
        public String Modelo { get; set; }
        public int Fabricacion { get; set; }

        public override string ToString()
        {
            return String.Format("Modelo: {0} Matricula: {1} y año de fabricacion: {2}", Modelo, Matricula, Fabricacion);

        }
    }
}
