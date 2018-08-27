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
	public partial class FormulariosFazenda : ContentPage
	{
		public FormulariosFazenda ()
		{
			InitializeComponent ();
		}

        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var itemSelecionado = (model.Fazendeiro)listFazendeiros.SelectedItem;

            //using (var dados = new Dados())
            //{
            //    List<model.Fazenda> fazendas = dados.GetFazendas();
            //    List<model.Fazenda> fazendasFiltrada = fazendas.Where(x => x.codFazenda.Equals(itemSelecionado.codFazenda)).ToList();
            //    Navigation.PushAsync(new DetalheFazenda(fazendasFiltrada));

            //}
        }
    }
}