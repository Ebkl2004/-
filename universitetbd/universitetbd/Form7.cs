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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void report_cardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.report_cardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.universitet_bdDataSet.teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.universitet_bdDataSet.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.report_card". При необходимости она может быть перемещена или удалена.
            this.report_cardTableAdapter.Fill(this.universitet_bdDataSet.report_card);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            report_cardBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report_cardBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report_cardBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            report_cardBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            report_cardBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            report_cardBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.report_cardBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 ptable = new Form8();
            ptable.Visible = true;
        }
    }
}
