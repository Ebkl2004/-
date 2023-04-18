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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void departamentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departamentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.universitet_bdDataSet.faculty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.departament". При необходимости она может быть перемещена или удалена.
            this.departamentTableAdapter.Fill(this.universitet_bdDataSet.departament);

        }

        private void name_of_departamentLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            departamentBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            departamentBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            departamentBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            departamentBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            departamentBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            departamentBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.departamentBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);
        }
    }
}
