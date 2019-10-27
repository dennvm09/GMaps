using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Department
    {
        private String nameD;
        private String capital;
        private double latitud;
        private double longitud;

        private List<Homicide> homicides;

        public Department(String nameD)
        {
            this.nameD = nameD;
            homicides = new List<Homicide>();
        }

        public Department(String nameD, String capital, double latitud, double longitud)
        {
            this.nameD = nameD;
            this.capital = capital;
            this.latitud = latitud;
            this.longitud = longitud;

        }

        public String NameD { get => nameD; set => nameD = value; }

        public List<Homicide> Homicides { get => homicides; set => homicides = value; }
        public string Capital { get => capital; set => capital = value; }
        public double Latitud { get => latitud; set => latitud = value; }
        public double Longitud { get => longitud; set => longitud = value; }

        public void addHomicide(String municipality, String armaEmpleada, int age, String gender)
        {
            Homicide addN = new Homicide(municipality, armaEmpleada, age, gender);
            homicides.Add(addN);
        }

        public int numeroM()
        {
            int woman = 0;
            for (int i = 0; i < homicides.Count; i++)
            {
                if (homicides[i].isMale() == false)
                {
                    woman += 1;
                }
            }
            return woman;
        }

        public int numeroH()
        {
            int man = 0;
            for (int i = 0; i < homicides.Count; i++)
            {
                Homicide k = homicides[i];
                if (k.isMale() == true)
                {
                    man += 1;
                }
            }
            Console.WriteLine("HOMBRES " + nameD + " " + man);
            return man;
        }

        public int armaBlanca()
        {
            int armaB = 0;
            for (int i = 0; i < homicides.Count; i++)
            {
                Homicide k = homicides[i];
                if (k.ArmaEmpleada.Equals("ARMA BLANCA / CORTOPUNZANTE") == true)
                {
                    armaB += 1;
                }
            }
            return armaB;
        }

        public int armaFuego()
        {
            int armaF = 0;
            for (int i = 0; i < homicides.Count; i++)
            {
                Homicide k = homicides[i];
                if (k.ArmaEmpleada.Equals("ARMA DE FUEGO") == true)
                {
                    armaF += 1;
                }
            }
            return armaF;
        }

        public int adult()
        {
            int adult = 0;
            for (int i = 0; i < homicides.Count; i++)
            {
                Homicide k = homicides[i];
                if (k.isAdult() == true)
                {
                    adult += 1;
                }
            }
            return adult;
        }

        public int kids()
        {
            int kids = 0;
            for (int i = 0; i < homicides.Count; i++)
            {
                Homicide k = homicides[i];
                if (k.isAdult() == false)
                {
                    kids += 1;
                }
            }
            return kids;
        }

    }
}
