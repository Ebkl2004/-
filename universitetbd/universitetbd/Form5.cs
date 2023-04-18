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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.study_groups". При необходимости она может быть перемещена или удалена.
            this.study_groupsTableAdapter.Fill(this.universitet_bdDataSet.study_groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.universitet_bdDataSet.students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MoveFirst();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            studentsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.studentsBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);
        }
    }
}
