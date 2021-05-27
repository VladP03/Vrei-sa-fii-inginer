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

// Shuffle
using Shuffle;

namespace InterfataQuestions
{
    public partial class FormQuestions : Form
    {
        private Connection _connectionToOracleDB = null;
        private static List<Questions> _questions = null;
        private static int _countQuestion = 0;
        private static int _rightAnswers = 0;

        private const int _numberOfQuestions = 3;
        private int _secondsForQuestions = 5;
        private Timer _timer = null;
        
        public FormQuestions()
        {
            InitializeComponent();
            labelTimer.Text = "00:30";

            try
            {
                _connectionToOracleDB = Connection.createConnection();

                if (_questions == null)
                {
                    _questions = SelectAll.FromQuestions(_connectionToOracleDB);
                    Randomizare.Shuffle(_questions);
                }

                //List<Records> records = SelectAll.FromRecords(_connectionToOracleDB);
                ShowMaterieIntrebareRaspunsuri(_countQuestion);

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

            _timer = new Timer();

            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(labelTimer_Click);
            _timer.Start();
        }

        private void labelTimer_Click(object sender, EventArgs e)
        {
            if (_secondsForQuestions >= 10)
            {
                labelTimer.Text = "00:" + _secondsForQuestions.ToString();
            }
            else
            {
                labelTimer.Text = "00:0" + _secondsForQuestions.ToString();
            }

            if (_secondsForQuestions == -1 && _countQuestion == _numberOfQuestions)
            {
                FormFinish formFinish = new FormFinish(_rightAnswers);
                formFinish.Show();
                this.Close();
            } 
            else if (_secondsForQuestions == -1)
            {
                nextQuestion();
            }

            _secondsForQuestions--;
        }

        private void ShowMaterieIntrebareRaspunsuri(int index)
        {
            List<string> shuffleAnswers = new List<string>();
            shuffleAnswers.Add(_questions[index].Wrong_answer1);
            shuffleAnswers.Add(_questions[index].Wrong_answer2);
            shuffleAnswers.Add(_questions[index].Wrong_answer3);
            shuffleAnswers.Add(_questions[index].Wrong_answer4);
            shuffleAnswers.Add(_questions[index].Wrong_answer5);
            shuffleAnswers.Add(_questions[index].Wrong_answer6);

            Randomizare.ShuffleAnswers(shuffleAnswers);

            shuffleAnswers.RemoveAt(0);
            shuffleAnswers.RemoveAt(1);
            shuffleAnswers.RemoveAt(2);

            shuffleAnswers.Add(_questions[index].Right_answer);

            Randomizare.ShuffleAnswers(shuffleAnswers);

            labelMaterie.Text = _questions[index].Course;
            labelIntrebare.Text = _questions[index].Title;
            buttonRaspuns1.Text = shuffleAnswers.ElementAt(0);
            buttonRaspuns2.Text = shuffleAnswers.ElementAt(1);
            buttonRaspuns3.Text = shuffleAnswers.ElementAt(2);
            buttonRaspuns4.Text = shuffleAnswers.ElementAt(3);
        }

        private void buttonRaspuns1_Click(object sender, EventArgs e)
        {
            if (buttonRaspuns1.Text.Equals(_questions[_countQuestion].Right_answer))
            {
                _rightAnswers++;
            }

            if (_countQuestion == _numberOfQuestions)
            {
                lastQuestion();
            }
            else
            {
                nextQuestion();
            }
        }

        private void buttonRaspuns2_Click(object sender, EventArgs e)
        {
            if (buttonRaspuns2.Text.Equals(_questions[_countQuestion].Right_answer))
            {
                _rightAnswers++;
            }

            if (_countQuestion == _numberOfQuestions)
            {
                lastQuestion();
            }
            else
            {
                nextQuestion();
            }
        }

        private void buttonRaspuns3_Click(object sender, EventArgs e)
        {
            if (buttonRaspuns3.Text.Equals(_questions[_countQuestion].Right_answer))
            {
                _rightAnswers++;
            }

            if (_countQuestion == _numberOfQuestions)
            {
                lastQuestion();
            }
            else
            {
                nextQuestion();
            }
        }

        private void buttonRaspuns4_Click(object sender, EventArgs e)
        {
            if (buttonRaspuns4.Text.Equals(_questions[_countQuestion].Right_answer))
            {
                _rightAnswers++;
            }

            if (_countQuestion == _numberOfQuestions)
            {
                lastQuestion();
            }
            else
            {
                nextQuestion();
            }

        }

        private void nextQuestion()
        {
            _countQuestion++;

            FormQuestions nextQuestion = new FormQuestions();
            _timer.Stop();
            nextQuestion.Show();
            this.Hide();
        }

        private void lastQuestion()
        {
            FormFinish formFinish = new FormFinish(_rightAnswers);
            _timer.Stop();
            formFinish.Show();
            this.Close();

            _rightAnswers = 0;
            _countQuestion = 0;
        }
    }
}
