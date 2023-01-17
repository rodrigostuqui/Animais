using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Base
{
    public interface IVoar
    {
        int AlturaMaxima { get; }
        double VelocidadeVoo { get; }
        public void Voar()
            => Console.WriteLine($"Estou voando, posso chegar a uma altitude de {this.AlturaMaxima} e uma velocidade de {this.VelocidadeVoo}!");
    }
}
