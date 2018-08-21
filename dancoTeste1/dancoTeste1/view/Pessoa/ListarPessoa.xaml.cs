using dancoTeste1.conexao;
using dancoTeste1.model;
using dancoTeste1.view.Pessoa;
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
    public partial class ListarPessoa : ContentPage
    {
        public ListarPessoa()
        {
            InitializeComponent();

            using (var dados = new Dados())
            {
                for(int i = 0; i < 100; i++)
                {
                listPessoas.ItemsSource = dados.GetPessoas();
                }
            }
        }

        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var itemSelecionado = (model.Pessoa)listPessoas.SelectedItem;
            Detalhe detalhe = new Detalhe();
            detalhe.BindingContext = itemSelecionado;
            Navigation.PushAsync(detalhe);
        }

    }
}