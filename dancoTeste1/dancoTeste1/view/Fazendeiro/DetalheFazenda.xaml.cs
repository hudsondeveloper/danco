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
    public partial class DetalheFazenda : ContentPage
    {
        public DetalheFazenda(List<model.Fazenda> fazendas)
        {
            InitializeComponent();
            listFazendas.ItemsSource = fazendas;

        }

        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            List<model.Fazendeiro> fazendeiros = null;
            string noveLavrador = "";
            string tecnico = "";
            var itemSelecionado = (model.Fazenda)listFazendas.SelectedItem;
            using (var dados = new Dados())
            {
                fazendeiros = dados.GetFazendeiros().Where(x => x.codFazenda == itemSelecionado.codFazenda).ToList();
                noveLavrador = fazendeiros.Select(x => x.Nome).First().ToString();
                tecnico = dados.Logado();
            }
            Navigation.PushAsync(new Formulario.Cadastrar(itemSelecionado.codFazenda, noveLavrador, tecnico));
        }
    }
}