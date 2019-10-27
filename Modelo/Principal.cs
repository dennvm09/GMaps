using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Modelo
{
    public class Principal
    {
        private List<Department> listDepartments;
        private List<Department> departments;
        private Department departamento;


        public Principal()
        {
            departments = new List<Department>();
            listDepartments = new List<Department>();
            departamento = null;
        }

        public List<Department> ListDepartments { get => listDepartments; set => listDepartments = value; }
        public List<Department> Departments { get => departments; set => departments = value; }

        public void latLonDepartments()
        {
            StreamReader leer = new StreamReader(Path.GetFullPath("Departamentos.txt"));
            String line = leer.ReadLine();

            try
            {
                while(line != null)
                {
                    String[] element;
                    element = line.Split(',');

                    String departamento = "";
                    String capital = "";
                    double latitud = 0;
                    double longitud = 0;

                    if (element != null && element.Length == 4)
                    {
                        if(element[0] != null)
                        {
                            departamento = element[0];
                            Console.WriteLine(departamento);
                        }

                        if (element[1] != null)
                        {
                            capital = element[1];
                            Console.WriteLine(capital);
                        }

                        if (element[2] != null)
                        {
                            latitud = Double.Parse(element[2], CultureInfo.InvariantCulture);
                            Console.WriteLine(latitud);
                        }

                        if (element[3] != null)
                        {
                            longitud = Double.Parse(element[3], CultureInfo.InvariantCulture);
                            Console.WriteLine(longitud);
                        }

                        


                        Department depar = new Department(departamento, capital, latitud, longitud);

                        departments.Add(depar);

                 
                    }

                    line = leer.ReadLine();

                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }





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
                            
                        }

                        String municipio = "";
                        if (element[2] != null)
                        {
                            municipio = element[2];
                           
                        }

                        String armaEmpleada = "";
                        if (element[8] != null)
                        {
                            armaEmpleada = element[8];
                            
                        }

                        int edad = 0;
                        if (element[11] != null)
                        {
                            edad = Convert.ToInt32(element[11]);
                            
                        }

                        String genero = "";
                        if (element[12] != null)
                        {
                            genero = element[12];
                            
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



        public void agregarDep(String dep, String cap, double lat, double lon)
        {
            Department nuevoD = new Department(dep, cap, lat, lon);

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

        public int generoDepartment(int genero, String departamentoB)
        {
            int total = 0;
            BusquedaDepartments(listDepartments, departamentoB);
            if (genero == 1)
            {   
                total = departamento.numeroH();
            }else if (genero == 2)
            {
                total = departamento.numeroM();
            }

            return total;
        }

        public int ArmaDepartments(int tipoArama, String departamentoB)
        {
            int total = 0;
            BusquedaDepartments(listDepartments, departamentoB);
            if (tipoArama == 1)
            {
                total = departamento.armaBlanca();
            }
            ///arma de fuego = 2
            else if (tipoArama == 2)
            {
                total = departamento.armaFuego();
            }
            return total;
        }

        public int edadDepartment(int edad, String departamentoB)
        {
            int total = 0;
            BusquedaDepartments(listDepartments, departamentoB);
            if (edad == 1)
            {
                total = departamento.adult();
            }
            /// niños
            else if (edad == 2)
            {
                total = departamento.kids();
            }

            return total;
        }

        public void BusquedaDepartments(List<Department> depas, String buscarS)
        {
            int izq, der, centro;
            izq = 0;
            der = depas.Count - 1;
            centro = (izq + der) / 2;

            while (buscarS != depas[centro].NameD && izq < der) {
                int comparacion = buscarS.CompareTo(depas[centro].NameD);
                if (comparacion > 0) {
                    izq = centro + 1;
                }else if (comparacion < 0)
                {
                    der = centro - 1;
                }
                centro = (izq + der) / 2;
            }
            if (buscarS == depas[centro].NameD)
            {
                departamento = depas[centro];
            }
            else {
                Console.WriteLine("Departamento no encontrado");
            }
         

        }


    }
}
