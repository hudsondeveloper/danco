using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace dancoTeste1.model
{
    public class Formulario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Codigo { get; set; }
        [MaxLength(100)]
        public string codFazenda { get; set; }
        [MaxLength(100)]
        public string Tecnico { get; set; }
        [MaxLength(100)]
        public string NomeLavrador { get; set; }
        DateTime data { get; set; }
        public string codQuestao { get; set; }

    }
}
