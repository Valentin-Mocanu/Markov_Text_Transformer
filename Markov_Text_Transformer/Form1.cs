using Markov_Text_Transformer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Markov_Text_Transformer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxOptions.Items.Clear();
            comboBoxOptions.Items.Add("Eliminare subcuvant");
            comboBoxOptions.Items.Add("Inlocuire subcuvant");
            comboBoxOptions.Items.Add("Inserare caractere - inainte subcuvant");
            comboBoxOptions.Items.Add("Inserare caractere - dupa subcuvant");
            comboBoxOptions.Items.Add("Inserare caractere - inainte + dupa");
            comboBoxOptions.SelectedIndex = 0;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            string inputString = textBoxInputString.Text.Trim(); // Cuvantul initial, introdus de utilizator = sigma
            string subString = textBoxSubString.Text.Trim(); // Subcuvantul ales din cuvantul initial = beta
            string replacementString = textBoxReplacementString.Text.Trim(); // Expresia de inlocuit la alegerea unor reguli specifice de inlocuire = gama

            // Validari de baza
            if (string.IsNullOrEmpty(inputString))
            {
                MessageBox.Show("Cuvantul sigma (σ) nu poate fi gol!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(subString))
            {
                MessageBox.Show("Subcuvantul beta (β) nu poate fi gol!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!inputString.Contains(subString))
            {
                MessageBox.Show("Subcuvantul beta (β) nu apare in cuvantul sigma (σ)!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxOptions.SelectedIndex < 0)
            {
                MessageBox.Show("Selectati o optiune!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validare expresie de inlocuit pentru optiunile 2–4
            if (comboBoxOptions.SelectedIndex >= 1 && string.IsNullOrEmpty(replacementString))
            {
                MessageBox.Show("Trebuie sa adaugati o expresie de inlocuit (γ) pentru aceasta optiune!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // -------------------------
            // Constructie reguli Markov
            // -------------------------

            // Lista care stocheaza toate regulile definite pentru transformarea cuvantului
            List<MarkovRule> rules = new List<MarkovRule>();
            int ruleCounter = 1; // Folosit la lista de optiuni

            // 4) λ → A
            inputString = "A" + inputString;
            listBoxResults.Items.Add("4) " + inputString);

            // 1) Regula specifica optiunii
            switch (comboBoxOptions.SelectedIndex)
            {
                case 0: // Eliminare (Aβz -> Az)
                    rules.Add(new MarkovRule
                    {
                        RuleId = ruleCounter++,
                        Left = "A" + subString,
                        Right = "A"
                    });
                    break;

                case 1: // Inlocuire (Aβz -> γAz, unde "γ" e expresia de inlocuit)
                    rules.Add(new MarkovRule
                    {
                        RuleId = ruleCounter++,
                        Left = "A" + subString,
                        Right = replacementString + "A"
                    });
                    break;

                case 2: // Inserare inainte (Aβz -> γβAz, unde "γ" e expresia de inlocuit)
                    rules.Add(new MarkovRule
                    {
                        RuleId = ruleCounter++,
                        Left = "A" + subString,
                        Right = replacementString + subString + "A"
                    });
                    break;

                case 3: // Inserare dupa (Aβz -> βγAz, unde "γ" e expresia de inlocuit)
                    rules.Add(new MarkovRule
                    {
                        RuleId = ruleCounter++,
                        Left = "A" + subString,
                        Right = subString + replacementString + "A"
                    });
                    break;

                case 4: // Inserare inainte si dupa (Aβz -> γβγAz, unde "γ" e expresia de inlocuit)
                    rules.Add(new MarkovRule
                    {
                        RuleId = ruleCounter++,
                        Left = "A" + subString,
                        Right = replacementString + subString + replacementString + "A"
                    });
                    break;
            }

            // 2) Ax → xA
            // HashSet care contine toate caracterele distincte aparute in cuvantul curent
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
            // Rulare algoritm
            // -------------------------

            MarkovAlgorithm markov = new MarkovAlgorithm();

            try
            {
                // Rularea algoritmului
                markov.ApplyMarkovAlgorithm(inputString, rules);

                // Afisarea pasilor
                foreach (string step in markov.Steps)
                    listBoxResults.Items.Add(step);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A aparut o eroare in timpul rulari algoritmului:\n\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
