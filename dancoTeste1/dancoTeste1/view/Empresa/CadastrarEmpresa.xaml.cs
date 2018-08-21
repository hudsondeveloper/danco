using dancoTeste1.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dancoTeste1.view.Empresa
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastrarEmpresa : ContentPage
	{
		public CadastrarEmpresa ()
		{
			InitializeComponent ();
		}

        private void cadastro_clicked(object sender,EventArgs e)
        {
            using(var dados = new Dados())
            {
                model.Empresa empresa = new model.Empresa
                {
                    Email = etEmail.Text,
                    Nome = etNome.Text
                };
                try
                {
                    dados.InserirEmpresa(empresa);
                    DisplayAlert("Sucesso", etNome.Text + " cadastrado", "ok");
                }
                catch (Exception)
                {
                    DisplayAlert("Atenção", etNome.Text + " não cadastrado", "ok");
                }

                Navigation.PushAsync(new ListarEmpresa());
            }
        }
    }
}