using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using dancoTeste1.Droid;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(Database_Android))]
namespace dancoTeste1.Droid
{
    class Database_Android : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "danco3.db3";

            var caminhoDB = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), nomeDB);

            return new SQLiteConnection(caminhoDB);
        }
    }
}