using Animais.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Especies
{
    internal class Ornitorrinco : Mamifero, IAquatico, IOviparo
    {
        public bool ViveEmTerra { get; set; }

        public bool Mergulho { get; set; }

        public bool AguaDoce { get; set; }

        public Ornitorrinco(string nome, DateTime nascimento, char sexo, string corDoPelo)
        {
            this.Nome = nome;
            this.AguaDoce = true;
            this.Carnivoro = true;
            this.CorDoPelo = corDoPelo;
            this.Mergulho = true;
            this.DataDoNascimento = nascimento;
            this.ViveEmTerra = true;
            this.Sexo = sexo;
            this.QuantidadeDeMamas = 0;
            this.Pelos = true;
            this.Peconhento = false;
        }

        public override void Alimentar()
        {
            Console.WriteLine("Joga uma carne ai");
        }

        public void Botar()
        {
            Console.WriteLine("Consigo botar cerca de 1-3 ovos");
        }

        public void Chocar()
        {
            Console.WriteLine("Crack! um ornitorrinco nasceu");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Grrrr");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Vou dar uma mergulhada no rio");
        }
    }
}
