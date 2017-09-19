using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Datos", "USTED ES: "  +  Nombre.Text  +  "  "  +  Ape_pat.Text  + "  "  +  Ape_mat.Text  +  "    SU DIRECCION ES:"  +  Direccion.Text  +  "     SU TELEFONO ES:"   +  Telefono.Text  +  "    CURSA LA CARRERA DE:"  +  Carrera.Text  +  "     EN EL SEMESTRE:"  + Semestre.Text  +  "     SU MATRICULA ES:"  +  Matricula.Text  +  "      DATOS DE CONTACTO:"  +  Correo.Text + "   Y  " +  Github.Text,"ok");
        }
    }
}
