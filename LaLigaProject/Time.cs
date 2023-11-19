using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLigaProject
{
    public class Time
    {
        public int Id { get; set; }
        public string NomeDoTime { get; set; }
        public string PaisDeOrigem { get; set; }
        public string CampoSede { get; set; }
        public DateTime AnoDeCriacao { get; set; }
        public List <Jogador> Jogadores { get; set; }
    }
}
