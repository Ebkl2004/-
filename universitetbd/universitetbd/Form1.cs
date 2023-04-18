using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universitetbd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 facult = new Form2();
            facult.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 students = new Form5();
            students.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 departament = new Form3();
            departament.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 studygroups = new Form4();
            studygroups.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 teachers = new Form6();
            teachers.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 reportcard = new Form7();
            reportcard.Visible = true;
        }
    }
}
