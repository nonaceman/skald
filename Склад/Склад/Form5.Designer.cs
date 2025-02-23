namespace Склад
{
    partial class Form5
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
            System.Windows.Forms.Label наименование_товараLabel;
            System.Windows.Forms.Label количество__шт_Label;
            System.Windows.Forms.Label срок_храненияLabel;
            System.Windows.Forms.Label ___ПоставкиLabel;
            System.Windows.Forms.Label категорияLabel;
            System.Windows.Forms.Label цена__руб_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataSet1 = new Склад.DataSet1();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new Склад.DataSet1TableAdapters.ТоварыTableAdapter();
            this.tableAdapterManager = new Склад.DataSet1TableAdapters.TableAdapterManager();
            this.товарыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.товарыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наименование_товараTextBox = new System.Windows.Forms.TextBox();
            this.количество__шт_TextBox = new System.Windows.Forms.TextBox();
            this.срок_храненияTextBox = new System.Windows.Forms.TextBox();
            this.___ПоставкиTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.категорияTextBox = new System.Windows.Forms.TextBox();
            this.цена__руб_TextBox = new System.Windows.Forms.TextBox();
            наименование_товараLabel = new System.Windows.Forms.Label();
            количество__шт_Label = new System.Windows.Forms.Label();
            срок_храненияLabel = new System.Windows.Forms.Label();
            ___ПоставкиLabel = new System.Windows.Forms.Label();
            категорияLabel = new System.Windows.Forms.Label();
            цена__руб_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingNavigator)).BeginInit();
            this.товарыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // наименование_товараLabel
            // 
            наименование_товараLabel.AutoSize = true;
            наименование_товараLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            наименование_товараLabel.Location = new System.Drawing.Point(12, 38);
            наименование_товараLabel.Name = "наименование_товараLabel";
            наименование_товараLabel.Size = new System.Drawing.Size(193, 23);
            наименование_товараLabel.TabIndex = 2;
            наименование_товараLabel.Text = "Наименование товара:";
            // 
            // количество__шт_Label
            // 
            количество__шт_Label.AutoSize = true;
            количество__шт_Label.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            количество__шт_Label.Location = new System.Drawing.Point(53, 105);
            количество__шт_Label.Name = "количество__шт_Label";
            количество__шт_Label.Size = new System.Drawing.Size(152, 23);
            количество__шт_Label.TabIndex = 4;
            количество__шт_Label.Text = "Количество, шт :";
            // 
            // срок_храненияLabel
            // 
            срок_храненияLabel.AutoSize = true;
            срок_храненияLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            срок_храненияLabel.Location = new System.Drawing.Point(70, 141);
            срок_храненияLabel.Name = "срок_храненияLabel";
            срок_храненияLabel.Size = new System.Drawing.Size(135, 23);
            срок_храненияLabel.TabIndex = 6;
            срок_храненияLabel.Text = "Срок хранения:";
            // 
            // ___ПоставкиLabel
            // 
            ___ПоставкиLabel.AutoSize = true;
            ___ПоставкиLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ___ПоставкиLabel.Location = new System.Drawing.Point(88, 177);
            ___ПоставкиLabel.Name = "___ПоставкиLabel";
            ___ПоставкиLabel.Size = new System.Drawing.Size(117, 23);
            ___ПоставкиLabel.TabIndex = 8;
            ___ПоставкиLabel.Text = "№ Поставки:";
            // 
            // категорияLabel
            // 
            категорияLabel.AutoSize = true;
            категорияLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            категорияLabel.Location = new System.Drawing.Point(108, 70);
            категорияLabel.Name = "категорияLabel";
            категорияLabel.Size = new System.Drawing.Size(97, 23);
            категорияLabel.TabIndex = 10;
            категорияLabel.Text = "Категория:";
            // 
            // цена__руб_Label
            // 
            цена__руб_Label.AutoSize = true;
            цена__руб_Label.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            цена__руб_Label.Location = new System.Drawing.Point(101, 211);
            цена__руб_Label.Name = "цена__руб_Label";
            цена__руб_Label.Size = new System.Drawing.Size(104, 23);
            цена__руб_Label.TabIndex = 12;
            цена__руб_Label.Text = "Цена, руб :";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.dataSet1;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Склад.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КатегорииTableAdapter = null;
            this.tableAdapterManager.Местоположение_товараTableAdapter = null;
            this.tableAdapterManager.ПоставкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = this.товарыTableAdapter;
            // 
            // товарыBindingNavigator
            // 
            this.товарыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.товарыBindingNavigator.BindingSource = this.товарыBindingSource;
            this.товарыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.товарыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.товарыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.товарыBindingNavigatorSaveItem});
            this.товарыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.товарыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.товарыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.товарыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.товарыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.товарыBindingNavigator.Name = "товарыBindingNavigator";
            this.товарыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.товарыBindingNavigator.Size = new System.Drawing.Size(380, 25);
            this.товарыBindingNavigator.TabIndex = 1;
            this.товарыBindingNavigator.Text = "bindingNavigator1";
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
            // товарыBindingNavigatorSaveItem
            // 
            this.товарыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.товарыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("товарыBindingNavigatorSaveItem.Image")));
            this.товарыBindingNavigatorSaveItem.Name = "товарыBindingNavigatorSaveItem";
            this.товарыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.товарыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.товарыBindingNavigatorSaveItem.Click += new System.EventHandler(this.товарыBindingNavigatorSaveItem_Click);
            // 
            // наименование_товараTextBox
            // 
            this.наименование_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Наименование товара", true));
            this.наименование_товараTextBox.Location = new System.Drawing.Point(211, 41);
            this.наименование_товараTextBox.Name = "наименование_товараTextBox";
            this.наименование_товараTextBox.Size = new System.Drawing.Size(149, 20);
            this.наименование_товараTextBox.TabIndex = 3;
            // 
            // количество__шт_TextBox
            // 
            this.количество__шт_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Количество, шт_", true));
            this.количество__шт_TextBox.Location = new System.Drawing.Point(211, 109);
            this.количество__шт_TextBox.Name = "количество__шт_TextBox";
            this.количество__шт_TextBox.Size = new System.Drawing.Size(149, 20);
            this.количество__шт_TextBox.TabIndex = 5;
            // 
            // срок_храненияTextBox
            // 
            this.срок_храненияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Срок хранения", true));
            this.срок_храненияTextBox.Location = new System.Drawing.Point(211, 145);
            this.срок_храненияTextBox.Name = "срок_храненияTextBox";
            this.срок_храненияTextBox.Size = new System.Drawing.Size(149, 20);
            this.срок_храненияTextBox.TabIndex = 7;
            // 
            // ___ПоставкиTextBox
            // 
            this.___ПоставкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "№ Поставки", true));
            this.___ПоставкиTextBox.Location = new System.Drawing.Point(211, 181);
            this.___ПоставкиTextBox.Name = "___ПоставкиTextBox";
            this.___ПоставкиTextBox.Size = new System.Drawing.Size(149, 20);
            this.___ПоставкиTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Товары: кол-во и место";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // категорияTextBox
            // 
            this.категорияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Категория", true));
            this.категорияTextBox.Location = new System.Drawing.Point(211, 74);
            this.категорияTextBox.Name = "категорияTextBox";
            this.категорияTextBox.Size = new System.Drawing.Size(149, 20);
            this.категорияTextBox.TabIndex = 11;
            // 
            // цена__руб_TextBox
            // 
            this.цена__руб_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Цена, руб_", true));
            this.цена__руб_TextBox.Location = new System.Drawing.Point(211, 214);
            this.цена__руб_TextBox.Name = "цена__руб_TextBox";
            this.цена__руб_TextBox.Size = new System.Drawing.Size(149, 20);
            this.цена__руб_TextBox.TabIndex = 13;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(380, 285);
            this.Controls.Add(цена__руб_Label);
            this.Controls.Add(this.цена__руб_TextBox);
            this.Controls.Add(категорияLabel);
            this.Controls.Add(this.категорияTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(___ПоставкиLabel);
            this.Controls.Add(this.___ПоставкиTextBox);
            this.Controls.Add(срок_храненияLabel);
            this.Controls.Add(this.срок_храненияTextBox);
            this.Controls.Add(количество__шт_Label);
            this.Controls.Add(this.количество__шт_TextBox);
            this.Controls.Add(наименование_товараLabel);
            this.Controls.Add(this.наименование_товараTextBox);
            this.Controls.Add(this.товарыBindingNavigator);
            this.Name = "Form5";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingNavigator)).EndInit();
            this.товарыBindingNavigator.ResumeLayout(false);
            this.товарыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private DataSet1TableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator товарыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton товарыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox наименование_товараTextBox;
        private System.Windows.Forms.TextBox количество__шт_TextBox;
        private System.Windows.Forms.TextBox срок_храненияTextBox;
        private System.Windows.Forms.TextBox ___ПоставкиTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox категорияTextBox;
        private System.Windows.Forms.TextBox цена__руб_TextBox;
    }
}