using dancoTeste1.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dancoTeste1.model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using dancoTeste1.view.Pessoa;

namespace dancoTeste1.view.Fazendeiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarFazendeiro : ContentPage
    {
        private string Fazenda = "";
        public ListarFazendeiro()
        {
            InitializeComponent();
            //using (var dados = new Dados())
            //{

            //    List<FazendaLavrador> fazendaLavradror = new List<FazendaLavrador>();
            //    foreach (var tudo in dados.GetFazendeiros())
            //    {
            //        FazendaLavrador fazendeiro = new FazendaLavrador();
            //        fazendeiro.nome = tudo.Nome;
            //        var fazendas = dados.GetFazendas();
            //        fazendeiro.fazenda = fazendas.Where(x => x.codFazenda == tudo.codFazenda).First().Nome;
            //        fazendaLavradror.Add(fazendeiro);
            //    }

            //    listFazendeiros.ItemsSource = fazendaLavradror.ToList();
            //}

            using (var dados = new Dados())
            {
                IEnumerable<model.Fazendeiro> fazendeiros = dados.GetFazendeiros();
                listFazendeiros.ItemsSource = fazendeiros;
            }
        }

        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var itemSelecionado = (model.Fazendeiro)listFazendeiros.SelectedItem;
  
            using (var dados = new Dados())
            {
                List<model.Fazenda> fazendas = dados.GetFazendas();
                List<model.Fazenda> fazendasFiltrada = fazendas.Where(x => x.codFazenda.Equals(itemSelecionado.codFazenda)).ToList();
                Navigation.PushAsync(new DetalheFazenda(fazendasFiltrada));

            }
        }
    }
}