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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

     

        private void tryb1_przycisk_Click(object sender, EventArgs e)
        {
            menu_wolnostrzelny open_wolonstrzelny = new menu_wolnostrzelny();
            open_wolonstrzelny.Show();
            this.Close();

        }

        private void tryb2_przycisk_Click(object sender, EventArgs e)
        {
            menu_szybkostrzelny open_szybkostrzelny = new menu_szybkostrzelny();
            open_szybkostrzelny.Show();
            this.Close();
        }

        private void tryb3_przycisk_Click(object sender, EventArgs e)
        {
            menu_kowbojski open_kowbojski = new menu_kowbojski();
            open_kowbojski.Show();
            this.Close();
        }

        private void back_main_menu_Click(object sender, EventArgs e)
        {
            menu open_menu = new menu();
            open_menu.Show();
            this.Close();
        }

        private void refleks_button_Click(object sender, EventArgs e)
        {
            Menu_refleks open_refleks = new Menu_refleks();
            open_refleks.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void start_Load(object sender, EventArgs e)
        {

        }
    }
}
