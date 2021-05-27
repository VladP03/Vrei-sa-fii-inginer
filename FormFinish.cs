﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataQuestions
{
    public partial class FormFinish : Form
    {
        public FormFinish(int puncte)
        {
            InitializeComponent();
            textBoxPuncte.ReadOnly = true;
            textBoxPuncte.Text = puncte.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // de bagat in baza de date scor, username si email
            Application.Exit();
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            // de bagat in baza de date scor, username si email

            FormBeginning formBeginning = new FormBeginning();
            formBeginning.Show();
            this.Close();
        }
    }
}
