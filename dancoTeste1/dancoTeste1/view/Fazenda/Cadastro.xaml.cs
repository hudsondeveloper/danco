using dancoTeste1.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dancoTeste1.view.Fazenda
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
                model.Fazenda fazenda = new model.Fazenda
                {
                    Nome = this.etNome.Text,
                    codFazenda = this.etFazenda.Text
                };
                try
                {
                    dados.InserirFazenda(fazenda);
                    DisplayAlert("Sucesso","fazenda "+ etNome.Text + " cadastrado", "ok");
                }
                catch (Exception)
                {
                    DisplayAlert("Atenção", "fazenda " + etNome.Text + " não cadastrado", "ok");
                }

                Navigation.PopAsync();
            }
        }
    }
}