using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Modelo
{
    public class Principal
    {
        private List<Department> listDepartments;
      
        public Principal()
        {
            listDepartments = new List<Department>();
        }

        public List<Department> ListDepartments { get => listDepartments; set => listDepartments = value; }

        public void addDepartamento()
        {
            StreamReader leer = new StreamReader(Path.GetFullPath("Homicidios_2018.txt"));
            String line = leer.ReadLine();
            try
            {
                while (line != null)
                {
                    String[] element;
                    element = line.Split(',');

                    if (element != null && element.Length == 20)
                    {
                        String departamento = "";
                        if (element[1] != null)
                        {
                            departamento = element[1];
                            Console.WriteLine(departamento);
                        }

                        String municipio = "";
                        if (element[2] != null)
                        {
                            municipio = element[2];
                            Console.WriteLine(municipio);
                        }

                        String armaEmpleada = "";
                        if (element[8] != null)
                        {
                            armaEmpleada = element[8];
                            Console.WriteLine(armaEmpleada);
                        }

                        int edad = 0;
                        if (element[11] != null)
                        {
                            edad = Convert.ToInt32(element[11]);
                            Console.WriteLine(edad);
                        }

                        String genero = "";
                        if (element[12] != null)
                        {
                            genero = element[12];
                            Console.WriteLine(genero);
                        }

                        agregarD(departamento, municipio, armaEmpleada, edad, genero);

                    }
                    line = leer.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public void agregarD(String departamento, String municipio, String armaEmpleada, int edad, String genero)
        {

            Department nuevoD = new Department(departamento);

            int i = listDepartments.Count - 1;

            if (i < 0)
            {
                nuevoD.addHomicide(municipio, armaEmpleada, edad, genero);
                listDepartments.Add(nuevoD);
            }
            else if (i >= 0)
            {

                if (listDepartments[i].NameD.Equals(departamento))
                {
                    listDepartments[i].addHomicide(municipio, armaEmpleada, edad, genero);
                }
                else
                {
                    nuevoD.addHomicide(municipio, armaEmpleada, edad, genero);
                    listDepartments.Add(nuevoD);
                }
            }


        }


        public int HombresT()
        {
            int total = 0;
            for (int i = 0; i < listDepartments.Count; i++)
            {
                total += listDepartments[i].numeroH();
                Console.WriteLine(total);
            }
            return total;
        }

        public int MujeresT()
        {
            int total = 0;
            for (int i = 0; i < listDepartments.Count; i++)
            {
                total += listDepartments[i].numeroM();
                Console.WriteLine(total);
            }
            return total;
        }

        public int kidsT()
        {
            int total = 0;
            for (int i = 0; i < listDepartments.Count; i++)
            {
                total += listDepartments[i].kids();
                Console.WriteLine(total);
            }
            return total;
        }

        public int adultsT()
        {
            int total = 0;
            for (int i = 0; i < listDepartments.Count; i++)
            {
                total += listDepartments[i].adult();
                Console.WriteLine(total);
            }
            return total;
        }

        public int armaFuegoT()
        {
            int total = 0;
            for (int i = 0; i < listDepartments.Count; i++)
            {
                total += listDepartments[i].armaFuego();
                Console.WriteLine(total);
            }
            return total;
        }

        public int armaBlancaT()
        {
            int total = 0;
            for (int i = 0; i < listDepartments.Count; i++)
            {
                total += listDepartments[i].armaBlanca();
                Console.WriteLine(total);
            }
            return total;
        }


    }
}
