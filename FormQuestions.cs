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
using BazeDeDate.Connection;
using BazeDeDate.Entities;
using BazeDeDate.Exceptions;
using BazeDeDate.Querys;

namespace InterfataQuestions
{
    public partial class FormQuestions : Form
    {
        private Conexiune _connectionToOracleDB = null;

        public FormQuestions()
        {
            InitializeComponent();

            try
            {
                _connectionToOracleDB = Conexiune.createConnection();
                MessageBox.Show("Succes");

                List<Records> records = SelectAll.FromRecords(_connectionToOracleDB);
                List<Questions> questions = SelectAll.FromQuestions(_connectionToOracleDB);

                labelMaterie.Text = questions[0].Course;
                labelIntrebare.Text = questions[0].Title;
                buttonRaspuns1.Text = questions[0].Right_answer;
                buttonRaspuns2.Text = questions[0].Wrong_answer1;
                buttonRaspuns3.Text = questions[0].Wrong_answer2;
                buttonRaspuns4.Text = questions[0].Wrong_answer3;


            }
            catch (ConnectionException  exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
