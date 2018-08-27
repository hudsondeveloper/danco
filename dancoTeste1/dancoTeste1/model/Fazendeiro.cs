using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace dancoTeste1.model
{
    public class Fazendeiro
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(100)]
        public string codFazenda { get; set; }
    }
}
