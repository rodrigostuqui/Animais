using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Animais.Base
{
    public class Mamifero : Animal
    {
        public int QuantidadeDeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorDoCabelo { get; set; }

    }
}
