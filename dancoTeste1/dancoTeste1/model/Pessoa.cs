using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace dancoTeste1.model
{
    [Table("pessoa")]
    public class Pessoa
    {
        [PrimaryKey, AutoIncrement]
        public int Id_pessoa { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Senha { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}", Nome, Email);
        }
    }
}
