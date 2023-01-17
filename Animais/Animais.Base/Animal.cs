using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Base
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public DateTime DataDoNascimento { get; set; }
        public char Sexo { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }
        public int Idade()
            => (int)Math.Floor((DateTime.Now - DataDoNascimento).TotalDays / 365);
        public abstract void Comunicar();
        public abstract void Movimentar();
        public abstract void Alimentar();

        public override string ToString()
        {
            return $"Nome:{this.Nome}\nData Do Nascimento:{this.DataDoNascimento}\nSexo:{this.Sexo}\nCarnivoro:{this.Carnivoro}\nPeconhento:{this.Peconhento}\n";
        }
    }
}
