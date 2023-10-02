using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tot = 0;
            int avg = 0;
            int tamil = Convert.ToInt32(tamilText.Text);
            int english = Convert.ToInt32(englishText.Text);
            int maths = Convert.ToInt32(mathsText.Text);
            int evs = Convert.ToInt32(evsText.Text);
            int asp = Convert.ToInt32(aspText.Text);
            tot = tamil + english + maths + evs + asp;
            avg = tot / 5;
            totalLbl.Text = "Total mark is "+tot+" average mark is "+avg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tamilText.Clear();
            englishText.Clear();
            mathsText.Clear();
            evsText.Clear(); 
            aspText.Clear();
        }
    }
}
