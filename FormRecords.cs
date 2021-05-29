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
    public partial class FormRecords : Form
    {
        private Connection _connectionToOracleDB = null;
        private List<Records> _records = null;

        public FormRecords()
        {
            InitializeComponent();

            //textBoxFirst.Text = "";
            //textBoxSecond.Text = "";
            //textBoxThird.Text = "";

            try
            {
                _connectionToOracleDB = Connection.createConnection();

                _records = SelectAll.FromRecords(_connectionToOracleDB);

                textBoxFirst.Text = _records.ElementAt(0).Name.ToString() + " puncte: " + _records.ElementAt(0).Points.ToString();
                textBoxSecond.Text = _records.ElementAt(1).Name.ToString() + " puncte: " + _records.ElementAt(1).Points.ToString();
                textBoxThird.Text = _records.ElementAt(2).Name.ToString() + " puncte: " + _records.ElementAt(2).Points.ToString();

            }
            catch (ConnectionException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            catch (SelectAllFromException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            FormBeginning formBeginning = new FormBeginning();
            formBeginning.Show();
            this.Close();
        }
    }
}
