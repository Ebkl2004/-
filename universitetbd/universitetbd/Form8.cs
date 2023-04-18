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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void report_cardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.report_cardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universitet_bdDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universitet_bdDataSet.report_card". При необходимости она может быть перемещена или удалена.
            this.report_cardTableAdapter.Fill(this.universitet_bdDataSet.report_card);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            report_cardBindingSource.Filter = "NAME='" + comboBox1.Text + "'";
        }

        private void report_cardDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            System.Windows.Forms.DataGridViewColumn COL = new System.Windows.Forms.DataGridViewColumn();
            //блок switch, присваивающий в
            //переменную Col имя выбранного столбца таблицы в зависимости от номера
            //выбранного пункта списка (ListBox1.SelectedIndex). Если выбран первый пункт
            //списка, то в переменную Col записывается столбец
            //DataGridViewTextBoxColumn2, если второй, то – DataGridViewTextBoxColumn3
            //и так далее. Хотелось бы отметить тот факт, что нумерация пунктов списка
            //начинается с нуля, а нумерация столбцов с единицы. Первый столбец «Наименование»
            //носит имя DataGridViewTextBoxColumn2, так как имя
            //DataGridViewTextBoxColumn1 имеет столбец заголовков строк;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn3;
                    break;
            }
            //Блок If выполняет следующую операцию: если включён
            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю заданному в переменной Col по возрастанию
            //(pRODUCTSDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (pRODUCTSDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked)
                report_cardDataGridView.Sort(COL, ListSortDirection.Ascending);
            else
                report_cardDataGridView.Sort(COL, ListSortDirection.Descending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report_cardBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < report_cardDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < report_cardDataGridView.RowCount - 1; j++)
                {
                    report_cardDataGridView[i, j].Style.BackColor = Color.White;
                    report_cardDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < report_cardDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < report_cardDataGridView.RowCount - 1; j++)
                {
                    if (report_cardDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        report_cardDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        report_cardDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}