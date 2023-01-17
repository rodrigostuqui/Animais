using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animais.Especies;

var arara = new Arara("Junin", DateTime.Now, 'M', "Azul", 10, 165.3D);
arara.Botar();
arara.Ciscar();
arara.Alimentar();
Console.WriteLine(arara);
