using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Baze de date
using DataBase.ConnectionToOracleDB;
using DataBase.Entities;
using DataBase.Exceptions;
using DataBase.Queries;

namespace InterfataQuestions
{
    public partial class FormFinish : Form
    {
        private Connection _connectionToOracleDB = null;

        public FormFinish(int puncte)
        {
            InitializeComponent();
            try
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile("P:\\Facultate\\Proict IP Final\\Vrei-sa-fii-inginer\\Fonts\\OriginTech.ttf");
                labelPuncte.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                textBoxPuncte.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                labelUsername.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                textBoxUsername.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                buttonMain.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                buttonExit.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
            catch
            {

            }

            textBoxPuncte.ReadOnly = true;
            textBoxPuncte.Text = puncte.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            try
            {
                _connectionToOracleDB = Connection.createConnection();

                string name = null;
                if (textBoxUsername.Text != "")
                {
                    name = textBoxUsername.Text;
                } else
                {
                    name = "undefined";
                }

                int points = Convert.ToInt32(this.textBoxPuncte.Text);

                InsertInto.Records(_connectionToOracleDB, name, points);

                Application.Exit();
            }
            catch (ConnectionException exception)
            {
                MessageBox.Show(exception.Message);
                Application.Exit();
            }
            catch (InsertIntoException exception)
            {
                MessageBox.Show(exception.Message);
                Application.Exit();
            }
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            try
            {
                _connectionToOracleDB = Connection.createConnection();

                string name = null;
                if (textBoxUsername.Text != "")
                {
                    name = textBoxUsername.Text;
                }
                else
                {
                    name = "undefined";
                }
                int points = Convert.ToInt32(this.textBoxPuncte.Text);

                InsertInto.Records(_connectionToOracleDB, name, points);
            }
            catch (ConnectionException exception)
            {
                MessageBox.Show(exception.Message);
                Application.Exit();
            }
            catch (InsertIntoException exception)
            {
                MessageBox.Show(exception.Message);
                Application.Exit();
            }

            FormBeginning formBeginning = new FormBeginning();
            formBeginning.Show();
            this.Close();
        }

        private void textBoxPuncte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
