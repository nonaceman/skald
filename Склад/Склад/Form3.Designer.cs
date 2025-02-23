namespace Склад
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
            System.Windows.Forms.Label название_фирмыLabel;
            System.Windows.Forms.Label фИО_ПроизводителяLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label почтаLabel;
            System.Windows.Forms.Label адресLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataSet1 = new Склад.DataSet1();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new Склад.DataSet1TableAdapters.ПоставщикиTableAdapter();
            this.tableAdapterManager = new Склад.DataSet1TableAdapters.TableAdapterManager();
            this.поставщикиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.поставщикиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.название_фирмыTextBox = new System.Windows.Forms.TextBox();
            this.фИО_ПроизводителяTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.почтаTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.поставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставкиTableAdapter = new Склад.DataSet1TableAdapters.ПоставкиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            название_фирмыLabel = new System.Windows.Forms.Label();
            фИО_ПроизводителяLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            почтаLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingNavigator)).BeginInit();
            this.поставщикиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // название_фирмыLabel
            // 
            название_фирмыLabel.AutoSize = true;
            название_фирмыLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            название_фирмыLabel.Location = new System.Drawing.Point(38, 37);
            название_фирмыLabel.Name = "название_фирмыLabel";
            название_фирмыLabel.Size = new System.Drawing.Size(155, 23);
            название_фирмыLabel.TabIndex = 2;
            название_фирмыLabel.Text = "Название фирмы:";
            // 
            // фИО_ПроизводителяLabel
            // 
            фИО_ПроизводителяLabel.AutoSize = true;
            фИО_ПроизводителяLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            фИО_ПроизводителяLabel.Location = new System.Drawing.Point(7, 73);
            фИО_ПроизводителяLabel.Name = "фИО_ПроизводителяLabel";
            фИО_ПроизводителяLabel.Size = new System.Drawing.Size(186, 23);
            фИО_ПроизводителяLabel.TabIndex = 4;
            фИО_ПроизводителяLabel.Text = "ФИО Производителя:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            телефонLabel.Location = new System.Drawing.Point(106, 107);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(87, 23);
            телефонLabel.TabIndex = 6;
            телефонLabel.Text = "Телефон:";
            // 
            // почтаLabel
            // 
            почтаLabel.AutoSize = true;
            почтаLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            почтаLabel.Location = new System.Drawing.Point(129, 141);
            почтаLabel.Name = "почтаLabel";
            почтаLabel.Size = new System.Drawing.Size(64, 23);
            почтаLabel.TabIndex = 8;
            почтаLabel.Text = "Почта:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            адресLabel.Location = new System.Drawing.Point(130, 175);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(63, 23);
            адресLabel.TabIndex = 9;
            адресLabel.Text = "Адрес:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.dataSet1;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Склад.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КатегорииTableAdapter = null;
            this.tableAdapterManager.Местоположение_товараTableAdapter = null;
            this.tableAdapterManager.ПоставкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = this.поставщикиTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // поставщикиBindingNavigator
            // 
            this.поставщикиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.поставщикиBindingNavigator.BindingSource = this.поставщикиBindingSource;
            this.поставщикиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поставщикиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.поставщикиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.поставщикиBindingNavigatorSaveItem});
            this.поставщикиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.поставщикиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.поставщикиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.поставщикиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.поставщикиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.поставщикиBindingNavigator.Name = "поставщикиBindingNavigator";
            this.поставщикиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.поставщикиBindingNavigator.Size = new System.Drawing.Size(363, 25);
            this.поставщикиBindingNavigator.TabIndex = 1;
            this.поставщикиBindingNavigator.Text = "bindingNavigator1";
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
            // поставщикиBindingNavigatorSaveItem
            // 
            this.поставщикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.поставщикиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поставщикиBindingNavigatorSaveItem.Image")));
            this.поставщикиBindingNavigatorSaveItem.Name = "поставщикиBindingNavigatorSaveItem";
            this.поставщикиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.поставщикиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.поставщикиBindingNavigatorSaveItem.Click += new System.EventHandler(this.поставщикиBindingNavigatorSaveItem_Click);
            // 
            // название_фирмыTextBox
            // 
            this.название_фирмыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Название фирмы", true));
            this.название_фирмыTextBox.Location = new System.Drawing.Point(199, 41);
            this.название_фирмыTextBox.Name = "название_фирмыTextBox";
            this.название_фирмыTextBox.Size = new System.Drawing.Size(150, 20);
            this.название_фирмыTextBox.TabIndex = 3;
            // 
            // фИО_ПроизводителяTextBox
            // 
            this.фИО_ПроизводителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "ФИО Производителя", true));
            this.фИО_ПроизводителяTextBox.Location = new System.Drawing.Point(199, 77);
            this.фИО_ПроизводителяTextBox.Name = "фИО_ПроизводителяTextBox";
            this.фИО_ПроизводителяTextBox.Size = new System.Drawing.Size(150, 20);
            this.фИО_ПроизводителяTextBox.TabIndex = 5;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(199, 110);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(150, 20);
            this.телефонTextBox.TabIndex = 7;
            // 
            // почтаTextBox
            // 
            this.почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Почта", true));
            this.почтаTextBox.Location = new System.Drawing.Point(199, 145);
            this.почтаTextBox.Name = "почтаTextBox";
            this.почтаTextBox.Size = new System.Drawing.Size(150, 20);
            this.почтаTextBox.TabIndex = 9;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(199, 178);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(150, 20);
            this.адресTextBox.TabIndex = 10;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Поставщик: товар и дата поставки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(363, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(почтаLabel);
            this.Controls.Add(this.почтаTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(фИО_ПроизводителяLabel);
            this.Controls.Add(this.фИО_ПроизводителяTextBox);
            this.Controls.Add(название_фирмыLabel);
            this.Controls.Add(this.название_фирмыTextBox);
            this.Controls.Add(this.поставщикиBindingNavigator);
            this.Name = "Form3";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingNavigator)).EndInit();
            this.поставщикиBindingNavigator.ResumeLayout(false);
            this.поставщикиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private DataSet1TableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator поставщикиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton поставщикиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox название_фирмыTextBox;
        private System.Windows.Forms.TextBox фИО_ПроизводителяTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox почтаTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.BindingSource поставкиBindingSource;
        private DataSet1TableAdapters.ПоставкиTableAdapter поставкиTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}