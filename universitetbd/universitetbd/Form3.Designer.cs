namespace universitetbd
{
    partial class Form3
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
            System.Windows.Forms.Label iD_departamentLabel;
            System.Windows.Forms.Label name_of_departamentLabel;
            System.Windows.Forms.Label fIO_of_headLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label number_of_teachersLabel;
            System.Windows.Forms.Label iD_facultyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.universitet_bdDataSet = new universitetbd.universitet_bdDataSet();
            this.departamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentTableAdapter = new universitetbd.universitet_bdDataSetTableAdapters.departamentTableAdapter();
            this.tableAdapterManager = new universitetbd.universitet_bdDataSetTableAdapters.TableAdapterManager();
            this.facultyTableAdapter = new universitetbd.universitet_bdDataSetTableAdapters.facultyTableAdapter();
            this.departamentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.departamentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_departamentTextBox = new System.Windows.Forms.TextBox();
            this.name_of_departamentTextBox = new System.Windows.Forms.TextBox();
            this.fIO_of_headTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.number_of_teachersTextBox = new System.Windows.Forms.TextBox();
            this.iD_facultyListBox = new System.Windows.Forms.ListBox();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iD_departamentLabel = new System.Windows.Forms.Label();
            name_of_departamentLabel = new System.Windows.Forms.Label();
            fIO_of_headLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            number_of_teachersLabel = new System.Windows.Forms.Label();
            iD_facultyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universitet_bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingNavigator)).BeginInit();
            this.departamentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_departamentLabel
            // 
            iD_departamentLabel.AutoSize = true;
            iD_departamentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            iD_departamentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_departamentLabel.ForeColor = System.Drawing.Color.Black;
            iD_departamentLabel.Location = new System.Drawing.Point(31, 83);
            iD_departamentLabel.Name = "iD_departamentLabel";
            iD_departamentLabel.Size = new System.Drawing.Size(104, 20);
            iD_departamentLabel.TabIndex = 2;
            iD_departamentLabel.Text = "ID Кафедры";
            // 
            // name_of_departamentLabel
            // 
            name_of_departamentLabel.AutoSize = true;
            name_of_departamentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            name_of_departamentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_of_departamentLabel.ForeColor = System.Drawing.Color.Black;
            name_of_departamentLabel.Location = new System.Drawing.Point(31, 136);
            name_of_departamentLabel.Name = "name_of_departamentLabel";
            name_of_departamentLabel.Size = new System.Drawing.Size(159, 20);
            name_of_departamentLabel.TabIndex = 4;
            name_of_departamentLabel.Text = "Название кафедры";
            name_of_departamentLabel.Click += new System.EventHandler(this.name_of_departamentLabel_Click);
            // 
            // fIO_of_headLabel
            // 
            fIO_of_headLabel.AutoSize = true;
            fIO_of_headLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            fIO_of_headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fIO_of_headLabel.ForeColor = System.Drawing.Color.Black;
            fIO_of_headLabel.Location = new System.Drawing.Point(36, 194);
            fIO_of_headLabel.Name = "fIO_of_headLabel";
            fIO_of_headLabel.Size = new System.Drawing.Size(154, 20);
            fIO_of_headLabel.TabIndex = 6;
            fIO_of_headLabel.Text = "ФИО заведующего";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.ForeColor = System.Drawing.Color.Black;
            phoneLabel.Location = new System.Drawing.Point(36, 250);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(79, 20);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Телефон";
            // 
            // number_of_teachersLabel
            // 
            number_of_teachersLabel.AutoSize = true;
            number_of_teachersLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            number_of_teachersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_of_teachersLabel.ForeColor = System.Drawing.Color.Black;
            number_of_teachersLabel.Location = new System.Drawing.Point(582, 157);
            number_of_teachersLabel.Name = "number_of_teachersLabel";
            number_of_teachersLabel.Size = new System.Drawing.Size(194, 20);
            number_of_teachersLabel.TabIndex = 10;
            number_of_teachersLabel.Text = "Кол-во преподавателей";
            // 
            // iD_facultyLabel
            // 
            iD_facultyLabel.AutoSize = true;
            iD_facultyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            iD_facultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_facultyLabel.ForeColor = System.Drawing.Color.Black;
            iD_facultyLabel.Location = new System.Drawing.Point(582, 83);
            iD_facultyLabel.Name = "iD_facultyLabel";
            iD_facultyLabel.Size = new System.Drawing.Size(181, 20);
            iD_facultyLabel.TabIndex = 12;
            iD_facultyLabel.Text = "Название факультета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(438, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кафедра";
            // 
            // universitet_bdDataSet
            // 
            this.universitet_bdDataSet.DataSetName = "universitet_bdDataSet";
            this.universitet_bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentBindingSource
            // 
            this.departamentBindingSource.DataMember = "departament";
            this.departamentBindingSource.DataSource = this.universitet_bdDataSet;
            // 
            // departamentTableAdapter
            // 
            this.departamentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.departamentTableAdapter = this.departamentTableAdapter;
            this.tableAdapterManager.facultyTableAdapter = this.facultyTableAdapter;
            this.tableAdapterManager.report_cardTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.study_groupsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = universitetbd.universitet_bdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // departamentBindingNavigator
            // 
            this.departamentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.departamentBindingNavigator.BindingSource = this.departamentBindingSource;
            this.departamentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.departamentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.departamentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.departamentBindingNavigatorSaveItem});
            this.departamentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.departamentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.departamentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.departamentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.departamentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.departamentBindingNavigator.Name = "departamentBindingNavigator";
            this.departamentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.departamentBindingNavigator.Size = new System.Drawing.Size(1032, 25);
            this.departamentBindingNavigator.TabIndex = 1;
            this.departamentBindingNavigator.Text = "bindingNavigator1";
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
            // departamentBindingNavigatorSaveItem
            // 
            this.departamentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.departamentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("departamentBindingNavigatorSaveItem.Image")));
            this.departamentBindingNavigatorSaveItem.Name = "departamentBindingNavigatorSaveItem";
            this.departamentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.departamentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.departamentBindingNavigatorSaveItem.Click += new System.EventHandler(this.departamentBindingNavigatorSaveItem_Click);
            // 
            // iD_departamentTextBox
            // 
            this.iD_departamentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentBindingSource, "ID_departament", true));
            this.iD_departamentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_departamentTextBox.Location = new System.Drawing.Point(214, 85);
            this.iD_departamentTextBox.Name = "iD_departamentTextBox";
            this.iD_departamentTextBox.Size = new System.Drawing.Size(132, 26);
            this.iD_departamentTextBox.TabIndex = 3;
            // 
            // name_of_departamentTextBox
            // 
            this.name_of_departamentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentBindingSource, "name of departament", true));
            this.name_of_departamentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_of_departamentTextBox.Location = new System.Drawing.Point(214, 138);
            this.name_of_departamentTextBox.Name = "name_of_departamentTextBox";
            this.name_of_departamentTextBox.Size = new System.Drawing.Size(132, 26);
            this.name_of_departamentTextBox.TabIndex = 5;
            // 
            // fIO_of_headTextBox
            // 
            this.fIO_of_headTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentBindingSource, "FIO of head", true));
            this.fIO_of_headTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fIO_of_headTextBox.Location = new System.Drawing.Point(214, 196);
            this.fIO_of_headTextBox.Name = "fIO_of_headTextBox";
            this.fIO_of_headTextBox.Size = new System.Drawing.Size(165, 26);
            this.fIO_of_headTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentBindingSource, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(190, 250);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(143, 26);
            this.phoneTextBox.TabIndex = 9;
            // 
            // number_of_teachersTextBox
            // 
            this.number_of_teachersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentBindingSource, "number of teachers", true));
            this.number_of_teachersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_teachersTextBox.Location = new System.Drawing.Point(814, 157);
            this.number_of_teachersTextBox.Name = "number_of_teachersTextBox";
            this.number_of_teachersTextBox.Size = new System.Drawing.Size(153, 26);
            this.number_of_teachersTextBox.TabIndex = 11;
            // 
            // iD_facultyListBox
            // 
            this.iD_facultyListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departamentBindingSource, "ID_faculty", true));
            this.iD_facultyListBox.DataSource = this.facultyBindingSource;
            this.iD_facultyListBox.DisplayMember = "name of faculty";
            this.iD_facultyListBox.FormattingEnabled = true;
            this.iD_facultyListBox.Location = new System.Drawing.Point(814, 83);
            this.iD_facultyListBox.Name = "iD_facultyListBox";
            this.iD_facultyListBox.Size = new System.Drawing.Size(153, 30);
            this.iD_facultyListBox.TabIndex = 13;
            this.iD_facultyListBox.ValueMember = "ID_faculty";
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "faculty";
            this.facultyBindingSource.DataSource = this.universitet_bdDataSet;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(398, 548);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 38);
            this.button7.TabIndex = 23;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(467, 470);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 46);
            this.button6.TabIndex = 22;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(350, 470);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 46);
            this.button5.TabIndex = 21;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(621, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 35);
            this.button4.TabIndex = 20;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 35);
            this.button3.TabIndex = 19;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 647);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_facultyLabel);
            this.Controls.Add(this.iD_facultyListBox);
            this.Controls.Add(number_of_teachersLabel);
            this.Controls.Add(this.number_of_teachersTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(fIO_of_headLabel);
            this.Controls.Add(this.fIO_of_headTextBox);
            this.Controls.Add(name_of_departamentLabel);
            this.Controls.Add(this.name_of_departamentTextBox);
            this.Controls.Add(iD_departamentLabel);
            this.Controls.Add(this.iD_departamentTextBox);
            this.Controls.Add(this.departamentBindingNavigator);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form3";
            this.Text = "Кафедра";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universitet_bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingNavigator)).EndInit();
            this.departamentBindingNavigator.ResumeLayout(false);
            this.departamentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private universitet_bdDataSet universitet_bdDataSet;
        private System.Windows.Forms.BindingSource departamentBindingSource;
        private universitet_bdDataSetTableAdapters.departamentTableAdapter departamentTableAdapter;
        private universitet_bdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator departamentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton departamentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_departamentTextBox;
        private universitet_bdDataSetTableAdapters.facultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.TextBox name_of_departamentTextBox;
        private System.Windows.Forms.TextBox fIO_of_headTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox number_of_teachersTextBox;
        private System.Windows.Forms.ListBox iD_facultyListBox;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}