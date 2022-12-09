using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btniniciar_Clicked(object sender, EventArgs e)
        {
            string name = Name.Text;
            string ocupation = Ocupacion.Text;
            string date = Birthday.Text;
            string email = Email.Text;
            string phone = Phone.Text;
            string nationality = Nacionalidad.Text;
            string level = Level.Text;
            string perfil = Perfil.Text;
            Navigation.PushAsync(new Page1( name, ocupation, date, email, phone, nationality,  level, perfil));
        }
    }
}
