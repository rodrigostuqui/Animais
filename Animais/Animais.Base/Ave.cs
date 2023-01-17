using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Base
{
    public abstract class Ave : Animal
    {
        public bool Rapina { get; set; }
        public string CorPena { get; set; }
        public void Ciscar()
            => Console.WriteLine("Ciscando");

        public override string ToString()
        {
            return base.ToString() + $"É de rapina:{this.Rapina}\nCor da pena:{this.CorPena}";
        }
    }
}
