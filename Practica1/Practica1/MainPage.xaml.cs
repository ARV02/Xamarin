using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections;

namespace Practica1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ArrayList datos = new ArrayList();
        public MainPage()
        {
            InitializeComponent();
        }

        private void buscar_Clicked(object sender, EventArgs e)
        {
            String buscar = nombre.Text;
            bool encontrado = false;
            foreach(Personas dato in datos)
            {
                if (dato.Nombre.Equals(buscar))
                {
                    horas.Text = dato.Horas.ToString();
                    sueldo.Text = dato.Sueldo.ToString();
                    DisplayAlert("Tu sueldo", (dato.Sueldo * dato.Horas).ToString(), "Aceptar");
                    encontrado = true;

                }
                if (!encontrado)
                {
                    DisplayAlert("Error", "No encontrado", "Aceptar");
                }
            }
        }

        private void agregar_Clicked(object sender, EventArgs e)
        {
            String nombred = nombre.Text;
            int horasd = Convert.ToInt32(horas);
            double sueldod = Convert.ToDouble(sueldo);
            Personas personas = new Personas(nombred,horasd,sueldod);
            datos.Add(personas);
            nombre.Text = null;
            horas.Text = null;
            sueldo.Text = null;

        }

        private void limpiar_Clicked(object sender, EventArgs e)
        {
            //datos.Clear();
            nombre.Text = null;
            horas.Text = null;
            sueldo.Text = null;
        }
    }
}
