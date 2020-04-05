using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_EFCore_Migration.Models
{
    public class Batalha
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public List<HeroiBatalha> HeroisBatalhas { get; set; }

    }
}
