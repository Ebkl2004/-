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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void study_groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.study_groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.departament". При необходимости она может быть перемещена или удалена.
            this.departamentTableAdapter.Fill(this.universitet_bdDataSet.departament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.study_groups". При необходимости она может быть перемещена или удалена.
            this.study_groupsTableAdapter.Fill(this.universitet_bdDataSet.study_groups);

        }

        private void course_of_studyLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            study_groupsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            study_groupsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            study_groupsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            study_groupsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            study_groupsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            study_groupsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.study_groupsBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);
        }
    }
}
