namespace Markov_Text_Transformer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInputString = new System.Windows.Forms.TextBox();
            this.textBoxSubString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOptions = new System.Windows.Forms.ComboBox();
            this.textBoxReplacementString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInputString
            // 
            this.textBoxInputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputString.Location = new System.Drawing.Point(76, 63);
            this.textBoxInputString.Name = "textBoxInputString";
            this.textBoxInputString.Size = new System.Drawing.Size(122, 24);
            this.textBoxInputString.TabIndex = 0;
            // 
            // textBoxSubString
            // 
            this.textBoxSubString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubString.Location = new System.Drawing.Point(76, 156);
            this.textBoxSubString.Name = "textBoxSubString";
            this.textBoxSubString.Size = new System.Drawing.Size(122, 24);
            this.textBoxSubString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial string (σ):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Substring (β):";
            // 
            // comboBoxOptions
            // 
            this.comboBoxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOptions.FormattingEnabled = true;
            this.comboBoxOptions.Items.AddRange(new object[] {
            "Eliminare subcuvant",
            "Inlocuire subcuvant",
            "Transformare + mutare la final",
            "Transformare + mutare la inceput"});
            this.comboBoxOptions.Location = new System.Drawing.Point(46, 257);
            this.comboBoxOptions.Name = "comboBoxOptions";
            this.comboBoxOptions.Size = new System.Drawing.Size(174, 26);
            this.comboBoxOptions.TabIndex = 4;
            // 
            // textBoxReplacementString
            // 
            this.textBoxReplacementString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReplacementString.Location = new System.Drawing.Point(76, 352);
            this.textBoxReplacementString.Name = "textBoxReplacementString";
            this.textBoxReplacementString.Size = new System.Drawing.Size(122, 24);
            this.textBoxReplacementString.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(60, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Replacement String:";
            // 
            // buttonRun
            // 
            this.buttonRun.BackColor = System.Drawing.Color.Silver;
            this.buttonRun.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonRun.Location = new System.Drawing.Point(225, 429);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(116, 38);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.HorizontalScrollbar = true;
            this.listBoxResults.ItemHeight = 18;
            this.listBoxResults.Location = new System.Drawing.Point(309, 66);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(247, 310);
            this.listBoxResults.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(60, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select an operation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(289, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Results:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(610, 504);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxReplacementString);
            this.Controls.Add(this.comboBoxOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSubString);
            this.Controls.Add(this.textBoxInputString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Markov Text Transformer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInputString;
        private System.Windows.Forms.TextBox textBoxSubString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOptions;
        private System.Windows.Forms.TextBox textBoxReplacementString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

