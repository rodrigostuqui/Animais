using Animais.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Especies
{
    public class Arara : Ave, IVoar, IOviparo
    {
        public int AlturaMaxima { get; set; }

        public double VelocidadeVoo { get; set; }

        public Arara(string nome, DateTime nascimento, char sexo, string corPena, int alturaMaxima, double velocidadeVoo)
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
        }
        public override void Alimentar()
        {
            Console.WriteLine("Gosto de me alimentar de frutos de palmeiras");
        }

        public void Botar()
        {
            Console.WriteLine("Consigo botar em torno de 4 ovos");
        }

        public void Chocar()
        {
            Console.WriteLine("Crack, Nasceu uma nova Arara");
        }

        public override void Comunicar()
        {
            Console.WriteLine("reco-reco");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Vou passear aqui pelo pantanal");
        }
    }
}
