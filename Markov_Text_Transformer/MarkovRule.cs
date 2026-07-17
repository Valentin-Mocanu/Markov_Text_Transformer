namespace Markov_Text_Transformer
{
    public class MarkovRule
    {
        public int RuleId { get; set; } // How the steps will be numbered: 1),2),3),4) 

        public string Left { get; set; }
        public string Right { get; set; }

        public bool IsTerminal { get; set; }
    }
}
