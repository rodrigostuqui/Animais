
using Animais.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Especies
{
    public class Morcego : Mamifero, IVoar
    {
        public int AlturaMaxima { get; set; }

        public double VelocidadeVoo { get; set; }
        

        public Morcego(string nome, DateTime nascimento, char sexo, bool carnivoro,string corDoPelo, int alturaMaxima, double velocidadeVoo, int quantidadeDeMamas)
        {
            this.Nome = nome;
            this.DataDoNascimento = nascimento;
            this.Sexo = sexo;
            this.Peconhento = false;
            this.QuantidadeDeMamas = quantidadeDeMamas;
            this.Carnivoro = carnivoro;
            this.Pelos = true;
            this.CorDoPelo = corDoPelo;
            this.AlturaMaxima = alturaMaxima;
            this.VelocidadeVoo = velocidadeVoo;
        }

        public override void Alimentar()
        {
            Console.WriteLine("Dependendo da minha especie, posso me alimentar de frutos/carne/insetos/pólen/sangue");
        }

        public override void Comunicar()
        {
            Console.WriteLine("tic tic tic");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Posso voar livremente");
        }
    }
}
