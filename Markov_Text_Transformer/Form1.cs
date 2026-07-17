using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Markov_Text_Transformer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxOptions.Items.Clear();
            comboBoxOptions.Items.Add("Delete substring");
            comboBoxOptions.Items.Add("Replace substring");
            comboBoxOptions.Items.Add("Insert before substring");
            comboBoxOptions.Items.Add("Insert after substring");
            comboBoxOptions.Items.Add("Insert before and after");
            comboBoxOptions.SelectedIndex = 0;
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            string inputString = textBoxInputString.Text.Trim(); // initial string = sigma (σ)
            string subString = textBoxSubString.Text.Trim(); // substring = beta (β)
            string replacementString = textBoxReplacementString.Text.Trim(); // replacement string, used on some specific rules = gama (γ)

            if (string.IsNullOrEmpty(inputString))
            {
                MessageBox.Show("The initial string (σ) cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(subString))
            {
                MessageBox.Show("The substring (β) cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!inputString.Contains(subString))
            {
                MessageBox.Show("The substring (β) does not appear in the initial string (σ)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxOptions.SelectedIndex >= 1 && string.IsNullOrEmpty(replacementString))
            {
                MessageBox.Show("You need to add a replacement string (γ) for this operation!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // -------------------------------------------
            // Markov rule (algorithm) - how it is done
            // -------------------------------------------

            // The list that stores all the rules defined for string transformation
            List<MarkovRule> rules = new List<MarkovRule>();
            int ruleCounter = 1; // Used in the operation list

            // 4) λ → A
            inputString = "A" + inputString;
            listBoxResults.Items.Add("4) " + inputString);

            // 1) Chosen operation (rule)
            switch (comboBoxOptions.SelectedIndex)
            {
                case 0: // Delete (Aβz -> Az)
                    rules.Add(new MarkovRule
                    {
                        RuleId = ruleCounter++,
                        Left = "A" + subString,
                        Right = "A"
                    });
                    break;

                case 1: // Replace (Aβz -> γAz, where γ is the replacement string)
                    rules.Add(new MarkovRule
                    {
                        RuleId = ruleCounter++,
                        Left = "A" + subString,
                        Right = replacementString + "A"
                    });
                    break;

                case 2: // Insert before (Aβz -> γβAz, where γ is the replacement (inserted) string)
                    rules.Add(new MarkovRule
                    {
                        RuleId = ruleCounter++,
                        Left = "A" + subString,
                        Right = replacementString + subString + "A"
                    });
                    break;

                case 3: // Insert after (Aβz -> βγAz, where γ is the replacement (inserted) string)
                    rules.Add(new MarkovRule
                    {
                        RuleId = ruleCounter++,
                        Left = "A" + subString,
                        Right = subString + replacementString + "A"
                    });
                    break;

                case 4: // Insert before and after (Aβz -> γβγAz, where γ is the replacement (inserted) string)
                    rules.Add(new MarkovRule
                    {
                        RuleId = ruleCounter++,
                        Left = "A" + subString,
                        Right = replacementString + subString + replacementString + "A"
                    });
                    break;
            }

            // 2) Ax → xA
            // HashSet stores all the distinct characters found in the current string
            HashSet<char> alphabet = new HashSet<char>(inputString);
            alphabet.Add('A');

            foreach (char c in alphabet)
            {
                rules.Add(new MarkovRule
                {
                    RuleId = 2,
                    Left = "A" + c,
                    Right = c + "A"
                });
            }

            // 3) A → .λ
            rules.Add(new MarkovRule
            {
                RuleId = 3,
                Left = "A",
                Right = "",
                IsTerminal = true
            });

            // -------------------------
            // Run algorithm
            // -------------------------

            MarkovAlgorithm markov = new MarkovAlgorithm();

            try
            {
                markov.ApplyMarkovAlgorithm(inputString, rules);

                // Display the steps
                foreach (string step in markov.Steps)
                    listBoxResults.Items.Add(step);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while running the algorithm:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
