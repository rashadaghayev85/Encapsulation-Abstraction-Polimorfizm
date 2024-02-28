using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Polimorfizm_Abstract
{
    internal class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        private string color = "red";
        public string Color
        {
            get
            {
                if (Speed > 400)
                {
                    return color;

                }
                return null;
            }

            set
            {
                color = value;
            }
        }
      

        
        }
    }

