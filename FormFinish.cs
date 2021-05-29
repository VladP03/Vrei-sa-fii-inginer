using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            textBoxPuncte.ReadOnly = true;
            textBoxPuncte.Text = puncte.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // de bagat in baza de date scor, username si email
            try
            {
                _connectionToOracleDB = Connection.createConnection();
                string name = textBoxUsername.Text;
                int points = Convert.ToInt32(this.textBoxPuncte.Text);

                InsertInto.Records(_connectionToOracleDB, name, points);

            }
            catch (ConnectionException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            catch (InsertIntoException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            Application.Exit();
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            // de bagat in baza de date scor, username si email
            try
            {
                _connectionToOracleDB = Connection.createConnection();
                string name = textBoxUsername.Text;
                int points = Convert.ToInt32(this.textBoxPuncte.Text);

                InsertInto.Records(_connectionToOracleDB, name, points);

            }
            catch (ConnectionException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            catch (InsertIntoException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            } 

            FormBeginning formBeginning = new FormBeginning();
            formBeginning.Show();
            this.Close();
        }
    }
}
