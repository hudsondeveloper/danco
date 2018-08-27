using dancoTeste1.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dancoTeste1.view.Fazendeiro
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
            using (var dados = new Dados())
            {
                model.Fazendeiro fazendeiro = new model.Fazendeiro
                {
                    Nome = this.etNome.Text,
                    codFazenda = this.etFazenda.Text
                };
                try
                {
                    dados.InserirFazendeiro(fazendeiro);
                    DisplayAlert("Sucesso", etNome.Text + " cadastrado", "ok");
                }
                catch (Exception)
                {
                    DisplayAlert("Atenção", etNome.Text + " não cadastrado", "ok");
                }

                Navigation.PopAsync();
            }
        }
    }
}