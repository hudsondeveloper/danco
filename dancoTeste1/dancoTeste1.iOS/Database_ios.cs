using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using Foundation;
using UIKit;

namespace dancoTeste1.iOS
{
    public class Database_ios : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "projeto04.db3";

            var personalFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string LibraryFolder = Path.Combine(personalFolder, "..", "Library");

            string caminhoDB = Path.Combine(LibraryFolder, nomeDB);
            return new SQLiteConnection(caminhoDB);
        }

    }
}