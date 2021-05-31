using System;
using System.Windows.Forms;

namespace InterfataQuestions
{
    public partial class FormBeginning : Form
    {
        FormQuestions _formQuestions = null;
        FormRecords _formRecords = null;

        public FormBeginning()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            _formQuestions = new FormQuestions();
            _formQuestions.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            _formRecords = new FormRecords();
            _formRecords.Show();
            this.Hide();
        }
    }
}
