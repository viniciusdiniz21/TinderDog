using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinderDog.Domain.Models
{
    public class Animal
    {
        public int DonoId { get; set; }
        public int Nome { get; set; }
        public string DataNascimento { get; set; }
        public double Peso { get; set; }
        public double Tamanho { get; set; }
        public int RacaId { get; set; }
        public Raca Raca { get; set; }
    }
}
