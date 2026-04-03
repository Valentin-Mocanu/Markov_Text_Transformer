using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_Text_Transformer
{
    public class MarkovAlgorithm
    {
        // Lista in care se memoreaza toti pasii algoritmului
        public List<string> Steps { get; private set; }

        // Constructorul
        public MarkovAlgorithm()
        {
            Steps = new List<string>();
        }

        // Primeste: word = cuvantul (σ), rules = lista regulilor; Returneaza: cuvantul final
        public string ApplyMarkovAlgorithm(string word, List<MarkovRule> rules)
        {
            Steps.Clear();

            // Se aplica pana nu mai exista reguli aplicabile sau pana intalneste o regula terminala
            while (true)
            {
                bool applied = false;

                // "IndexOf" cauta prima aparitie, cea mai din stanga
                foreach (MarkovRule rule in rules)
                {
                    int pos = word.IndexOf(rule.Left);
                    if (pos != -1)
                    {
                        // Rescrie cuvantul
                        string newWord = word.Remove(pos, rule.Left.Length).Insert(pos, rule.Right);

                        // Memorarea pasului
                        Steps.Add(rule.RuleId + ") " + newWord);

                        word = newWord;
                        applied = true;

                        // Regula terminala (algoritmul se opreste imediat)
                        if (rule.IsTerminal)
                            return word;

                        break;
                    }
                }

                // Daca nu se mai aplica nicio regula, algoritmul se opreste natural
                if (!applied)
                    return word;
            }
        }
    }
}
