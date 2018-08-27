using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace dancoTeste1
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
    }
}
