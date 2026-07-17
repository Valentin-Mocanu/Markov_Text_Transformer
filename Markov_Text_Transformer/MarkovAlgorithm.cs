using System.Collections.Generic;

namespace Markov_Text_Transformer
{
    public class MarkovAlgorithm
    {
        // The list that stores all the algorithm steps
        public List<string> Steps { get; private set; }

        public MarkovAlgorithm()
        {
            Steps = new List<string>();
        }

        // Input: initial string (σ), rules; Output: final string
        public string ApplyMarkovAlgorithm(string word, List<MarkovRule> rules)
        {
            Steps.Clear();

            // Runs until no more rules can be applied or when it encounters the terminal rule
            while (true)
            {
                bool applied = false;

                // "IndexOf" searches for the first (leftmost) occurrence
                foreach (MarkovRule rule in rules)
                {
                    int pos = word.IndexOf(rule.Left);
                    if (pos != -1)
                    {
                        // Rewrite the word
                        string newWord = word.Remove(pos, rule.Left.Length).Insert(pos, rule.Right);

                        // Memorize the step
                        Steps.Add(rule.RuleId + ") " + newWord);

                        word = newWord;
                        applied = true;

                        // Terminal rule (the algorithm stops immediately)
                        if (rule.IsTerminal)
                        {
                            return word;
                        }

                        break;
                    }
                }
                // If no more rules can be applied, the algorithm stops
                if (!applied)
                {
                    return word;
                }
            }
        }
    }
}
