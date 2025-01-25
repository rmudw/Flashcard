﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcard
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            createSet1.Hide();
            BackBttn.Hide();
        }

        private void create_Click(object sender, EventArgs e)
        {
            BackBttn.Show();
            createSet1.Show();
            createSet1.BringToFront();
        }

        private void back_Click(object sender, EventArgs e)
        {
            BackBttn.Hide();
            createSet1.Hide();
        }

        private void displayHome()
        {
            InitializeComponent();
        }
    }
}
