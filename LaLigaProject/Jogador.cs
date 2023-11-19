using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLigaProject
{
    public class Jogador
    {
        public int Id { get; set; }
        public int TimeId { get; set; }
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public enum Sexo
        {
            Masculino,
            Feminino
        }
        public Sexo Genero { get; set; }
        public string? FotoDoJogador { get; set; }
    }
}
