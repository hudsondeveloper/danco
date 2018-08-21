using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dancoTeste1.model
{
    [Table("empresa")]
    public class Empresa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public int Id_pes { get; set; }
        public List<Pessoa> Pessoas { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}", Nome, Email);
        }
    }
}
