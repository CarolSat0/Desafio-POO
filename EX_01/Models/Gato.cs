using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX_01.Models
{
    public class Gato: Animais
    {
        public override void EmitirSom(){
            Console.WriteLine("Miau Miau");
        }
    }
}