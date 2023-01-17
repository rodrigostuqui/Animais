using Animais.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Especies
{
    public class Leao : Mamifero
    {

        public Leao(string nome, DateTime nascimento, char sexo, string corDoPelo, int quantidadeDeMamas)
        {
            this.Nome = nome;
            this.DataDoNascimento = nascimento;
            this.Sexo = sexo;
            this.Carnivoro = true;
            this.Peconhento= false;
            this.QuantidadeDeMamas = quantidadeDeMamas;
            this.Pelos = true;
            this.CorDoPelo = corDoPelo;
        }

        public override void Alimentar()
         => Console.WriteLine("Joga carne ai");
        public override void Comunicar()
            => Console.WriteLine("Roar");

        public override void Movimentar()
            => Console.WriteLine("Estou andando pelas savanas");
    }
}
