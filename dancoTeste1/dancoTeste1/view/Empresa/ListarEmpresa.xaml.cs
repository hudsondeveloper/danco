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
    public partial class ListarEmpresa : ContentPage
    {
        public ListarEmpresa()
        {
            InitializeComponent();

            using (var dados = new Dados())
            {
               
                listEmpresas.ItemsSource = dados.GetEmpresas();
                
            }
        }

        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var itemSelecionado = (model.Empresa)listEmpresas.SelectedItem;
            DetalheEmpresa detalhe = new DetalheEmpresa();
            detalhe.BindingContext = itemSelecionado;
            Navigation.PushAsync(detalhe);
        }

    }
}