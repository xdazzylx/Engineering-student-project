﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingRange
{
    public partial class DBLogin : Form
    {
        public DBLogin()
        {
            InitializeComponent();
        }

        private void dodaj_uzytkownika_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.Username = textBox_dodaj_login.Text;

            Properties.Settings.Default.Password = textBox_dodaj_haslo.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Account created");



        }

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            ModesView open_menu = new ModesView();
            open_menu.Show();
            this.Close();
        }

        private void dodaj_login_haslo_Load(object sender, EventArgs e)
        {

        }
    }
}
