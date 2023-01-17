using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Base
{
    public abstract class Reptil : Animal
    {
        public bool Escamas { get; set; }
        public bool Casco { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Tem escamas:{this.Escamas}\nTem Casco:{this.Casco}";
        }
    }
}
