using dancoTeste1.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dancoTeste1.view.Formulario
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastrar : ContentPage
	{
       public string teste1 = "";
		public Cadastrar (string codFazenda,string nomeLavrador,string nomeTecnico)
		{
			InitializeComponent ();
		}

        private void onToggledSwitchq1a(object sender, ToggledEventArgs e)
        {
            teste1 = e.Value.ToString();
        }
        private void teste_clicked(object sender,EventArgs e)
        {
            DisplayAlert("teste", teste1, "ok");
            model.Formulario form = new model.Formulario();
           // form.q1a = q1a.;
            using (var dados = new Dados())
            {
                //model.Fazendeiro fazendeiro = new model.Fazendeiro
                //{
                //    Nome = this.etNome.Text,
                //    codFazenda = this.etFazenda.Text
                //};
                //try
                //{
                //    dados.InserirFazendeiro(fazendeiro);
                //    DisplayAlert("Sucesso", etNome.Text + " cadastrado", "ok");
                //}
                //catch (Exception)
                //{
                //    DisplayAlert("Atenção", etNome.Text + " não cadastrado", "ok");
                //}

                //Navigation.PopAsync();
            }

        }

    }
}