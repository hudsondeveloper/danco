
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.IO;
using System.Linq;
using SQLite;
using dancoTeste1.model;

namespace dancoTeste1.conexao
{
    public class Dados : IDisposable
    {

        private SQLiteConnection bd;
             private static String SQLCLIENTE=
        "CREATE TABLE IF NOT EXISTS pessoa(Id_pessoa INTEGER PRIMARY KEY AUTOINCREMENT," +
        "nome TEXT,"+
        "Email TEXT," +
        "Senha TEXT," +
        "telefone INTEGER);";

        private static String SQLEMPRESA =
        "CREATE TABLE IF NOT EXISTS empresa(Id INTEGER PRIMARY KEY AUTOICREMENTE," +
                "Nome TEXT," +
                "Id_pes INTENGER,"+
                "Email INTENGER," +
                "FOREIGN KEY(Id_pes) REFERENCES pessoa(Id_pessoa));";



        public Dados()
        {
            string dbPath = Path.Combine(
                 Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                 "danco1.db3");
            bd = new SQLiteConnection(dbPath);

            bd.Execute(SQLCLIENTE, SQLEMPRESA);
           // bd.CreateTable<EmpresaPessoa>();
           //bd.CreateTable<Pessoa>();
           // bd.CreateTable<Empresa>();
        }

        public void InserirPessoa(Pessoa Pessoa)
        {
            bd.Insert(Pessoa);
        }

        public void AtualizarPessoa(Pessoa Pessoa)
        {
            bd.Update(Pessoa);
        }

        public Boolean login(Pessoa pessoa)
        {
            return bd.Table<Pessoa>().Any(x => x.Nome == pessoa.Nome && x.Senha == pessoa.Senha);
        }

        public void DeletarPessoa(Pessoa Pessoa)
        {
            bd.Delete(Pessoa);
        }

        public Pessoa GetPessoa(int codigo)
        {
            return bd.Table<Pessoa>().First(x => x.Id_pessoa == codigo);
        }

        public List<Pessoa> GetPessoas()
        {
            return bd.Table<Pessoa>().ToList();
        }

        public void Dispose()
        {
            bd.Dispose();
        }
    }
}
