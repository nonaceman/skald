namespace Склад
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
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label количество_товара__шт_Label;
            System.Windows.Forms.Label название_фирмыLabel;
            System.Windows.Forms.Label iD_СотрудникаLabel;
            System.Windows.Forms.Label ___ПоставщикаLabel;
            System.Windows.Forms.Label iD_ПоставщикаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataSet1 = new Склад.DataSet1();
            this.поставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставкиTableAdapter = new Склад.DataSet1TableAdapters.ПоставкиTableAdapter();
            this.tableAdapterManager = new Склад.DataSet1TableAdapters.TableAdapterManager();
            this.поставкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.поставкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.датаTextBox = new System.Windows.Forms.TextBox();
            this.количество_товара__шт_TextBox = new System.Windows.Forms.TextBox();
            this.название_фирмыTextBox = new System.Windows.Forms.TextBox();
            this.iD_СотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.___ПоставщикаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iD_ПоставщикаTextBox = new System.Windows.Forms.TextBox();
            датаLabel = new System.Windows.Forms.Label();
            количество_товара__шт_Label = new System.Windows.Forms.Label();
            название_фирмыLabel = new System.Windows.Forms.Label();
            iD_СотрудникаLabel = new System.Windows.Forms.Label();
            ___ПоставщикаLabel = new System.Windows.Forms.Label();
            iD_ПоставщикаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingNavigator)).BeginInit();
            this.поставкиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            датаLabel.Location = new System.Drawing.Point(182, 178);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(55, 23);
            датаLabel.TabIndex = 2;
            датаLabel.Text = "Дата:";
            // 
            // количество_товара__шт_Label
            // 
            количество_товара__шт_Label.AutoSize = true;
            количество_товара__шт_Label.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            количество_товара__шт_Label.Location = new System.Drawing.Point(23, 37);
            количество_товара__шт_Label.Name = "количество_товара__шт_Label";
            количество_товара__шт_Label.Size = new System.Drawing.Size(214, 23);
            количество_товара__шт_Label.TabIndex = 4;
            количество_товара__шт_Label.Text = "Количество товара, шт :";
            количество_товара__шт_Label.Click += new System.EventHandler(this.количество_товара__шт_Label_Click);
            // 
            // название_фирмыLabel
            // 
            название_фирмыLabel.AutoSize = true;
            название_фирмыLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            название_фирмыLabel.Location = new System.Drawing.Point(82, 107);
            название_фирмыLabel.Name = "название_фирмыLabel";
            название_фирмыLabel.Size = new System.Drawing.Size(155, 23);
            название_фирмыLabel.TabIndex = 6;
            название_фирмыLabel.Text = "Название фирмы:";
            // 
            // iD_СотрудникаLabel
            // 
            iD_СотрудникаLabel.AutoSize = true;
            iD_СотрудникаLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_СотрудникаLabel.Location = new System.Drawing.Point(95, 142);
            iD_СотрудникаLabel.Name = "iD_СотрудникаLabel";
            iD_СотрудникаLabel.Size = new System.Drawing.Size(142, 23);
            iD_СотрудникаLabel.TabIndex = 8;
            iD_СотрудникаLabel.Text = "ID Сотрудника:";
            iD_СотрудникаLabel.Click += new System.EventHandler(this.iD_СотрудникаLabel_Click);
            // 
            // ___ПоставщикаLabel
            // 
            ___ПоставщикаLabel.AutoSize = true;
            ___ПоставщикаLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ___ПоставщикаLabel.Location = new System.Drawing.Point(99, 72);
            ___ПоставщикаLabel.Name = "___ПоставщикаLabel";
            ___ПоставщикаLabel.Size = new System.Drawing.Size(138, 23);
            ___ПоставщикаLabel.TabIndex = 9;
            ___ПоставщикаLabel.Text = "№ Поставщика:";
            // 
            // iD_ПоставщикаLabel
            // 
            iD_ПоставщикаLabel.AutoSize = true;
            iD_ПоставщикаLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_ПоставщикаLabel.Location = new System.Drawing.Point(92, 212);
            iD_ПоставщикаLabel.Name = "iD_ПоставщикаLabel";
            iD_ПоставщикаLabel.Size = new System.Drawing.Size(145, 23);
            iD_ПоставщикаLabel.TabIndex = 15;
            iD_ПоставщикаLabel.Text = "ID Поставщика:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставкиBindingSource
            // 
            this.поставкиBindingSource.DataMember = "Поставки";
            this.поставкиBindingSource.DataSource = this.dataSet1;
            // 
            // поставкиTableAdapter
            // 
            this.поставкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Склад.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КатегорииTableAdapter = null;
            this.tableAdapterManager.Местоположение_товараTableAdapter = null;
            this.tableAdapterManager.ПоставкиTableAdapter = this.поставкиTableAdapter;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // поставкиBindingNavigator
            // 
            this.поставкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.поставкиBindingNavigator.BindingSource = this.поставкиBindingSource;
            this.поставкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поставкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.поставкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.поставкиBindingNavigatorSaveItem});
            this.поставкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.поставкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.поставкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.поставкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.поставкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.поставкиBindingNavigator.Name = "поставкиBindingNavigator";
            this.поставкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.поставкиBindingNavigator.Size = new System.Drawing.Size(374, 25);
            this.поставкиBindingNavigator.TabIndex = 1;
            this.поставкиBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // поставкиBindingNavigatorSaveItem
            // 
            this.поставкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.поставкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поставкиBindingNavigatorSaveItem.Image")));
            this.поставкиBindingNavigatorSaveItem.Name = "поставкиBindingNavigatorSaveItem";
            this.поставкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.поставкиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.поставкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.поставкиBindingNavigatorSaveItem_Click);
            // 
            // датаTextBox
            // 
            this.датаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставкиBindingSource, "Дата", true));
            this.датаTextBox.Location = new System.Drawing.Point(243, 182);
            this.датаTextBox.Name = "датаTextBox";
            this.датаTextBox.Size = new System.Drawing.Size(117, 20);
            this.датаTextBox.TabIndex = 3;
            // 
            // количество_товара__шт_TextBox
            // 
            this.количество_товара__шт_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставкиBindingSource, "Количество товара, шт_", true));
            this.количество_товара__шт_TextBox.Location = new System.Drawing.Point(243, 37);
            this.количество_товара__шт_TextBox.Name = "количество_товара__шт_TextBox";
            this.количество_товара__шт_TextBox.Size = new System.Drawing.Size(117, 20);
            this.количество_товара__шт_TextBox.TabIndex = 5;
            this.количество_товара__шт_TextBox.TextChanged += new System.EventHandler(this.количество_товара__шт_TextBox_TextChanged);
            // 
            // название_фирмыTextBox
            // 
            this.название_фирмыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставкиBindingSource, "Название фирмы", true));
            this.название_фирмыTextBox.Location = new System.Drawing.Point(243, 111);
            this.название_фирмыTextBox.Name = "название_фирмыTextBox";
            this.название_фирмыTextBox.Size = new System.Drawing.Size(117, 20);
            this.название_фирмыTextBox.TabIndex = 7;
            // 
            // iD_СотрудникаTextBox
            // 
            this.iD_СотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставкиBindingSource, "ID Сотрудника", true));
            this.iD_СотрудникаTextBox.Location = new System.Drawing.Point(243, 145);
            this.iD_СотрудникаTextBox.Name = "iD_СотрудникаTextBox";
            this.iD_СотрудникаTextBox.Size = new System.Drawing.Size(117, 20);
            this.iD_СотрудникаTextBox.TabIndex = 9;
            // 
            // ___ПоставщикаTextBox
            // 
            this.___ПоставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставкиBindingSource, "№ Поставщика", true));
            this.___ПоставщикаTextBox.Location = new System.Drawing.Point(243, 76);
            this.___ПоставщикаTextBox.Name = "___ПоставщикаTextBox";
            this.___ПоставщикаTextBox.Size = new System.Drawing.Size(117, 20);
            this.___ПоставщикаTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Поставки на сегодня";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Приемка поставок";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iD_ПоставщикаTextBox
            // 
            this.iD_ПоставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставкиBindingSource, "ID Поставщика", true));
            this.iD_ПоставщикаTextBox.Location = new System.Drawing.Point(243, 216);
            this.iD_ПоставщикаTextBox.Name = "iD_ПоставщикаTextBox";
            this.iD_ПоставщикаTextBox.Size = new System.Drawing.Size(117, 20);
            this.iD_ПоставщикаTextBox.TabIndex = 16;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(374, 355);
            this.Controls.Add(iD_ПоставщикаLabel);
            this.Controls.Add(this.iD_ПоставщикаTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(___ПоставщикаLabel);
            this.Controls.Add(this.___ПоставщикаTextBox);
            this.Controls.Add(iD_СотрудникаLabel);
            this.Controls.Add(this.iD_СотрудникаTextBox);
            this.Controls.Add(название_фирмыLabel);
            this.Controls.Add(this.название_фирмыTextBox);
            this.Controls.Add(количество_товара__шт_Label);
            this.Controls.Add(this.количество_товара__шт_TextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаTextBox);
            this.Controls.Add(this.поставкиBindingNavigator);
            this.Name = "Form4";
            this.Text = "Поставки";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingNavigator)).EndInit();
            this.поставкиBindingNavigator.ResumeLayout(false);
            this.поставкиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource поставкиBindingSource;
        private DataSet1TableAdapters.ПоставкиTableAdapter поставкиTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator поставкиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton поставкиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox датаTextBox;
        private System.Windows.Forms.TextBox количество_товара__шт_TextBox;
        private System.Windows.Forms.TextBox название_фирмыTextBox;
        private System.Windows.Forms.TextBox iD_СотрудникаTextBox;
        private System.Windows.Forms.TextBox ___ПоставщикаTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox iD_ПоставщикаTextBox;
    }
}