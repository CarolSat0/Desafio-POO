using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_01.Models
{
    public class Passaro: Animais
    {
        public override void EmitirSom(){
            Console.WriteLine("Piu Piu");
        }
    }
}