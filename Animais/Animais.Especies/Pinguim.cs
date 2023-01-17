using Animais.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Especies
{
    public class Pinguim : Ave, IAquatico, IOviparo
    {

        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }

        public bool AguaDoce { get; set; }

        public Pinguim(string nome, DateTime nascimento, char sexo, string corPena)
        {
            this.Nome = nome;
            this.DataDoNascimento = nascimento;
            this.Sexo = sexo;
            this.Peconhento = false;
            this.Carnivoro = true;
            this.CorPena = corPena;
            this.Rapina = false;
            this.ViveEmTerra = true;
            this.Mergulho = true;
            this.AguaDoce = false;
        }
        public override void Alimentar()
        {
            Console.WriteLine("Joga um peixe ai");
        }

        public void Botar()
        {
            Console.WriteLine("Consigo botar em torno de 1 a 2 ovos");
        }

        public void Chocar()
        {
            Console.WriteLine("Crack, Nasceu um novo Pinguim");
        }

        public override void Comunicar()
        {
            Console.WriteLine("ahn ahn ahn");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Vou dar uma mergulhada!");
        }


    }
}
