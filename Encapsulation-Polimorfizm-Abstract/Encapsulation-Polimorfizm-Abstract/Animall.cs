using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Polimorfizm_Abstract
{
    internal class Animall
    {
        public string Name { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }

    }
}
