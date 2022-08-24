using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppLogin.Model;

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

            foreach (DadosUsuario usuario in Usuarios.ListaUsuarios)
            {
                if ((usuario.Email == email) && (usuario.Senha == senha))
                {
                    Navigation.PushAsync(new Protegida());
                    return;
                }
                DisplayAlert("Aviso", "Email ou senha incorretos", "ok");
            }
        }
    }
}