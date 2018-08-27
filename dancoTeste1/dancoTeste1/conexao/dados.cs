
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
        public static string userNome;
        private SQLiteConnection _database;


        public Dados()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Pessoa>();
            _database.CreateTable<Fazendeiro>();
            _database.CreateTable<Fazenda>();
            _database.CreateTable<Formulario>();
            _database.CreateTable<Questao>();
        }

        public string Logado()
        {
            return userNome;  
        }

        public void Deslogar()
        {
             userNome="";
        }

        public void InserirPessoa(Pessoa Pessoa)
        {
            _database.Insert(Pessoa);
        }

        public void InserirFazendeiro(Fazendeiro fazendeiro)
        {
            _database.Insert(fazendeiro);
        }

        public void InserirFazenda(Fazenda fazenda)
        {
            _database.Insert(fazenda);
        }

        public void InserirFormulario(Formulario formulario)
        {
            _database.Insert(formulario);
        }


        public void AtualizarPessoa(Pessoa Pessoa)
        {
            _database.Update(Pessoa);
        }

        public Boolean login(Pessoa pessoa)
        {
            userNome = pessoa.Nome;
            return _database.Table<Pessoa>().Any(x => x.Nome == pessoa.Nome && x.Senha == pessoa.Senha);
        }

        public void DeletarPessoa(Pessoa Pessoa)
        {
            _database.Delete(Pessoa);
        }

        public Pessoa GetPessoa(int codigo)
        {
            return _database.Table<Pessoa>().First(x => x.Id_pessoa == codigo);
        }

        public List<Pessoa> GetPessoas()
        {
            return _database.Table<Pessoa>().ToList();
        }

        public List<Fazendeiro> GetFazendeiros()
        {
            return _database.Table<Fazendeiro>().ToList();
        }

        public List<Fazenda> GetFazendas()
        {
            return _database.Table<Fazenda>().ToList();
        }


        public void Dispose()
        {
            _database.Dispose();
        }
    }
}
