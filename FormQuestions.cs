using System;
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
    public partial class FormQuestions : Form
    {
        private int time = 30;
        public FormQuestions()
        {
            InitializeComponent();

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
