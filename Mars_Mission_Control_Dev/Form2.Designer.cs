﻿namespace PI_Mars_Mission_Control
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tagJourActuel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tagJourActuel2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Jour précédent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.jourPrecedent_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Jour suivant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.jourSuivant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jour Actuel : ";
            // 
            // tagJourActuel
            // 
            this.tagJourActuel.AutoSize = true;
            this.tagJourActuel.Location = new System.Drawing.Point(207, 25);
            this.tagJourActuel.Name = "tagJourActuel";
            this.tagJourActuel.Size = new System.Drawing.Size(12, 13);
            this.tagJourActuel.TabIndex = 7;
            this.tagJourActuel.Text = "J";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(827, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Retour au calendrier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.retourCalendrier_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Astronaute 1",
            "Astronaute 2",
            "Astronaute 3"});
            this.comboBox1.Location = new System.Drawing.Point(454, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 20);
            this.textBox1.TabIndex = 37;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(827, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "Insérer activité";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.inserer_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(827, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 23);
            this.button5.TabIndex = 39;
            this.button5.Text = "Modifier activité";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.modifier_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(827, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 23);
            this.button6.TabIndex = 40;
            this.button6.Text = "Supprimer activité";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Compte Rendu du Jour :";
            // 
            // tagJourActuel2
            // 
            this.tagJourActuel2.AutoSize = true;
            this.tagJourActuel2.Location = new System.Drawing.Point(451, 305);
            this.tagJourActuel2.Name = "tagJourActuel2";
            this.tagJourActuel2.Size = new System.Drawing.Size(12, 13);
            this.tagJourActuel2.TabIndex = 42;
            this.tagJourActuel2.Text = "J";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(311, 361);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(469, 20);
            this.textBox2.TabIndex = 43;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 812);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tagJourActuel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tagJourActuel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tagJourActuel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tagJourActuel2;
        private System.Windows.Forms.TextBox textBox2;

        public System.EventHandler comboBox1_SelectedIndexChanged { get; set; }

        public System.EventHandler textBox2_TextChanged { get; set; }
    }
}