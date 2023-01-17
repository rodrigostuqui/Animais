using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Animais.Base
{
    public interface IVoar
    {
        int AlturaMaxima { get; }
        double VelocidadeVoo { get; }
        public void Voar();
    }
}
