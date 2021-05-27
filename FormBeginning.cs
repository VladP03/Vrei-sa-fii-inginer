using System;
using System.Windows.Forms;

namespace InterfataQuestions
{
    public partial class FormBeginning : Form
    {
        public FormBeginning()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            FormQuestions formQuestions = new FormQuestions();
            formQuestions.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            FormRecords formRecords = new FormRecords();
            formRecords.Show();
            this.Close();
        }
    }
}
