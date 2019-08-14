using System;

namespace Modelo
{

    public class Homicide
    {
        private String municipality;
        private String armaEmpleada;
        private int age;
        private String gender;

        public Homicide(String municipality, String armaEmpleada, int age, String gender)
        {
            this.municipality = municipality;
            this.armaEmpleada = armaEmpleada;
            this.age = age;
            this.gender = gender;
        }

        public String Municipality { get => municipality; set => municipality = value; }

        public String ArmaEmpleada { get => armaEmpleada; set => armaEmpleada = value; }

        public int Age { get => age; set => age = value; }

        public String Gender { get => gender; set => gender = value; }

        public Boolean isMale()
        {
            return gender.Equals("MASCULINO");
        }

        public Boolean isAdult()
        {
            return (age >= 18);
        }

    }
}
