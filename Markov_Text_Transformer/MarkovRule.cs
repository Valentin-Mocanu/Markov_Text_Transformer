using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_Text_Transformer
{
    public class MarkovRule
    {
        // Proprietatile
        public int RuleId { get; set; } // Numarul regulilor: 1),2),3),4) 

        public string Left { get; set; }
        public string Right { get; set; }

        public bool IsTerminal { get; set; }
    }
}
