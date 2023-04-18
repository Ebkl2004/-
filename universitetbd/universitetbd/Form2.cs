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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.universitet_bdDataSet.faculty);

        }

        private void facultyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);

        }

        private void name_of_facultyLabel_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            facultyBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            facultyBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            facultyBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            facultyBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            facultyBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            facultyBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.facultyBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);
        }
    }
}
