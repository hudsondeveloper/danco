using dancoTeste1.conexao;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dancoTeste1.view.Home
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            Dados dados = new Dados();
            logado.Text += dados.Logado();
		}
        public void VerifyInternet(object sender, EventArgs e)
        {
            Status.Text = CrossConnectivity.Current.IsConnected ? "Connected" : "Disconnected";
        }

    }
}