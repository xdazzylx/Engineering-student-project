﻿namespace WindowsFormsApplication3
{
    partial class menu_modyf_bron
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
            this.comboBox_wybierzbron = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.model_broni_przenies = new System.Windows.Forms.TextBox();
            this.typ_broni_przenies = new System.Windows.Forms.TextBox();
            this.naped_broni_przenies = new System.Windows.Forms.TextBox();
            this.Pojemnosc_broni_przenies = new System.Windows.Forms.TextBox();
            this.FPS_broni_przenies = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.model_broni = new System.Windows.Forms.TextBox();
            this.typ_broni = new System.Windows.Forms.TextBox();
            this.naped_broni = new System.Windows.Forms.TextBox();
            this.Pojemnosc_broni = new System.Windows.Forms.TextBox();
            this.FPS_broni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modyfikuj_przycisk = new System.Windows.Forms.Button();
            this.przenies1 = new System.Windows.Forms.Button();
            this.przenies2 = new System.Windows.Forms.Button();
            this.przenies3 = new System.Windows.Forms.Button();
            this.przenies4 = new System.Windows.Forms.Button();
            this.przenies5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.back_main_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_wybierzbron
            // 
            this.comboBox_wybierzbron.FormattingEnabled = true;
            this.comboBox_wybierzbron.Location = new System.Drawing.Point(73, 46);
            this.comboBox_wybierzbron.Name = "comboBox_wybierzbron";
            this.comboBox_wybierzbron.Size = new System.Drawing.Size(127, 21);
            this.comboBox_wybierzbron.TabIndex = 0;
            this.comboBox_wybierzbron.SelectedIndexChanged += new System.EventHandler(this.comboBox_wybierzbron_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wyświetlono";
            // 
            // model_broni_przenies
            // 
            this.model_broni_przenies.Location = new System.Drawing.Point(329, 129);
            this.model_broni_przenies.Name = "model_broni_przenies";
            this.model_broni_przenies.Size = new System.Drawing.Size(105, 20);
            this.model_broni_przenies.TabIndex = 2;
            this.model_broni_przenies.TextChanged += new System.EventHandler(this.model_broni_przenies_TextChanged);
            // 
            // typ_broni_przenies
            // 
            this.typ_broni_przenies.Location = new System.Drawing.Point(329, 178);
            this.typ_broni_przenies.Name = "typ_broni_przenies";
            this.typ_broni_przenies.Size = new System.Drawing.Size(105, 20);
            this.typ_broni_przenies.TabIndex = 3;
            this.typ_broni_przenies.TextChanged += new System.EventHandler(this.typ_broni_przenies_TextChanged);
            // 
            // naped_broni_przenies
            // 
            this.naped_broni_przenies.Location = new System.Drawing.Point(329, 220);
            this.naped_broni_przenies.Name = "naped_broni_przenies";
            this.naped_broni_przenies.Size = new System.Drawing.Size(105, 20);
            this.naped_broni_przenies.TabIndex = 4;
            this.naped_broni_przenies.TextChanged += new System.EventHandler(this.naped_broni_przenies_TextChanged);
            // 
            // Pojemnosc_broni_przenies
            // 
            this.Pojemnosc_broni_przenies.Location = new System.Drawing.Point(329, 261);
            this.Pojemnosc_broni_przenies.Name = "Pojemnosc_broni_przenies";
            this.Pojemnosc_broni_przenies.Size = new System.Drawing.Size(105, 20);
            this.Pojemnosc_broni_przenies.TabIndex = 5;
            this.Pojemnosc_broni_przenies.TextChanged += new System.EventHandler(this.Pojemnosc_broni_przenies_TextChanged);
            // 
            // FPS_broni_przenies
            // 
            this.FPS_broni_przenies.Location = new System.Drawing.Point(329, 306);
            this.FPS_broni_przenies.Name = "FPS_broni_przenies";
            this.FPS_broni_przenies.Size = new System.Drawing.Size(105, 20);
            this.FPS_broni_przenies.TabIndex = 6;
            this.FPS_broni_przenies.TextChanged += new System.EventHandler(this.FPS_broni_przenies_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edytuj";
            // 
            // model_broni
            // 
            this.model_broni.Location = new System.Drawing.Point(43, 129);
            this.model_broni.Name = "model_broni";
            this.model_broni.ReadOnly = true;
            this.model_broni.Size = new System.Drawing.Size(110, 20);
            this.model_broni.TabIndex = 8;
            // 
            // typ_broni
            // 
            this.typ_broni.Location = new System.Drawing.Point(43, 178);
            this.typ_broni.Name = "typ_broni";
            this.typ_broni.ReadOnly = true;
            this.typ_broni.Size = new System.Drawing.Size(110, 20);
            this.typ_broni.TabIndex = 9;
            // 
            // naped_broni
            // 
            this.naped_broni.Location = new System.Drawing.Point(45, 224);
            this.naped_broni.Name = "naped_broni";
            this.naped_broni.ReadOnly = true;
            this.naped_broni.Size = new System.Drawing.Size(110, 20);
            this.naped_broni.TabIndex = 10;
            // 
            // Pojemnosc_broni
            // 
            this.Pojemnosc_broni.Location = new System.Drawing.Point(43, 265);
            this.Pojemnosc_broni.Name = "Pojemnosc_broni";
            this.Pojemnosc_broni.ReadOnly = true;
            this.Pojemnosc_broni.Size = new System.Drawing.Size(110, 20);
            this.Pojemnosc_broni.TabIndex = 11;
            // 
            // FPS_broni
            // 
            this.FPS_broni.Location = new System.Drawing.Point(43, 306);
            this.FPS_broni.Name = "FPS_broni";
            this.FPS_broni.ReadOnly = true;
            this.FPS_broni.Size = new System.Drawing.Size(110, 20);
            this.FPS_broni.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Model broni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Typ ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Napęd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pojemność magazynka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Prędkość wylotowa FPS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Wybierz broń";
            // 
            // modyfikuj_przycisk
            // 
            this.modyfikuj_przycisk.Location = new System.Drawing.Point(314, 46);
            this.modyfikuj_przycisk.Name = "modyfikuj_przycisk";
            this.modyfikuj_przycisk.Size = new System.Drawing.Size(120, 28);
            this.modyfikuj_przycisk.TabIndex = 19;
            this.modyfikuj_przycisk.Text = "Modyfikuj";
            this.modyfikuj_przycisk.UseVisualStyleBackColor = true;
            this.modyfikuj_przycisk.Click += new System.EventHandler(this.modyfikuj_przycisk_Click);
            // 
            // przenies1
            // 
            this.przenies1.Location = new System.Drawing.Point(283, 122);
            this.przenies1.Name = "przenies1";
            this.przenies1.Size = new System.Drawing.Size(26, 26);
            this.przenies1.TabIndex = 20;
            this.przenies1.Text = ">";
            this.przenies1.UseVisualStyleBackColor = true;
            this.przenies1.Click += new System.EventHandler(this.przenies1_Click);
            // 
            // przenies2
            // 
            this.przenies2.Location = new System.Drawing.Point(283, 171);
            this.przenies2.Name = "przenies2";
            this.przenies2.Size = new System.Drawing.Size(26, 26);
            this.przenies2.TabIndex = 21;
            this.przenies2.Text = ">";
            this.przenies2.UseVisualStyleBackColor = true;
            this.przenies2.Click += new System.EventHandler(this.przenies2_Click);
            // 
            // przenies3
            // 
            this.przenies3.Location = new System.Drawing.Point(283, 220);
            this.przenies3.Name = "przenies3";
            this.przenies3.Size = new System.Drawing.Size(26, 26);
            this.przenies3.TabIndex = 22;
            this.przenies3.Text = ">";
            this.przenies3.UseVisualStyleBackColor = true;
            this.przenies3.Click += new System.EventHandler(this.przenies3_Click);
            // 
            // przenies4
            // 
            this.przenies4.Location = new System.Drawing.Point(283, 261);
            this.przenies4.Name = "przenies4";
            this.przenies4.Size = new System.Drawing.Size(26, 26);
            this.przenies4.TabIndex = 23;
            this.przenies4.Text = ">";
            this.przenies4.UseVisualStyleBackColor = true;
            this.przenies4.Click += new System.EventHandler(this.przenies4_Click);
            // 
            // przenies5
            // 
            this.przenies5.Location = new System.Drawing.Point(283, 302);
            this.przenies5.Name = "przenies5";
            this.przenies5.Size = new System.Drawing.Size(26, 26);
            this.przenies5.TabIndex = 24;
            this.przenies5.Text = ">";
            this.przenies5.UseVisualStyleBackColor = true;
            this.przenies5.Click += new System.EventHandler(this.przenies5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Przenieś";
            // 
            // back_main_menu
            // 
            this.back_main_menu.Location = new System.Drawing.Point(471, 12);
            this.back_main_menu.Name = "back_main_menu";
            this.back_main_menu.Size = new System.Drawing.Size(105, 62);
            this.back_main_menu.TabIndex = 26;
            this.back_main_menu.Text = "COFNIJ DO MENU GŁÓWNEGO";
            this.back_main_menu.UseVisualStyleBackColor = true;
            this.back_main_menu.Click += new System.EventHandler(this.back_main_menu_Click);
            // 
            // menu_modyf_bron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(588, 356);
            this.Controls.Add(this.back_main_menu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.przenies5);
            this.Controls.Add(this.przenies4);
            this.Controls.Add(this.przenies3);
            this.Controls.Add(this.przenies2);
            this.Controls.Add(this.przenies1);
            this.Controls.Add(this.modyfikuj_przycisk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FPS_broni);
            this.Controls.Add(this.Pojemnosc_broni);
            this.Controls.Add(this.naped_broni);
            this.Controls.Add(this.typ_broni);
            this.Controls.Add(this.model_broni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FPS_broni_przenies);
            this.Controls.Add(this.Pojemnosc_broni_przenies);
            this.Controls.Add(this.naped_broni_przenies);
            this.Controls.Add(this.typ_broni_przenies);
            this.Controls.Add(this.model_broni_przenies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_wybierzbron);
            this.Name = "menu_modyf_bron";
            this.Text = "Modyfikuj broń";
            this.Load += new System.EventHandler(this.menu_modyf_bron_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_wybierzbron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox model_broni_przenies;
        private System.Windows.Forms.TextBox typ_broni_przenies;
        private System.Windows.Forms.TextBox naped_broni_przenies;
        private System.Windows.Forms.TextBox Pojemnosc_broni_przenies;
        private System.Windows.Forms.TextBox FPS_broni_przenies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox model_broni;
        private System.Windows.Forms.TextBox typ_broni;
        private System.Windows.Forms.TextBox naped_broni;
        private System.Windows.Forms.TextBox Pojemnosc_broni;
        private System.Windows.Forms.TextBox FPS_broni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button modyfikuj_przycisk;
        private System.Windows.Forms.Button przenies1;
        private System.Windows.Forms.Button przenies2;
        private System.Windows.Forms.Button przenies3;
        private System.Windows.Forms.Button przenies4;
        private System.Windows.Forms.Button przenies5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button back_main_menu;
    }
}