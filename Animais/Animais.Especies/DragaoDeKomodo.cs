using Animais.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Especies
{
    public class DragaoDeKomodo : Reptil, IAquatico
    {
        public bool ViveEmTerra { get; set; }

        public bool Mergulho { get; set; }

        public bool AguaDoce { get; set; }

        public DragaoDeKomodo(string nome, DateTime nascimento, char sexo)
        {
            this.Nome = nome;
            this.DataDoNascimento = nascimento;
            this.Sexo = sexo;
            this.Peconhento = true;
            this.Carnivoro = true;
            this.Casco = false;
            this.Escamas = true;
            this.ViveEmTerra = true;
            this.Mergulho = true;
            this.AguaDoce = true;
        }

        public override void Alimentar()
        {
            Console.WriteLine("Joga uma carne ai");
        }

        public override void Comunicar()
        {
            Console.WriteLine("crrriiii");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Posso mergulhar, nadar, andar na terra, só aprendi a voar ainda");
        }
    }
}
