using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace dancoTeste1.model
{
    public class EmpresaPessoa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int EmpresaId { get; set; }
    }
}
