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

        private int time = 30;
        public FormQuestions()
        {
            InitializeComponent();

            try
            {
                _connectionToOracleDB = Connection.createConnection();

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

            Timer t = new Timer();

            t.Interval = 1000;
            t.Tick += new EventHandler(label1_Click);
            t.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (time >= 10)
                label1.Text = "00:" + time.ToString();
            else
                label1.Text = "00:0" + time.ToString();
            if (time > 0)
                --time;
        }
    }
}
