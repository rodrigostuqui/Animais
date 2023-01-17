using Animais.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Especies
{
    public class Lontra : Mamifero, IAquatico
    {
        public bool ViveEmTerra { get; set; }

        public bool Mergulho { get; set; }

        public bool AguaDoce { get; set; }

        public Lontra(string nome, DateTime nascimento, char sexo, string corDoPelo, int quantidadeDeMamas)
        {
            this.Nome = nome;
            this.DataDoNascimento = nascimento;
            this.Sexo = sexo;
            this.Carnivoro = true;
            this.Peconhento = false;
            this.QuantidadeDeMamas = quantidadeDeMamas;
            this.Pelos = true;
            this.CorDoPelo = corDoPelo;
            this.Mergulho = true;
            this.AguaDoce = true;
            this.ViveEmTerra = true;
        }

        public override void Alimentar()
        {
            Console.WriteLine("Joga uma carne ai");
        }

        public override void Comunicar()
        {
            Console.WriteLine("ih ih, iriri");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Posso nadar, mergulhar e tambem sou terrestre");
        }
    }
}
