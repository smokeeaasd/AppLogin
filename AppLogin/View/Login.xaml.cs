using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLogin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            frameLogin.BackgroundColor = Color.FromRgba(255, 255, 255, 0.1);
        }

        
        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            string email = entryEmail.Text;
            string senha = entrySenha.Text;
        }
    }
}