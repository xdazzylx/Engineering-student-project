﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class EditView : Form
    {
        public EditView()
        {
            InitializeComponent();
        }

        private void Dodaj_bron_Click(object sender, EventArgs e)
        {
            menu_dod_bron open_dodaj_bron = new menu_dod_bron();
            open_dodaj_bron.Show();
            this.Close();
        }

        private void modyfikuj_bron_Click(object sender, EventArgs e)
        {
            DBGuns open_modyf_bron = new DBGuns();
            open_modyf_bron.Show();
            this.Close();
        }

        private void zmien_haslo_Click(object sender, EventArgs e)
        {
            DBLogin open_login_haslo= new DBLogin();
            open_login_haslo.Show();
            this.Close();
        }

        private void edytuj_Load(object sender, EventArgs e)
        {
        }

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            menu open_menu = new menu();
            open_menu.Show();
            this.Close();
        }
    }
}