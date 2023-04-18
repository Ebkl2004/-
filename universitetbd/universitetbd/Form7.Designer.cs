namespace universitetbd
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_studentLabel;
            System.Windows.Forms.Label iD_teacherLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label markLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.universitet_bdDataSet = new universitetbd.universitet_bdDataSet();
            this.report_cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report_cardTableAdapter = new universitetbd.universitet_bdDataSetTableAdapters.report_cardTableAdapter();
            this.tableAdapterManager = new universitetbd.universitet_bdDataSetTableAdapters.TableAdapterManager();
            this.studentsTableAdapter = new universitetbd.universitet_bdDataSetTableAdapters.studentsTableAdapter();
            this.teachersTableAdapter = new universitetbd.universitet_bdDataSetTableAdapters.teachersTableAdapter();
            this.report_cardBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.report_cardBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_studentListBox = new System.Windows.Forms.ListBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_teacherListBox = new System.Windows.Forms.ListBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.markMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            iD_studentLabel = new System.Windows.Forms.Label();
            iD_teacherLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            markLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universitet_bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_cardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_cardBindingNavigator)).BeginInit();
            this.report_cardBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_studentLabel
            // 
            iD_studentLabel.AutoSize = true;
            iD_studentLabel.BackColor = System.Drawing.Color.Black;
            iD_studentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_studentLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            iD_studentLabel.Location = new System.Drawing.Point(24, 247);
            iD_studentLabel.Name = "iD_studentLabel";
            iD_studentLabel.Size = new System.Drawing.Size(78, 20);
            iD_studentLabel.TabIndex = 1;
            iD_studentLabel.Text = "Студент:";
            // 
            // iD_teacherLabel
            // 
            iD_teacherLabel.AutoSize = true;
            iD_teacherLabel.BackColor = System.Drawing.Color.Black;
            iD_teacherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_teacherLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            iD_teacherLabel.Location = new System.Drawing.Point(24, 325);
            iD_teacherLabel.Name = "iD_teacherLabel";
            iD_teacherLabel.Size = new System.Drawing.Size(136, 20);
            iD_teacherLabel.TabIndex = 3;
            iD_teacherLabel.Text = "Преподаватель:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.BackColor = System.Drawing.Color.Black;
            subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            subjectLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            subjectLabel.Location = new System.Drawing.Point(24, 121);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(83, 20);
            subjectLabel.TabIndex = 5;
            subjectLabel.Text = "Предмет:";
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.BackColor = System.Drawing.Color.Black;
            markLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            markLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            markLabel.Location = new System.Drawing.Point(24, 184);
            markLabel.Name = "markLabel";
            markLabel.Size = new System.Drawing.Size(69, 20);
            markLabel.TabIndex = 7;
            markLabel.Text = "Оценка:";
            // 
            // universitet_bdDataSet
            // 
            this.universitet_bdDataSet.DataSetName = "universitet_bdDataSet";
            this.universitet_bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_cardBindingSource
            // 
            this.report_cardBindingSource.DataMember = "report card";
            this.report_cardBindingSource.DataSource = this.universitet_bdDataSet;
            // 
            // report_cardTableAdapter
            // 
            this.report_cardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.departamentTableAdapter = null;
            this.tableAdapterManager.facultyTableAdapter = null;
            this.tableAdapterManager.report_cardTableAdapter = this.report_cardTableAdapter;
            this.tableAdapterManager.studentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.study_groupsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = universitetbd.universitet_bdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // report_cardBindingNavigator
            // 
            this.report_cardBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.report_cardBindingNavigator.BindingSource = this.report_cardBindingSource;
            this.report_cardBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.report_cardBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.report_cardBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.report_cardBindingNavigatorSaveItem});
            this.report_cardBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.report_cardBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.report_cardBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.report_cardBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.report_cardBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.report_cardBindingNavigator.Name = "report_cardBindingNavigator";
            this.report_cardBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.report_cardBindingNavigator.Size = new System.Drawing.Size(1080, 25);
            this.report_cardBindingNavigator.TabIndex = 0;
            this.report_cardBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // report_cardBindingNavigatorSaveItem
            // 
            this.report_cardBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.report_cardBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("report_cardBindingNavigatorSaveItem.Image")));
            this.report_cardBindingNavigatorSaveItem.Name = "report_cardBindingNavigatorSaveItem";
            this.report_cardBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.report_cardBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.report_cardBindingNavigatorSaveItem.Click += new System.EventHandler(this.report_cardBindingNavigatorSaveItem_Click);
            // 
            // iD_studentListBox
            // 
            this.iD_studentListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.report_cardBindingSource, "ID_student", true));
            this.iD_studentListBox.DataSource = this.studentsBindingSource;
            this.iD_studentListBox.DisplayMember = "FIO of student";
            this.iD_studentListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_studentListBox.FormattingEnabled = true;
            this.iD_studentListBox.ItemHeight = 20;
            this.iD_studentListBox.Location = new System.Drawing.Point(167, 243);
            this.iD_studentListBox.Name = "iD_studentListBox";
            this.iD_studentListBox.Size = new System.Drawing.Size(120, 24);
            this.iD_studentListBox.TabIndex = 2;
            this.iD_studentListBox.ValueMember = "ID_student";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.universitet_bdDataSet;
            // 
            // iD_teacherListBox
            // 
            this.iD_teacherListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.report_cardBindingSource, "ID_teacher", true));
            this.iD_teacherListBox.DataSource = this.teachersBindingSource;
            this.iD_teacherListBox.DisplayMember = "FIO of teacher";
            this.iD_teacherListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_teacherListBox.FormattingEnabled = true;
            this.iD_teacherListBox.ItemHeight = 20;
            this.iD_teacherListBox.Location = new System.Drawing.Point(173, 325);
            this.iD_teacherListBox.Name = "iD_teacherListBox";
            this.iD_teacherListBox.Size = new System.Drawing.Size(120, 24);
            this.iD_teacherListBox.TabIndex = 4;
            this.iD_teacherListBox.ValueMember = "ID_teacher";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.universitet_bdDataSet;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.report_cardBindingSource, "subject", true));
            this.subjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectTextBox.Location = new System.Drawing.Point(167, 121);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(163, 26);
            this.subjectTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(420, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ведомость успеваемости";
            // 
            // markMaskedTextBox
            // 
            this.markMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.report_cardBindingSource, "mark", true));
            this.markMaskedTextBox.Location = new System.Drawing.Point(167, 190);
            this.markMaskedTextBox.Mask = "0";
            this.markMaskedTextBox.Name = "markMaskedTextBox";
            this.markMaskedTextBox.Size = new System.Drawing.Size(96, 20);
            this.markMaskedTextBox.TabIndex = 10;
            this.markMaskedTextBox.ValidatingType = typeof(int);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(442, 573);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 38);
            this.button7.TabIndex = 44;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(530, 486);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 46);
            this.button6.TabIndex = 43;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(390, 486);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 46);
            this.button5.TabIndex = 42;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(683, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 35);
            this.button4.TabIndex = 41;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(520, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 35);
            this.button3.TabIndex = 40;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(353, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 39;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(177, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.TabIndex = 38;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(694, 503);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(138, 29);
            this.button8.TabIndex = 45;
            this.button8.Text = "Табличный вид";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 688);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.markMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(markLabel);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(iD_teacherLabel);
            this.Controls.Add(this.iD_teacherListBox);
            this.Controls.Add(iD_studentLabel);
            this.Controls.Add(this.iD_studentListBox);
            this.Controls.Add(this.report_cardBindingNavigator);
            this.Name = "Form7";
            this.Text = "Ведомость успеваемости";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universitet_bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_cardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_cardBindingNavigator)).EndInit();
            this.report_cardBindingNavigator.ResumeLayout(false);
            this.report_cardBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private universitet_bdDataSet universitet_bdDataSet;
        private System.Windows.Forms.BindingSource report_cardBindingSource;
        private universitet_bdDataSetTableAdapters.report_cardTableAdapter report_cardTableAdapter;
        private universitet_bdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator report_cardBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton report_cardBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox iD_studentListBox;
        private universitet_bdDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.ListBox iD_teacherListBox;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private universitet_bdDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox markMaskedTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
    }
}