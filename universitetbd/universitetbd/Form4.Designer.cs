namespace universitetbd
{
    partial class Form4
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
            System.Windows.Forms.Label iD_study_groupsLabel;
            System.Windows.Forms.Label name_of_groupLabel;
            System.Windows.Forms.Label course_of_studyLabel;
            System.Windows.Forms.Label number_of_studentsLabel;
            System.Windows.Forms.Label year_of_admissionLabel;
            System.Windows.Forms.Label iD_departamentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.universitet_bdDataSet = new universitetbd.universitet_bdDataSet();
            this.study_groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.study_groupsTableAdapter = new universitetbd.universitet_bdDataSetTableAdapters.study_groupsTableAdapter();
            this.tableAdapterManager = new universitetbd.universitet_bdDataSetTableAdapters.TableAdapterManager();
            this.departamentTableAdapter = new universitetbd.universitet_bdDataSetTableAdapters.departamentTableAdapter();
            this.study_groupsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.study_groupsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_study_groupsTextBox = new System.Windows.Forms.TextBox();
            this.name_of_groupTextBox = new System.Windows.Forms.TextBox();
            this.course_of_studyTextBox = new System.Windows.Forms.TextBox();
            this.number_of_studentsTextBox = new System.Windows.Forms.TextBox();
            this.year_of_admissionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iD_departamentListBox = new System.Windows.Forms.ListBox();
            this.departamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iD_study_groupsLabel = new System.Windows.Forms.Label();
            name_of_groupLabel = new System.Windows.Forms.Label();
            course_of_studyLabel = new System.Windows.Forms.Label();
            number_of_studentsLabel = new System.Windows.Forms.Label();
            year_of_admissionLabel = new System.Windows.Forms.Label();
            iD_departamentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universitet_bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.study_groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.study_groupsBindingNavigator)).BeginInit();
            this.study_groupsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_study_groupsLabel
            // 
            iD_study_groupsLabel.AutoSize = true;
            iD_study_groupsLabel.BackColor = System.Drawing.Color.Transparent;
            iD_study_groupsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_study_groupsLabel.Location = new System.Drawing.Point(22, 60);
            iD_study_groupsLabel.Name = "iD_study_groupsLabel";
            iD_study_groupsLabel.Size = new System.Drawing.Size(152, 20);
            iD_study_groupsLabel.TabIndex = 1;
            iD_study_groupsLabel.Text = "ID Учебные группы";
            // 
            // name_of_groupLabel
            // 
            name_of_groupLabel.AutoSize = true;
            name_of_groupLabel.BackColor = System.Drawing.Color.Transparent;
            name_of_groupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_of_groupLabel.Location = new System.Drawing.Point(22, 107);
            name_of_groupLabel.Name = "name_of_groupLabel";
            name_of_groupLabel.Size = new System.Drawing.Size(139, 20);
            name_of_groupLabel.TabIndex = 3;
            name_of_groupLabel.Text = "Название группы";
            // 
            // course_of_studyLabel
            // 
            course_of_studyLabel.AutoSize = true;
            course_of_studyLabel.BackColor = System.Drawing.Color.Transparent;
            course_of_studyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            course_of_studyLabel.Location = new System.Drawing.Point(22, 166);
            course_of_studyLabel.Name = "course_of_studyLabel";
            course_of_studyLabel.Size = new System.Drawing.Size(117, 20);
            course_of_studyLabel.TabIndex = 5;
            course_of_studyLabel.Text = "Курс обучения";
            course_of_studyLabel.Click += new System.EventHandler(this.course_of_studyLabel_Click);
            // 
            // number_of_studentsLabel
            // 
            number_of_studentsLabel.AutoSize = true;
            number_of_studentsLabel.BackColor = System.Drawing.Color.Transparent;
            number_of_studentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_of_studentsLabel.Location = new System.Drawing.Point(22, 220);
            number_of_studentsLabel.Name = "number_of_studentsLabel";
            number_of_studentsLabel.Size = new System.Drawing.Size(184, 20);
            number_of_studentsLabel.TabIndex = 7;
            number_of_studentsLabel.Text = "Количество студентов";
            // 
            // year_of_admissionLabel
            // 
            year_of_admissionLabel.AutoSize = true;
            year_of_admissionLabel.BackColor = System.Drawing.Color.Transparent;
            year_of_admissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            year_of_admissionLabel.Location = new System.Drawing.Point(22, 269);
            year_of_admissionLabel.Name = "year_of_admissionLabel";
            year_of_admissionLabel.Size = new System.Drawing.Size(139, 20);
            year_of_admissionLabel.TabIndex = 9;
            year_of_admissionLabel.Text = "Год поступления";
            // 
            // iD_departamentLabel
            // 
            iD_departamentLabel.AutoSize = true;
            iD_departamentLabel.BackColor = System.Drawing.Color.Transparent;
            iD_departamentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_departamentLabel.Location = new System.Drawing.Point(22, 322);
            iD_departamentLabel.Name = "iD_departamentLabel";
            iD_departamentLabel.Size = new System.Drawing.Size(85, 20);
            iD_departamentLabel.TabIndex = 12;
            iD_departamentLabel.Text = "Кафедра:";
            // 
            // universitet_bdDataSet
            // 
            this.universitet_bdDataSet.DataSetName = "universitet_bdDataSet";
            this.universitet_bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // study_groupsBindingSource
            // 
            this.study_groupsBindingSource.DataMember = "study groups";
            this.study_groupsBindingSource.DataSource = this.universitet_bdDataSet;
            // 
            // study_groupsTableAdapter
            // 
            this.study_groupsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.departamentTableAdapter = this.departamentTableAdapter;
            this.tableAdapterManager.facultyTableAdapter = null;
            this.tableAdapterManager.report_cardTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.study_groupsTableAdapter = this.study_groupsTableAdapter;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = universitetbd.universitet_bdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departamentTableAdapter
            // 
            this.departamentTableAdapter.ClearBeforeFill = true;
            // 
            // study_groupsBindingNavigator
            // 
            this.study_groupsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.study_groupsBindingNavigator.BindingSource = this.study_groupsBindingSource;
            this.study_groupsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.study_groupsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.study_groupsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.study_groupsBindingNavigatorSaveItem});
            this.study_groupsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.study_groupsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.study_groupsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.study_groupsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.study_groupsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.study_groupsBindingNavigator.Name = "study_groupsBindingNavigator";
            this.study_groupsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.study_groupsBindingNavigator.Size = new System.Drawing.Size(894, 25);
            this.study_groupsBindingNavigator.TabIndex = 0;
            this.study_groupsBindingNavigator.Text = "bindingNavigator1";
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
            // study_groupsBindingNavigatorSaveItem
            // 
            this.study_groupsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.study_groupsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("study_groupsBindingNavigatorSaveItem.Image")));
            this.study_groupsBindingNavigatorSaveItem.Name = "study_groupsBindingNavigatorSaveItem";
            this.study_groupsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.study_groupsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.study_groupsBindingNavigatorSaveItem.Click += new System.EventHandler(this.study_groupsBindingNavigatorSaveItem_Click);
            // 
            // iD_study_groupsTextBox
            // 
            this.iD_study_groupsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.study_groupsBindingSource, "ID_study groups", true));
            this.iD_study_groupsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_study_groupsTextBox.Location = new System.Drawing.Point(229, 60);
            this.iD_study_groupsTextBox.Name = "iD_study_groupsTextBox";
            this.iD_study_groupsTextBox.Size = new System.Drawing.Size(157, 26);
            this.iD_study_groupsTextBox.TabIndex = 2;
            // 
            // name_of_groupTextBox
            // 
            this.name_of_groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.study_groupsBindingSource, "name of group", true));
            this.name_of_groupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_of_groupTextBox.Location = new System.Drawing.Point(229, 107);
            this.name_of_groupTextBox.Name = "name_of_groupTextBox";
            this.name_of_groupTextBox.Size = new System.Drawing.Size(157, 26);
            this.name_of_groupTextBox.TabIndex = 4;
            // 
            // course_of_studyTextBox
            // 
            this.course_of_studyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.study_groupsBindingSource, "course of study", true));
            this.course_of_studyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.course_of_studyTextBox.Location = new System.Drawing.Point(229, 166);
            this.course_of_studyTextBox.Name = "course_of_studyTextBox";
            this.course_of_studyTextBox.Size = new System.Drawing.Size(157, 26);
            this.course_of_studyTextBox.TabIndex = 6;
            // 
            // number_of_studentsTextBox
            // 
            this.number_of_studentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.study_groupsBindingSource, "number of students", true));
            this.number_of_studentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_studentsTextBox.Location = new System.Drawing.Point(229, 220);
            this.number_of_studentsTextBox.Name = "number_of_studentsTextBox";
            this.number_of_studentsTextBox.Size = new System.Drawing.Size(157, 26);
            this.number_of_studentsTextBox.TabIndex = 8;
            // 
            // year_of_admissionTextBox
            // 
            this.year_of_admissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.study_groupsBindingSource, "year of admission", true));
            this.year_of_admissionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_of_admissionTextBox.Location = new System.Drawing.Point(229, 269);
            this.year_of_admissionTextBox.Name = "year_of_admissionTextBox";
            this.year_of_admissionTextBox.Size = new System.Drawing.Size(157, 26);
            this.year_of_admissionTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(360, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Учебные группы";
            // 
            // iD_departamentListBox
            // 
            this.iD_departamentListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.study_groupsBindingSource, "ID_departament", true));
            this.iD_departamentListBox.DataSource = this.departamentBindingSource;
            this.iD_departamentListBox.DisplayMember = "name of departament";
            this.iD_departamentListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_departamentListBox.FormattingEnabled = true;
            this.iD_departamentListBox.ItemHeight = 20;
            this.iD_departamentListBox.Location = new System.Drawing.Point(229, 322);
            this.iD_departamentListBox.Name = "iD_departamentListBox";
            this.iD_departamentListBox.Size = new System.Drawing.Size(162, 24);
            this.iD_departamentListBox.TabIndex = 13;
            this.iD_departamentListBox.ValueMember = "ID_departament";
            // 
            // departamentBindingSource
            // 
            this.departamentBindingSource.DataMember = "departament";
            this.departamentBindingSource.DataSource = this.universitet_bdDataSet;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(386, 518);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 38);
            this.button7.TabIndex = 30;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(462, 457);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 46);
            this.button6.TabIndex = 29;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(350, 457);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 46);
            this.button5.TabIndex = 28;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(610, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 35);
            this.button4.TabIndex = 27;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 35);
            this.button3.TabIndex = 26;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 25;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 568);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_departamentLabel);
            this.Controls.Add(this.iD_departamentListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(year_of_admissionLabel);
            this.Controls.Add(this.year_of_admissionTextBox);
            this.Controls.Add(number_of_studentsLabel);
            this.Controls.Add(this.number_of_studentsTextBox);
            this.Controls.Add(course_of_studyLabel);
            this.Controls.Add(this.course_of_studyTextBox);
            this.Controls.Add(name_of_groupLabel);
            this.Controls.Add(this.name_of_groupTextBox);
            this.Controls.Add(iD_study_groupsLabel);
            this.Controls.Add(this.iD_study_groupsTextBox);
            this.Controls.Add(this.study_groupsBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universitet_bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.study_groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.study_groupsBindingNavigator)).EndInit();
            this.study_groupsBindingNavigator.ResumeLayout(false);
            this.study_groupsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private universitet_bdDataSet universitet_bdDataSet;
        private System.Windows.Forms.BindingSource study_groupsBindingSource;
        private universitet_bdDataSetTableAdapters.study_groupsTableAdapter study_groupsTableAdapter;
        private universitet_bdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator study_groupsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton study_groupsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_study_groupsTextBox;
        private System.Windows.Forms.TextBox name_of_groupTextBox;
        private System.Windows.Forms.TextBox course_of_studyTextBox;
        private System.Windows.Forms.TextBox number_of_studentsTextBox;
        private System.Windows.Forms.TextBox year_of_admissionTextBox;
        private System.Windows.Forms.Label label1;
        private universitet_bdDataSetTableAdapters.departamentTableAdapter departamentTableAdapter;
        private System.Windows.Forms.ListBox iD_departamentListBox;
        private System.Windows.Forms.BindingSource departamentBindingSource;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}