
using Animais.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Especies
{
    public class Cisne : Ave, IOviparo, IVoar, IAquatico
    {
        public int AlturaMaxima { get; set; }

        public double VelocidadeVoo { get; set; }

        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }

        public bool AguaDoce { get; set; }

        public Cisne(string nome, DateTime nascimento, char sexo, string corPena , int alturaMaxima, double velocidadeVoo)
        {
            this.Nome = nome;
            this.DataDoNascimento = nascimento;
            this.Sexo = sexo;
            this.Peconhento = false;
            this.Carnivoro = false;
            this.CorPena = corPena;
            this.Rapina = false;
            this.AlturaMaxima = alturaMaxima;
            this.VelocidadeVoo = velocidadeVoo;
            this.ViveEmTerra = true;
            this.Mergulho = false;
            this.AguaDoce = true;
        }
        public override void Alimentar()
        {
            Console.WriteLine("Joga uma planta ai");
        }

        public void Botar()
        {
            Console.WriteLine("Consigo botar em torno de 6 ovos");
        }

        public void Chocar()
        {
            Console.WriteLine("Crack, Nasceu um novo Cisne");
        }

        public override void Comunicar()
        {
            Console.WriteLine("ahn ahn ahn");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Vou passear aqui no meu lago");
        }

    }
}
