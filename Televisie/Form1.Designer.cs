namespace Televisie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTelevisionOff = new System.Windows.Forms.RadioButton();
            this.radioButtonTelevisionOn = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.onOrOffLabel = new System.Windows.Forms.Label();
            this.listBoxChannels = new System.Windows.Forms.ListBox();
            this.buttonNextChannel = new System.Windows.Forms.Button();
            this.buttonPreviousChannel = new System.Windows.Forms.Button();
            this.textBoxAddChannel = new System.Windows.Forms.TextBox();
            this.buttonAddChannel = new System.Windows.Forms.Button();
            this.labelCurrentChannel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Televisie van Harrie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTelevisionOff);
            this.groupBox1.Controls.Add(this.radioButtonTelevisionOn);
            this.groupBox1.Location = new System.Drawing.Point(55, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De televisie staat";
            // 
            // radioButtonTelevisionOff
            // 
            this.radioButtonTelevisionOff.AutoSize = true;
            this.radioButtonTelevisionOff.Checked = true;
            this.radioButtonTelevisionOff.Location = new System.Drawing.Point(6, 47);
            this.radioButtonTelevisionOff.Name = "radioButtonTelevisionOff";
            this.radioButtonTelevisionOff.Size = new System.Drawing.Size(40, 19);
            this.radioButtonTelevisionOff.TabIndex = 1;
            this.radioButtonTelevisionOff.TabStop = true;
            this.radioButtonTelevisionOff.Text = "Uit";
            this.radioButtonTelevisionOff.UseVisualStyleBackColor = true;
            this.radioButtonTelevisionOff.CheckedChanged += new System.EventHandler(this.radioButtonTelevisionOff_CheckedChanged);
            // 
            // radioButtonTelevisionOn
            // 
            this.radioButtonTelevisionOn.AutoSize = true;
            this.radioButtonTelevisionOn.Location = new System.Drawing.Point(6, 22);
            this.radioButtonTelevisionOn.Name = "radioButtonTelevisionOn";
            this.radioButtonTelevisionOn.Size = new System.Drawing.Size(46, 19);
            this.radioButtonTelevisionOn.TabIndex = 0;
            this.radioButtonTelevisionOn.Text = "Aan";
            this.radioButtonTelevisionOn.UseVisualStyleBackColor = true;
            this.radioButtonTelevisionOn.CheckedChanged += new System.EventHandler(this.radioButtonTelevisionOn_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // onOrOffLabel
            // 
            this.onOrOffLabel.AutoSize = true;
            this.onOrOffLabel.Location = new System.Drawing.Point(401, 204);
            this.onOrOffLabel.Name = "onOrOffLabel";
            this.onOrOffLabel.Size = new System.Drawing.Size(22, 15);
            this.onOrOffLabel.TabIndex = 3;
            this.onOrOffLabel.Text = "Uit";
            // 
            // listBoxChannels
            // 
            this.listBoxChannels.FormattingEnabled = true;
            this.listBoxChannels.ItemHeight = 15;
            this.listBoxChannels.Location = new System.Drawing.Point(594, 81);
            this.listBoxChannels.Name = "listBoxChannels";
            this.listBoxChannels.Size = new System.Drawing.Size(170, 229);
            this.listBoxChannels.TabIndex = 4;
            // 
            // buttonNextChannel
            // 
            this.buttonNextChannel.Location = new System.Drawing.Point(473, 327);
            this.buttonNextChannel.Name = "buttonNextChannel";
            this.buttonNextChannel.Size = new System.Drawing.Size(75, 23);
            this.buttonNextChannel.TabIndex = 5;
            this.buttonNextChannel.Text = "Volgende";
            this.buttonNextChannel.UseVisualStyleBackColor = true;
            this.buttonNextChannel.Click += new System.EventHandler(this.buttonNextChannel_Click);
            // 
            // buttonPreviousChannel
            // 
            this.buttonPreviousChannel.Location = new System.Drawing.Point(308, 327);
            this.buttonPreviousChannel.Name = "buttonPreviousChannel";
            this.buttonPreviousChannel.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviousChannel.TabIndex = 6;
            this.buttonPreviousChannel.Text = "Vorige";
            this.buttonPreviousChannel.UseVisualStyleBackColor = true;
            this.buttonPreviousChannel.Click += new System.EventHandler(this.buttonPreviousChannel_Click);
            // 
            // textBoxAddChannel
            // 
            this.textBoxAddChannel.Location = new System.Drawing.Point(594, 327);
            this.textBoxAddChannel.Name = "textBoxAddChannel";
            this.textBoxAddChannel.Size = new System.Drawing.Size(100, 23);
            this.textBoxAddChannel.TabIndex = 7;
            // 
            // buttonAddChannel
            // 
            this.buttonAddChannel.Location = new System.Drawing.Point(594, 356);
            this.buttonAddChannel.Name = "buttonAddChannel";
            this.buttonAddChannel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddChannel.TabIndex = 8;
            this.buttonAddChannel.Text = "Voeg Toe";
            this.buttonAddChannel.UseVisualStyleBackColor = true;
            this.buttonAddChannel.Click += new System.EventHandler(this.buttonAddChannel_Click);
            // 
            // labelCurrentChannel
            // 
            this.labelCurrentChannel.AutoSize = true;
            this.labelCurrentChannel.Location = new System.Drawing.Point(401, 219);
            this.labelCurrentChannel.Name = "labelCurrentChannel";
            this.labelCurrentChannel.Size = new System.Drawing.Size(49, 15);
            this.labelCurrentChannel.TabIndex = 9;
            this.labelCurrentChannel.Text = "channel";
            this.labelCurrentChannel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCurrentChannel);
            this.Controls.Add(this.buttonAddChannel);
            this.Controls.Add(this.textBoxAddChannel);
            this.Controls.Add(this.buttonPreviousChannel);
            this.Controls.Add(this.buttonNextChannel);
            this.Controls.Add(this.listBoxChannels);
            this.Controls.Add(this.onOrOffLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButtonTelevisionOff;
        private RadioButton radioButtonTelevisionOn;
        private PictureBox pictureBox1;
        private Label onOrOffLabel;
        private ListBox listBoxChannels;
        private Button buttonNextChannel;
        private Button buttonPreviousChannel;
        private TextBox textBoxAddChannel;
        private Button buttonAddChannel;
        private Label labelCurrentChannel;
    }
}