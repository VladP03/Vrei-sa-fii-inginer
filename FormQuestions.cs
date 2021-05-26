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
using DataBase.Querys;

namespace InterfataQuestions
{
    public partial class FormQuestions : Form
    {
        private Connection _connectionToOracleDB = null;
        private List<Questions> _questions = null;
        private static int _countQuestion = 0;
        private static int _rightAnswers = 0;

        private int time = 29;
        public FormQuestions()
        {
            InitializeComponent();
            labelTimer.Text = "00:30";

            try
            {
                _connectionToOracleDB = Connection.createConnection();

                //List<Records> records = SelectAll.FromRecords(_connectionToOracleDB);
                _questions = SelectAll.FromQuestions(_connectionToOracleDB);

                Refresh(_countQuestion);

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

            Timer t = new Timer();

            t.Interval = 1000;
            t.Tick += new EventHandler(labelTimer_Click);
            t.Start();
        }

        private void labelTimer_Click(object sender, EventArgs e)
        {
            if (time >= 10)
                labelTimer.Text = "00:" + time.ToString();
            else
                labelTimer.Text = "00:0" + time.ToString();
            if (time > 0)
                --time;
        }

        private void Refresh(int index)
        {

            //labelMaterie.Text = _questions[index].Course;
            labelIntrebare.Text = _questions[index].Title;
            buttonRaspuns1.Text = _questions[index].Right_answer;
            buttonRaspuns2.Text = _questions[index].Wrong_answer1;
            buttonRaspuns3.Text = _questions[index].Wrong_answer2;
            buttonRaspuns4.Text = _questions[index].Wrong_answer3;
        }

        private void buttonRaspuns1_Click(object sender, EventArgs e)
        {
            if (buttonRaspuns1.Text.Equals(_questions[_countQuestion].Right_answer))
            {
                _rightAnswers++;
                labelMaterie.Text = "DA1";
            }
            else
            {
                labelMaterie.Text = "NU1";
            }

            _countQuestion++;

            FormQuestions temp = new FormQuestions();
            temp.Show();
            this.Hide();
        }

        private void buttonRaspuns2_Click(object sender, EventArgs e)
        {
            if (buttonRaspuns2.Text.Equals(_questions[_countQuestion].Right_answer))
            {
                _rightAnswers++;
                labelMaterie.Text = "DA2";
            }
            else
            {
                labelMaterie.Text = "NU2";
            }
        }

        private void buttonRaspuns3_Click(object sender, EventArgs e)
        {
            if (buttonRaspuns3.Text.Equals(_questions[_countQuestion].Right_answer))
            {
                _rightAnswers++;
                labelMaterie.Text = "DA3";
            }
            else
            {
                labelMaterie.Text = "NU3";
            }
        }

        private void buttonRaspuns4_Click(object sender, EventArgs e)
        {
            if (buttonRaspuns4.Text.Equals(_questions[_countQuestion].Right_answer))
            {
                _rightAnswers++;
                labelMaterie.Text = "DA4";
            }
            else
            {
                labelMaterie.Text = "NU4";
            }
        }
    }
}
