using dancoTeste1.conexao;
using dancoTeste1.view.Ajuda;
using dancoTeste1.view.Configuração;
using dancoTeste1.view.Empresa;
using dancoTeste1.view.Home;
using dancoTeste1.view.Logout;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dancoTeste1.view.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public Page1()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            menuList = new List<MasterPageItem>();
            // incluindo items de menu e definindo : title ,page and icon
            menuList.Add(new MasterPageItem() { Title = "Home", Icon = "home.png", TargetType = typeof(HomePage) });
            menuList.Add(new MasterPageItem() { Title = "Listar Pessoas", Icon = "settings.png", TargetType = typeof(ListarPessoa) });
            //menuList.Add(new MasterPageItem() { Title = "LogOut", Icon = "logout.png", TargetType = typeof(LogoutPage) });
            menuList.Add(new MasterPageItem() { Title = "Cadastrar Empresa", Icon = "logout.png", TargetType = typeof(CadastrarEmpresa) });
            menuList.Add(new MasterPageItem() { Title = "Sair", Icon = "help.png", TargetType = typeof(Sair) });
            // Configurando o ItemSource fpara o ListView na MainPage.xaml
            paginaMestreList.ItemsSource = menuList;
            // navegação inicial
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }
        // Evento para a seleção de item no menu
        // trata a seleção do usuário no ListView
        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            if (page.Name=="Sair")
            {
             var answer = await DisplayAlert("Logout", "Deseja sair ? ", "Yes", "No");
                if (answer)
                {
                    using (var dados =  new Dados()){
                        dados.Deslogar();
                    await Navigation.PushAsync(new MainPage());
                    }
                }
            }else
                {
                    Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                    IsPresented = false;
                }
        }
    }
}
