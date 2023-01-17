
using Animais.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Especies
{
    public class Coruja : Ave, IVoar, IOviparo
    {
        public int AlturaMaxima { get; set; }

        public double VelocidadeVoo { get; set; }

        public Coruja(string nome, DateTime nascimento, char sexo, string corPena, int alturaMaxima, double velocidadeVoo)
        {
            this.Nome = nome;
            this.DataDoNascimento = nascimento;
            this.Sexo = sexo;
            this.Peconhento = false;
            this.Carnivoro = true;
            this.CorPena = corPena;
            this.Rapina = true;
            this.AlturaMaxima = alturaMaxima;
            this.VelocidadeVoo = velocidadeVoo;
        }
        public override void Alimentar()
        {
            Console.WriteLine("Vou caçar a noite um petisco");
        }

        public void Botar()
        {
            Console.WriteLine("Consigo botar em torno de 7 ovos");
        }

        public void Chocar()
        {
            Console.WriteLine("Crack, Nasceu uma nova Coruja");
        }

        public override void Comunicar()
        {
            Console.WriteLine("uuh uuh");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Gosto de me movimentar a noite");
        }

    }
}
