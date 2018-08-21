using dancoTeste1.conexao;
using dancoTeste1.model;
using dancoTeste1.view;
using dancoTeste1.view.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace dancoTeste1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void cadastro_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }

        private async void login_clicked(object sender, EventArgs e)
        {
            using (var dados = new Dados())
            {
                var pessoa = new Pessoa
                {
                    Nome = this.etLogin.Text,
                    Senha = this.etSenha.Text
                };

                if (dados.login(pessoa))
                {
                 await  Navigation.PushAsync(new Page1());                
                }
                else
                {
                await DisplayAlert("Atenção", etLogin.Text + " não esta cadastrado em nosso banco de dados", "ok");
                }

            }
        }
    }
}
