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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.universitet_bdDataSet.teachers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teachersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teachersBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teachersBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            teachersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            teachersBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            teachersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.teachersBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);
        }
    }
}
