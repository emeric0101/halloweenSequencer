namespace HalloweenModule
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.portComList = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBoxRelais1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSequence = new System.Windows.Forms.Button();
            this.sequenceTimerInput = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AvCCb = new System.Windows.Forms.RadioButton();
            this.ArDCb = new System.Windows.Forms.RadioButton();
            this.ArGCb = new System.Windows.Forms.RadioButton();
            this.AvDCb = new System.Windows.Forms.RadioButton();
            this.AvGCb = new System.Windows.Forms.RadioButton();
            this.AvDLb = new System.Windows.Forms.ListBox();
            this.ArGLb = new System.Windows.Forms.ListBox();
            this.ArDLb = new System.Windows.Forms.ListBox();
            this.AvCLb = new System.Windows.Forms.ListBox();
            this.AvGLb = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceTimerInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // portComList
            // 
            this.portComList.FormattingEnabled = true;
            this.portComList.ItemHeight = 16;
            this.portComList.Location = new System.Drawing.Point(12, 12);
            this.portComList.Name = "portComList";
            this.portComList.Size = new System.Drawing.Size(120, 84);
            this.portComList.TabIndex = 1;
            this.portComList.SelectedIndexChanged += new System.EventHandler(this.portComList_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "eteindre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "allumer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxRelais1
            // 
            this.checkBoxRelais1.AutoSize = true;
            this.checkBoxRelais1.Location = new System.Drawing.Point(241, 12);
            this.checkBoxRelais1.Name = "checkBoxRelais1";
            this.checkBoxRelais1.Size = new System.Drawing.Size(81, 21);
            this.checkBoxRelais1.TabIndex = 6;
            this.checkBoxRelais1.Text = "Relais 1";
            this.checkBoxRelais1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(328, 14);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 21);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Relais 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 288);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // buttonSequence
            // 
            this.buttonSequence.Location = new System.Drawing.Point(861, 92);
            this.buttonSequence.Name = "buttonSequence";
            this.buttonSequence.Size = new System.Drawing.Size(75, 23);
            this.buttonSequence.TabIndex = 16;
            this.buttonSequence.Text = "Ajouter au sequencer";
            this.buttonSequence.UseVisualStyleBackColor = true;
            this.buttonSequence.Click += new System.EventHandler(this.buttonSequence_Click);
            // 
            // sequenceTimerInput
            // 
            this.sequenceTimerInput.Location = new System.Drawing.Point(861, 32);
            this.sequenceTimerInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sequenceTimerInput.Name = "sequenceTimerInput";
            this.sequenceTimerInput.Size = new System.Drawing.Size(120, 22);
            this.sequenceTimerInput.TabIndex = 17;
            this.sequenceTimerInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(861, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(943, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(861, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Tout arreter !";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AvCCb);
            this.panel1.Controls.Add(this.ArDCb);
            this.panel1.Controls.Add(this.ArGCb);
            this.panel1.Controls.Add(this.AvDCb);
            this.panel1.Controls.Add(this.AvGCb);
            this.panel1.Location = new System.Drawing.Point(415, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 41);
            this.panel1.TabIndex = 21;
            // 
            // AvCCb
            // 
            this.AvCCb.AutoSize = true;
            this.AvCCb.Location = new System.Drawing.Point(344, 4);
            this.AvCCb.Name = "AvCCb";
            this.AvCCb.Size = new System.Drawing.Size(54, 21);
            this.AvCCb.TabIndex = 4;
            this.AvCCb.TabStop = true;
            this.AvCCb.Text = "AvC";
            this.AvCCb.UseVisualStyleBackColor = true;
            this.AvCCb.CheckedChanged += new System.EventHandler(this.ArGCb_CheckedChanged);
            // 
            // ArDCb
            // 
            this.ArDCb.AutoSize = true;
            this.ArDCb.Location = new System.Drawing.Point(258, 4);
            this.ArDCb.Name = "ArDCb";
            this.ArDCb.Size = new System.Drawing.Size(53, 21);
            this.ArDCb.TabIndex = 3;
            this.ArDCb.TabStop = true;
            this.ArDCb.Text = "ArD";
            this.ArDCb.UseVisualStyleBackColor = true;
            this.ArDCb.CheckedChanged += new System.EventHandler(this.ArGCb_CheckedChanged);
            // 
            // ArGCb
            // 
            this.ArGCb.AutoSize = true;
            this.ArGCb.Location = new System.Drawing.Point(172, 4);
            this.ArGCb.Name = "ArGCb";
            this.ArGCb.Size = new System.Drawing.Size(54, 21);
            this.ArGCb.TabIndex = 2;
            this.ArGCb.TabStop = true;
            this.ArGCb.Text = "ArG";
            this.ArGCb.UseVisualStyleBackColor = true;
            this.ArGCb.CheckedChanged += new System.EventHandler(this.ArGCb_CheckedChanged);
            // 
            // AvDCb
            // 
            this.AvDCb.AutoSize = true;
            this.AvDCb.Location = new System.Drawing.Point(87, 4);
            this.AvDCb.Name = "AvDCb";
            this.AvDCb.Size = new System.Drawing.Size(55, 21);
            this.AvDCb.TabIndex = 1;
            this.AvDCb.TabStop = true;
            this.AvDCb.Text = "AvD";
            this.AvDCb.UseVisualStyleBackColor = true;
            this.AvDCb.CheckedChanged += new System.EventHandler(this.ArGCb_CheckedChanged);
            // 
            // AvGCb
            // 
            this.AvGCb.AutoSize = true;
            this.AvGCb.Location = new System.Drawing.Point(3, 4);
            this.AvGCb.Name = "AvGCb";
            this.AvGCb.Size = new System.Drawing.Size(56, 21);
            this.AvGCb.TabIndex = 0;
            this.AvGCb.TabStop = true;
            this.AvGCb.Text = "AvG";
            this.AvGCb.UseVisualStyleBackColor = true;
            this.AvGCb.CheckedChanged += new System.EventHandler(this.ArGCb_CheckedChanged);
            // 
            // AvDLb
            // 
            this.AvDLb.FormattingEnabled = true;
            this.AvDLb.ItemHeight = 16;
            this.AvDLb.Location = new System.Drawing.Point(501, 14);
            this.AvDLb.Name = "AvDLb";
            this.AvDLb.Size = new System.Drawing.Size(80, 84);
            this.AvDLb.TabIndex = 22;
            // 
            // ArGLb
            // 
            this.ArGLb.FormattingEnabled = true;
            this.ArGLb.ItemHeight = 16;
            this.ArGLb.Location = new System.Drawing.Point(587, 14);
            this.ArGLb.Name = "ArGLb";
            this.ArGLb.Size = new System.Drawing.Size(80, 84);
            this.ArGLb.TabIndex = 23;
            // 
            // ArDLb
            // 
            this.ArDLb.FormattingEnabled = true;
            this.ArDLb.ItemHeight = 16;
            this.ArDLb.Location = new System.Drawing.Point(673, 12);
            this.ArDLb.Name = "ArDLb";
            this.ArDLb.Size = new System.Drawing.Size(80, 84);
            this.ArDLb.TabIndex = 24;
            // 
            // AvCLb
            // 
            this.AvCLb.FormattingEnabled = true;
            this.AvCLb.ItemHeight = 16;
            this.AvCLb.Location = new System.Drawing.Point(759, 12);
            this.AvCLb.Name = "AvCLb";
            this.AvCLb.Size = new System.Drawing.Size(80, 84);
            this.AvCLb.TabIndex = 25;
            // 
            // AvGLb
            // 
            this.AvGLb.FormattingEnabled = true;
            this.AvGLb.ItemHeight = 16;
            this.AvGLb.Location = new System.Drawing.Point(415, 14);
            this.AvGLb.Name = "AvGLb";
            this.AvGLb.Size = new System.Drawing.Size(80, 84);
            this.AvGLb.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 603);
            this.Controls.Add(this.AvGLb);
            this.Controls.Add(this.AvCLb);
            this.Controls.Add(this.ArDLb);
            this.Controls.Add(this.ArGLb);
            this.Controls.Add(this.AvDLb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sequenceTimerInput);
            this.Controls.Add(this.buttonSequence);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBoxRelais1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.portComList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sequenceTimerInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox portComList;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBoxRelais1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonSequence;
        private System.Windows.Forms.NumericUpDown sequenceTimerInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ArDCb;
        private System.Windows.Forms.RadioButton ArGCb;
        private System.Windows.Forms.RadioButton AvDCb;
        private System.Windows.Forms.RadioButton AvGCb;
        private System.Windows.Forms.RadioButton AvCCb;
        private System.Windows.Forms.ListBox AvDLb;
        private System.Windows.Forms.ListBox ArGLb;
        private System.Windows.Forms.ListBox ArDLb;
        private System.Windows.Forms.ListBox AvCLb;
        private System.Windows.Forms.ListBox AvGLb;
    }
}

