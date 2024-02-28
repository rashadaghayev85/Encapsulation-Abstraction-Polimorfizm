using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Polimorfizm_Abstract
{
    internal class Bird:Animall
    {
        public string Color { get; set; }
        public override void Sound()
        {
           // base.Sound();
            Console.WriteLine("Bird sound");
        }
    }
}
