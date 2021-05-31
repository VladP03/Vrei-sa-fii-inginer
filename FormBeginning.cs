using System;
using System.Drawing;
using System.Drawing.Text;
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
            try
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile("P:\\Facultate\\Proict IP Final\\Vrei-sa-fii-inginer\\Fonts\\OriginTech.ttf");
                buttonPlay.Font = new Font(pfc.Families[0], 17, FontStyle.Regular);
                buttonRecords.Font = new Font(pfc.Families[0], 17, FontStyle.Regular);
                buttonHelp.Font = new Font(pfc.Families[0], 17, FontStyle.Regular);
                buttonExit.Font = new Font(pfc.Families[0], 17, FontStyle.Regular);
            }
            catch
            {

            }
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
          //  this.Hide();
        }

        private void FormBeginning_Load(object sender, EventArgs e)
        {

        }
    }
}
