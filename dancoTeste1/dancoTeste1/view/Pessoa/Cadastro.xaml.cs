using dancoTeste1.conexao;
using dancoTeste1.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dancoTeste1.view
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
		public Cadastro ()
		{
			InitializeComponent ();
		}

        private void cadastro_clicked(object sender, EventArgs e)
        {
             using(var dados = new Dados())
            {
                model.Pessoa pessoa = new model.Pessoa
                {
                    Nome = this.etLogin.Text,
                    Senha = this.etSenha.Text,
                    Email = this.etEmail.Text
                };
                try
                {
                dados.InserirPessoa(pessoa);
                DisplayAlert("Sucesso", etLogin.Text + " cadastrado", "ok");
                }catch (Exception)
                {
                    DisplayAlert("Atenção", etLogin.Text + " não cadastrado", "ok");
                }

                Navigation.PopAsync();
            }
        }

    }
}