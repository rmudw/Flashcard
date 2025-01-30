using System;
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
            reviewSet1.Hide();
            BackBttn.Hide();
        }

        private void create_Click(object sender, EventArgs e)
        {
            BackBttn.Show();
            createSet1.Show();
            createSet1.BringToFront();
            ReviewBttn.Hide();
            CreateBttn.Hide();
            QuitBttn.Hide();
        }

        private void review_Click(object sender, EventArgs e)
        {
            BackBttn.Show();
            reviewSet1.Show();
            reviewSet1.BringToFront();
            ReviewBttn.Hide();
            CreateBttn.Hide();
            QuitBttn.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            BackBttn.Hide();
            createSet1.Hide();
            reviewSet1.Hide();
            ReviewBttn.Show();
            CreateBttn.Show();
            QuitBttn.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
