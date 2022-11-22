using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_01.Models
{
    public class Animais
    {
        public string raca { get; set; }
        public string tamanho { get; set; }

        public void dadosAnimais(string raca, string tamanho){
            Console.WriteLine(" ");
            Console.WriteLine($"Raça: {raca}");
            Console.WriteLine($"Tamanho: {tamanho}");
        }

        public virtual void EmitirSom(){
            Console.WriteLine("Sons de animais");
        }
    }
}