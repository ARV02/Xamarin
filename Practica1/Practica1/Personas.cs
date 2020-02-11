using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    class Personas
    {
        private String nombre;
        private int horas;
        private double sueldo;
        public Personas(String nombre, int horas, double sueldo)
        {
            this.nombre = nombre;
            this.horas = horas;
            this.sueldo = sueldo;

        }
        public String Nombre
        {
            set;get;
        }
        public int Horas
        {
            set;get;
        }
        public double Sueldo
        {
            set;get;
        }
    }
}
