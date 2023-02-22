using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Departamentos dep = new Departamentos();


            //por tiempo ya no pude realizarlo con el array

            int salir = 1;
            while( salir == 1)
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("Cual es su nombre?");
                dep.nombre = Console.ReadLine();
                Console.WriteLine("Cual es su apellido?");
                dep.apellido = Console.ReadLine();
                Console.WriteLine("Cual es su edad?");
                dep.edad = Convert.ToInt32(Console.ReadLine());
                dep.Departamento();
                Console.WriteLine("Su edad es: " + dep.edad);
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Desea agregar otra persona?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                salir = Convert.ToInt32(Console.ReadLine());
            }

        }


    }

    class Municipio
    {
        public int munOpc;
        public string municipio;
    }

    class Departamentos : Municipio
    {

        public string nombre;
        public string apellido;
        public int edad;
        public int depOpc;
        public string dep;

        public void Departamento()
        {
            Console.WriteLine("Seleccione su departamento: ");
            Console.WriteLine("1. Chalatenango");
            Console.WriteLine("2. Santa Ana");
            Console.WriteLine("3. Ahuachapan");
            Console.WriteLine("4. San Salvador");
            Console.WriteLine("5. Cabanas");
            Console.WriteLine("6. La Paz");
            Console.WriteLine("7. La Union");
            Console.WriteLine("8. Cuscatlan");
            Console.WriteLine("9. San Miguel");
            Console.WriteLine("10. Usulutan");
            Console.WriteLine("11. San Vicente");
            Console.WriteLine("12. Sonsonate");
            Console.WriteLine("13. La Libertad");
            Console.WriteLine("14. Morazan");
            depOpc = Convert.ToInt32(Console.ReadLine());

            if (depOpc == 1 )
            {
                dep = "Chalatenango";
                Console.WriteLine("Seleccione su municipio");
                Console.WriteLine("1. Agua Caliente");
                Console.WriteLine("2. Nueva Concepcion");
                Console.WriteLine("3. Arcatao");
                Console.WriteLine("4. Citala");
                Console.WriteLine("5. Comalapa");
                Console.WriteLine("6. El Paraiso");
                Console.WriteLine("7. La Palma");
                Console.WriteLine("8. La Laguna");
                munOpc = Convert.ToInt32(Console.ReadLine());

                if ( munOpc == 1 )
                {
                    municipio = "Agua Caliente";
                }
                if (munOpc == 2)
                {
                    municipio = "Nueva Concepcion";

                }
                if (munOpc == 3)
                {
                    municipio = "Arcatao";
                }
                if (munOpc == 4)
                {
                    municipio = "Citala";
                }
                if (munOpc == 5)
                {
                    municipio = "Comalapa";
                }
                if (munOpc == 6)
                {
                    municipio = "El Paraiso";
                }
                if (munOpc == 7)
                {
                    municipio = "La Palma";
                }
                if (munOpc == 8)
                {
                    municipio = "La Laguna";
                }

            }
            else if (depOpc == 2)
            {
                dep = "Santa Ana";
                Console.WriteLine("Seleccione su municipio");
                Console.WriteLine("1. El Congo");
                Console.WriteLine("2. Coatepeque");
                Console.WriteLine("3. El Porvenir");
                Console.WriteLine("4. Masahuat");
                Console.WriteLine("5. Metapan");
                Console.WriteLine("6. Texistepeque");
                Console.WriteLine("7. Chalchuapa");
                Console.WriteLine("8. San Antonio Pajonal");
                if (munOpc == 1)
                {
                    municipio = "El Congo";
                }
                if (munOpc == 2)
                {
                    municipio = "Coatepeque";

                }
                if (munOpc == 3)
                {
                    municipio = "El Porvenir";
                }
                if (munOpc == 4)
                {
                    municipio = "Masahuat";
                }
                if (munOpc == 5)
                {
                    municipio = "Metapan";
                }
                if (munOpc == 6)
                {
                    municipio = "Texistepeque";
                }
                if (munOpc == 7)
                {
                    municipio = "Chalchuapa";
                }
                if (munOpc == 8)
                {
                    municipio = "San Antonio Pajonal";
                }
            }
            else if (depOpc == 3)
            {
                dep = "Ahuchapan";
                Console.WriteLine("Seleccione su municipio");
                Console.WriteLine("1. Apaneca");
                Console.WriteLine("2. Atiquizaya");
                Console.WriteLine("3. Concepcion de Ataco");
                Console.WriteLine("4. El Refugio");
                Console.WriteLine("5. Guaymango");
                Console.WriteLine("6. Jujutla");
                Console.WriteLine("7. San Lorenzo");
                Console.WriteLine("8. Tacuba");
                if (munOpc == 1)
                {
                    municipio = "Apaneca";
                }
                if (munOpc == 2)
                {
                    municipio = "Atiquizaya";

                }
                if (munOpc == 3)
                {
                    municipio = "Concepcion de Ataco";
                }
                if (munOpc == 4)
                {
                    municipio = "El Refugio";
                }
                if (munOpc == 5)
                {
                    municipio = "Guaymango";
                }
                if (munOpc == 6)
                {
                    municipio = "Jujutla";
                }
                if (munOpc == 7)
                {
                    municipio = "San Lorenzo";
                }
                if (munOpc == 8)
                {
                    municipio = "Tacuba";
                }
            }
            else if (depOpc == 4)
            {
                dep = "San Salvador";
                Console.WriteLine("Seleccione su municipio");
                Console.WriteLine("1. Aguilares");
                Console.WriteLine("2. Apopa");
                Console.WriteLine("3. Ciudad Delgado");
                Console.WriteLine("4. Cuscatancingo");
                Console.WriteLine("5. El Paisnal");
                Console.WriteLine("6. Guazapa");
                Console.WriteLine("7. Nejapa");
                Console.WriteLine("8. San Martin");
                if (munOpc == 1)
                {
                    municipio = "Aguilares";
                }
                if (munOpc == 2)
                {
                    municipio = "Apopa";

                }
                if (munOpc == 3)
                {
                    municipio = "Ciudad Delgado";
                }
                if (munOpc == 4)
                {
                    municipio = "Cuscatancingo";
                }
                if (munOpc == 5)
                {
                    municipio = "El Paisnal";
                }
                if (munOpc == 6)
                {
                    municipio = "Guazapa";
                }
                if (munOpc == 7)
                {
                    municipio = "Nejapa";
                }
                if (munOpc == 8)
                {
                    municipio = "San Martin";
                }
            }
            else if (depOpc == 5)
            {
                dep = "Cabanas";
                Console.WriteLine("Seleccione su municipio");
                Console.WriteLine("1. Cinquera");
                Console.WriteLine("2. Dolores");
                Console.WriteLine("3. Guacontecti");
                Console.WriteLine("4. Jutiapa");
                Console.WriteLine("5. Ilobasco");
                Console.WriteLine("6. San Isidro");
                Console.WriteLine("7. Tejutepeque");
                Console.WriteLine("8. Victoria");
                if (munOpc == 1)
                {
                    municipio = "Cinquera";
                }
                if (munOpc == 2)
                {
                    municipio = "Dolores";

                }
                if (munOpc == 3)
                {
                    municipio = "Guacontecti";
                }
                if (munOpc == 4)
                {
                    municipio = "Jutiapa";
                }
                if (munOpc == 5)
                {
                    municipio = "Ilobasco";
                }
                if (munOpc == 6)
                {
                    municipio = "San Isidro";
                }
                if (munOpc == 7)
                {
                    municipio = "Tejutepeque";
                }
                if (munOpc == 8)
                {
                    municipio = "Victoria";
                }
            }
            else if (depOpc == 6)
            {
                dep = "La Paz";
                Console.WriteLine("Seleccione su municipio");
                Console.WriteLine("1. El Rosario");
                Console.WriteLine("2. Jerusalen");
                Console.WriteLine("3. Olocuilta");
                Console.WriteLine("4. San Juan Talpa");
                Console.WriteLine("5. San Luis Talpa");
                Console.WriteLine("6. Santiago Nonualco");
                Console.WriteLine("7. San Juan Nonualco");
                Console.WriteLine("8. Cuyultitan");
                if (munOpc == 1)
                {
                    municipio = "El Rosario";
                }
                if (munOpc == 2)
                {
                    municipio = "Jerusalen";

                }
                if (munOpc == 3)
                {
                    municipio = "Olocuilta";
                }
                if (munOpc == 4)
                {
                    municipio = "San Juan talpa";
                }
                if (munOpc == 5)
                {
                    municipio = "San Luis Talpa";
                }
                if (munOpc == 6)
                {
                    municipio = "Santiago Nonualco";
                }
                if (munOpc == 7)
                {
                    municipio = "San Juan Nonualco";
                }
                if (munOpc == 8)
                {
                    municipio = "Cuyultitan";
                }
            }

        }

    }
}

