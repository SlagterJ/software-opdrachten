namespace CalorieTracker
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
            this.radButMale = new System.Windows.Forms.RadioButton();
            this.radButFemale = new System.Windows.Forms.RadioButton();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radButNotActive = new System.Windows.Forms.RadioButton();
            this.radButActive = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.checkboxPregnant = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radButMale
            // 
            this.radButMale.AutoSize = true;
            this.radButMale.Location = new System.Drawing.Point(6, 22);
            this.radButMale.Name = "radButMale";
            this.radButMale.Size = new System.Drawing.Size(49, 19);
            this.radButMale.TabIndex = 0;
            this.radButMale.TabStop = true;
            this.radButMale.Text = "Man";
            this.radButMale.UseVisualStyleBackColor = true;
            this.radButMale.CheckedChanged += new System.EventHandler(this.radButMale_CheckedChanged);
            // 
            // radButFemale
            // 
            this.radButFemale.AutoSize = true;
            this.radButFemale.Location = new System.Drawing.Point(6, 47);
            this.radButFemale.Name = "radButFemale";
            this.radButFemale.Size = new System.Drawing.Size(59, 19);
            this.radButFemale.TabIndex = 1;
            this.radButFemale.TabStop = true;
            this.radButFemale.Text = "Vrouw";
            this.radButFemale.UseVisualStyleBackColor = true;
            this.radButFemale.CheckedChanged += new System.EventHandler(this.radButFemale_CheckedChanged);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(530, 148);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 23);
            this.textBoxAge.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Leeftijd:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radButMale);
            this.groupBox1.Controls.Add(this.radButFemale);
            this.groupBox1.Location = new System.Drawing.Point(46, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geslacht:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radButNotActive);
            this.groupBox2.Controls.Add(this.radButActive);
            this.groupBox2.Location = new System.Drawing.Point(279, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Levensstijl:";
            // 
            // radButNotActive
            // 
            this.radButNotActive.AutoSize = true;
            this.radButNotActive.Location = new System.Drawing.Point(6, 47);
            this.radButNotActive.Name = "radButNotActive";
            this.radButNotActive.Size = new System.Drawing.Size(81, 19);
            this.radButNotActive.TabIndex = 11;
            this.radButNotActive.TabStop = true;
            this.radButNotActive.Text = "Niet Actief";
            this.radButNotActive.UseVisualStyleBackColor = true;
            // 
            // radButActive
            // 
            this.radButActive.AutoSize = true;
            this.radButActive.Location = new System.Drawing.Point(6, 22);
            this.radButActive.Name = "radButActive";
            this.radButActive.Size = new System.Drawing.Size(56, 19);
            this.radButActive.TabIndex = 10;
            this.radButActive.TabStop = true;
            this.radButActive.Text = "Actief";
            this.radButActive.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(46, 265);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(150, 48);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "Bereken";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(279, 282);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(61, 15);
            this.labelResult.TabIndex = 11;
            this.labelResult.Text = "Uitkomst: ";
            // 
            // checkboxPregnant
            // 
            this.checkboxPregnant.AutoSize = true;
            this.checkboxPregnant.Enabled = false;
            this.checkboxPregnant.Location = new System.Drawing.Point(530, 178);
            this.checkboxPregnant.Name = "checkboxPregnant";
            this.checkboxPregnant.Size = new System.Drawing.Size(72, 19);
            this.checkboxPregnant.TabIndex = 12;
            this.checkboxPregnant.Text = "Zwanger";
            this.checkboxPregnant.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkboxPregnant);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radButMale;
        private RadioButton radButFemale;
        private TextBox textBoxAge;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radButNotActive;
        private RadioButton radButActive;
        private Button buttonCalculate;
        private Label labelResult;
        private CheckBox checkboxPregnant;
    }
}