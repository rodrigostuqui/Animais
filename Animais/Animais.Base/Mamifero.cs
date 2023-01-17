using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Base
{
    public abstract class Mamifero : Animal
    {
        public int QuantidadeDeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorDoPelo { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Quantidade de Mamas:{this.QuantidadeDeMamas}\nPelos:{this.Pelos}\nCor do Pelo:{CorDoPelo}";
        }
    }
}
