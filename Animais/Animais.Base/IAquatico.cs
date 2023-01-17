using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Base
{
    public interface IAquatico
    {
        bool ViveEmTerra { get; }
        bool Mergulho { get; }
        bool AguaDoce { get; }
    }
}
