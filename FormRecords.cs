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
    public partial class FormRecords : Form
    {
        private Connection _connectionToOracleDB = null;
        private List<Records> _records = null;

        public FormRecords()
        {
            InitializeComponent();

            try
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile("D:\\programe\\repository\\IP\\Vrei-sa-fii-inginer\\Fonts\\OriginTech.ttf");
                labelFirstScore.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                labelFirstUser.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                labelSecondScore.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                labelSecondUser.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                labelThirdScore.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                labelThirdUser.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                buttonMain.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
            catch
            {

            }

            try
            {
                _connectionToOracleDB = Connection.createConnection();

                _records = SelectAll.FromRecords(_connectionToOracleDB);

                switch(_records.Count()) {
                    case 0:
                        break;
                    case 1:
                        labelFirstUser.Text = _records.ElementAt(0).Name.ToString();
                        labelFirstScore.Text = _records.ElementAt(0).Points.ToString();
                        break;
                    case 2:
                        labelFirstUser.Text = _records.ElementAt(0).Name.ToString();
                        labelFirstScore.Text = _records.ElementAt(0).Points.ToString();
                        labelSecondUser.Text = _records.ElementAt(1).Name.ToString();
                        labelSecondScore.Text = _records.ElementAt(1).Points.ToString();
                        break;
                    default:
                        labelFirstUser.Text = _records.ElementAt(0).Name.ToString();
                        labelFirstScore.Text = _records.ElementAt(0).Points.ToString();
                        labelSecondUser.Text = _records.ElementAt(1).Name.ToString();
                        labelSecondScore.Text = _records.ElementAt(1).Points.ToString();
                        labelThirdUser.Text = _records.ElementAt(2).Name.ToString();
                        labelThirdScore.Text = _records.ElementAt(2).Points.ToString();
                        break;
                }
            }
            catch (ConnectionException exception)
            {
                MessageBox.Show(exception.Message);
                Application.Exit();
            }
            catch (SelectAllFromException exception)
            {
                MessageBox.Show(exception.Message);
                Application.Exit();
            }
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            FormBeginning formBeginning = new FormBeginning();
            formBeginning.Show();
            this.Close();
        }

        private void buttonMain_Click_1(object sender, EventArgs e)
        {

        }
    }
}
