using System;
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
            BackBttn.BringToFront();
            ReviewBttn.Hide();
            CreateBttn.Hide();
            BackBttn.Parent = createSet1;
        }

        private void review_Click(object sender, EventArgs e)
        {
            reviewSet1.ClearTextBox();
            BackBttn.Show();
            reviewSet1.Show();
            reviewSet1.BringToFront();
            BackBttn.BringToFront();
            ReviewBttn.Hide();
            CreateBttn.Hide();
            BackBttn.Parent = reviewSet1;
            reviewSet1.LoadAvailableSets();
        }

        private void back_Click(object sender, EventArgs e)
        {
            BackBttn.Hide();
            createSet1.Hide();
            reviewSet1.Hide();
            ReviewBttn.Show();
            CreateBttn.Show();
            BackBttn.Parent = panel1;
        }
    }
}
