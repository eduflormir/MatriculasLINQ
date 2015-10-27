using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionCoches
{
    class Program
    {

        private static List<Coche> lista = new List<Coche>()
            {
                new Coche()
                {
                    Matricula = "ABCD123451",
                    Modelo = "IBIZA",
                    Fabricacion = 2000

                },
                new Coche()
                {
                    Matricula = "ABCD123441",
                    Modelo = "IBIZA",
                    Fabricacion = 2000

                },
                new Coche()
                {
                    Matricula = "ABCD123431",
                    Modelo = "IBIZA",
                    Fabricacion = 2000

                },
                new Coche()
                {
                    Matricula = "ABCD123442",
                    Modelo = "IBIZA",
                    Fabricacion = 2000

                },

                new Coche()
                {
                    Matricula = "ABCD123452",
                    Modelo = "CORDOBA",
                    Fabricacion = 2001

                },

                new Coche()
                {
                    Matricula = "ABCD123453",
                    Modelo = "LEON",
                    Fabricacion = 2002

                },
                new Coche()
                {
                    Matricula = "ABCD123454",
                    Modelo = "ASTRA",
                    Fabricacion = 2015

                },
                new Coche()
                {
                    Matricula = "ABCD123455",
                    Modelo = "CORSA",
                    Fabricacion = 2014

                },
                new Coche()
                {
                    Matricula = "ABCD123456",
                    Modelo = "CHEVY",
                    Fabricacion = 2013

                },
        };


        static void Main(string[] args)
        {
            int r = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Matricula");
                Console.WriteLine("2. Fabricacion");
                Console.WriteLine("3. Modelo");
                Console.WriteLine("4. Salir");
                Console.Write("Eleccion: ");
                r = Convert.ToInt32(Console.ReadLine());

                switch (r)
                {
                    case 1:
                        matricula();
                        break;
                    case 2:
                        fabricacion();
                        break;
                    case 3:
                        modelo();
                        break;
                }

            } while (r != 4);

        }

        private static void matricula()
        {

            Console.Write("Matricula a buscar: ");
            var mat = Console.ReadLine();
            
            // buscar coche por matricula
            // FirstOrDefault regresa un objeto
            
            try
            {
                var coche = lista.First(o => o.Matricula.Equals(mat));
                Console.WriteLine(coche);
            }
            catch (Exception e)
            {
                Console.WriteLine("Vehiculo no encontrado: "+e.Message);

            }

            Console.WriteLine("    Pulsa una tecla para continuar   ");

            Console.ReadLine();
            
        }

        private static void fabricacion()
        {
            Console.Write("Fabricado en:");
            var f = Convert.ToInt32(Console.ReadLine());

            var data = lista.Where(o => o.Fabricacion == f)
                .OrderByDescending(o => o.Modelo)
                .ThenByDescending(o => o.Matricula);

            if (!data.Any())
                Console.WriteLine("Ningun coche disponible");


            foreach (var coch in data)
            {
                Console.WriteLine(coch);
            }


        }
        
        private static void modelo()
        {
            Console.Write("Año de Fabricado en: ");
            var f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Modelo: ");
            var m = Console.ReadLine();

            var data = lista.Where(o => o.Fabricacion == f &&
                                    o.Modelo == m)
                .OrderByDescending(o => o.Matricula);

            if(!data.Any())
                Console.WriteLine("No hay registros que mostrar! \n");

            foreach (var coch in data)
            {
                Console.WriteLine(coch);
            }

        }

    }
}
