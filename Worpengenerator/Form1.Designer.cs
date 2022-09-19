namespace Worpengenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diceSidesInput = new System.Windows.Forms.NumericUpDown();
            this.diceAmountInput = new System.Windows.Forms.NumericUpDown();
            this.rollButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultTotal = new System.Windows.Forms.Label();
            this.resultsBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.highestResultLabel = new System.Windows.Forms.Label();
            this.lowestResultLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceSidesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceAmountInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.diceSidesInput);
            this.groupBox1.Controls.Add(this.diceAmountInput);
            this.groupBox1.Controls.Add(this.rollButton);
            this.groupBox1.Location = new System.Drawing.Point(41, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instellingen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aantal ogen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aantal worpen:";
            // 
            // diceSidesInput
            // 
            this.diceSidesInput.Location = new System.Drawing.Point(130, 51);
            this.diceSidesInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.diceSidesInput.Name = "diceSidesInput";
            this.diceSidesInput.Size = new System.Drawing.Size(120, 23);
            this.diceSidesInput.TabIndex = 1;
            this.diceSidesInput.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // diceAmountInput
            // 
            this.diceAmountInput.Location = new System.Drawing.Point(130, 22);
            this.diceAmountInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diceAmountInput.Name = "diceAmountInput";
            this.diceAmountInput.Size = new System.Drawing.Size(120, 23);
            this.diceAmountInput.TabIndex = 2;
            this.diceAmountInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(6, 132);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(244, 23);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "Gooi dobbelstenen!";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lowestResultLabel);
            this.groupBox2.Controls.Add(this.resultTotal);
            this.groupBox2.Controls.Add(this.highestResultLabel);
            this.groupBox2.Controls.Add(this.resultsBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(383, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 352);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultaat";
            // 
            // resultTotal
            // 
            this.resultTotal.AutoSize = true;
            this.resultTotal.Location = new System.Drawing.Point(6, 289);
            this.resultTotal.Name = "resultTotal";
            this.resultTotal.Size = new System.Drawing.Size(115, 15);
            this.resultTotal.TabIndex = 2;
            this.resultTotal.Text = "Totaal aantal ogen: 0";
            // 
            // resultsBox
            // 
            this.resultsBox.FormattingEnabled = true;
            this.resultsBox.ItemHeight = 15;
            this.resultsBox.Location = new System.Drawing.Point(6, 42);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(323, 244);
            this.resultsBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Worpen:";
            // 
            // highestResultLabel
            // 
            this.highestResultLabel.AutoSize = true;
            this.highestResultLabel.Location = new System.Drawing.Point(6, 304);
            this.highestResultLabel.Name = "highestResultLabel";
            this.highestResultLabel.Size = new System.Drawing.Size(149, 15);
            this.highestResultLabel.TabIndex = 2;
            this.highestResultLabel.Text = "Hoogste worp tot nu toe: 0";
            // 
            // lowestResultLabel
            // 
            this.lowestResultLabel.AutoSize = true;
            this.lowestResultLabel.Location = new System.Drawing.Point(6, 319);
            this.lowestResultLabel.Name = "lowestResultLabel";
            this.lowestResultLabel.Size = new System.Drawing.Size(144, 15);
            this.lowestResultLabel.TabIndex = 3;
            this.lowestResultLabel.Text = "Laagste worp tot nu toe: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceSidesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceAmountInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown diceSidesInput;
        private NumericUpDown diceAmountInput;
        private Button rollButton;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListBox resultsBox;
        private Label label3;
        private Label resultTotal;
        private Label lowestResultLabel;
        private Label highestResultLabel;
    }
}