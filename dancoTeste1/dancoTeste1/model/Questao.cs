using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace dancoTeste1.model
{
    class Questao
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string codQuestao { get; set; }
        public string codPergunta { get; set; }
        public string Pergunta { get; set; }
        public Boolean Resposta { get; set; }
        public string respostaTexto { get; set; }

    }
}
