namespace Склад
{
    partial class Form8
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
            System.Windows.Forms.Label ___СтелажаLabel;
            System.Windows.Forms.Label холоднй_цехLabel;
            System.Windows.Forms.Label ___ПолкиLabel;
            System.Windows.Forms.Label категорияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.dataSet1 = new Склад.DataSet1();
            this.местоположение_товараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.местоположение_товараTableAdapter = new Склад.DataSet1TableAdapters.Местоположение_товараTableAdapter();
            this.tableAdapterManager = new Склад.DataSet1TableAdapters.TableAdapterManager();
            this.местоположение_товараBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.местоположение_товараBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наименование_товараTextBox = new System.Windows.Forms.TextBox();
            this.___СтелажаTextBox = new System.Windows.Forms.TextBox();
            this.холоднй_цехTextBox = new System.Windows.Forms.TextBox();
            this.___ПолкиTextBox = new System.Windows.Forms.TextBox();
            this.категорияTextBox = new System.Windows.Forms.TextBox();
            наименование_товараLabel = new System.Windows.Forms.Label();
            ___СтелажаLabel = new System.Windows.Forms.Label();
            холоднй_цехLabel = new System.Windows.Forms.Label();
            ___ПолкиLabel = new System.Windows.Forms.Label();
            категорияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоположение_товараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоположение_товараBindingNavigator)).BeginInit();
            this.местоположение_товараBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // наименование_товараLabel
            // 
            наименование_товараLabel.AutoSize = true;
            наименование_товараLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            наименование_товараLabel.Location = new System.Drawing.Point(15, 36);
            наименование_товараLabel.Name = "наименование_товараLabel";
            наименование_товараLabel.Size = new System.Drawing.Size(193, 23);
            наименование_товараLabel.TabIndex = 2;
            наименование_товараLabel.Text = "Наименование товара:";
            // 
            // ___СтелажаLabel
            // 
            ___СтелажаLabel.AutoSize = true;
            ___СтелажаLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ___СтелажаLabel.Location = new System.Drawing.Point(97, 103);
            ___СтелажаLabel.Name = "___СтелажаLabel";
            ___СтелажаLabel.Size = new System.Drawing.Size(111, 23);
            ___СтелажаLabel.TabIndex = 4;
            ___СтелажаLabel.Text = "№ Стелажа:";
            // 
            // холоднй_цехLabel
            // 
            холоднй_цехLabel.AutoSize = true;
            холоднй_цехLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            холоднй_цехLabel.Location = new System.Drawing.Point(89, 167);
            холоднй_цехLabel.Name = "холоднй_цехLabel";
            холоднй_цехLabel.Size = new System.Drawing.Size(119, 23);
            холоднй_цехLabel.TabIndex = 6;
            холоднй_цехLabel.Text = "Холоднй цех:";
            // 
            // ___ПолкиLabel
            // 
            ___ПолкиLabel.AutoSize = true;
            ___ПолкиLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ___ПолкиLabel.Location = new System.Drawing.Point(116, 135);
            ___ПолкиLabel.Name = "___ПолкиLabel";
            ___ПолкиLabel.Size = new System.Drawing.Size(92, 23);
            ___ПолкиLabel.TabIndex = 8;
            ___ПолкиLabel.Text = "№ Полки:";
            // 
            // категорияLabel
            // 
            категорияLabel.AutoSize = true;
            категорияLabel.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            категорияLabel.Location = new System.Drawing.Point(111, 69);
            категорияLabel.Name = "категорияLabel";
            категорияLabel.Size = new System.Drawing.Size(97, 23);
            категорияLabel.TabIndex = 9;
            категорияLabel.Text = "Категория:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // местоположение_товараBindingSource
            // 
            this.местоположение_товараBindingSource.DataMember = "Местоположение товара";
            this.местоположение_товараBindingSource.DataSource = this.dataSet1;
            // 
            // местоположение_товараTableAdapter
            // 
            this.местоположение_товараTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Склад.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КатегорииTableAdapter = null;
            this.tableAdapterManager.Местоположение_товараTableAdapter = this.местоположение_товараTableAdapter;
            this.tableAdapterManager.ПоставкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // местоположение_товараBindingNavigator
            // 
            this.местоположение_товараBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.местоположение_товараBindingNavigator.BindingSource = this.местоположение_товараBindingSource;
            this.местоположение_товараBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.местоположение_товараBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.местоположение_товараBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.местоположение_товараBindingNavigatorSaveItem});
            this.местоположение_товараBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.местоположение_товараBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.местоположение_товараBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.местоположение_товараBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.местоположение_товараBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.местоположение_товараBindingNavigator.Name = "местоположение_товараBindingNavigator";
            this.местоположение_товараBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.местоположение_товараBindingNavigator.Size = new System.Drawing.Size(398, 25);
            this.местоположение_товараBindingNavigator.TabIndex = 1;
            this.местоположение_товараBindingNavigator.Text = "bindingNavigator1";
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
            // местоположение_товараBindingNavigatorSaveItem
            // 
            this.местоположение_товараBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.местоположение_товараBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("местоположение_товараBindingNavigatorSaveItem.Image")));
            this.местоположение_товараBindingNavigatorSaveItem.Name = "местоположение_товараBindingNavigatorSaveItem";
            this.местоположение_товараBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.местоположение_товараBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.местоположение_товараBindingNavigatorSaveItem.Click += new System.EventHandler(this.местоположение_товараBindingNavigatorSaveItem_Click);
            // 
            // наименование_товараTextBox
            // 
            this.наименование_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.местоположение_товараBindingSource, "Наименование товара", true));
            this.наименование_товараTextBox.Location = new System.Drawing.Point(214, 39);
            this.наименование_товараTextBox.Name = "наименование_товараTextBox";
            this.наименование_товараTextBox.Size = new System.Drawing.Size(160, 20);
            this.наименование_товараTextBox.TabIndex = 3;
            // 
            // ___СтелажаTextBox
            // 
            this.___СтелажаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.местоположение_товараBindingSource, "№ Стелажа", true));
            this.___СтелажаTextBox.Location = new System.Drawing.Point(214, 106);
            this.___СтелажаTextBox.Name = "___СтелажаTextBox";
            this.___СтелажаTextBox.Size = new System.Drawing.Size(160, 20);
            this.___СтелажаTextBox.TabIndex = 5;
            // 
            // холоднй_цехTextBox
            // 
            this.холоднй_цехTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.местоположение_товараBindingSource, "Холоднй цех", true));
            this.холоднй_цехTextBox.Location = new System.Drawing.Point(214, 170);
            this.холоднй_цехTextBox.Name = "холоднй_цехTextBox";
            this.холоднй_цехTextBox.Size = new System.Drawing.Size(160, 20);
            this.холоднй_цехTextBox.TabIndex = 7;
            // 
            // ___ПолкиTextBox
            // 
            this.___ПолкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.местоположение_товараBindingSource, "№ Полки", true));
            this.___ПолкиTextBox.Location = new System.Drawing.Point(214, 138);
            this.___ПолкиTextBox.Name = "___ПолкиTextBox";
            this.___ПолкиTextBox.Size = new System.Drawing.Size(160, 20);
            this.___ПолкиTextBox.TabIndex = 9;
            // 
            // категорияTextBox
            // 
            this.категорияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.местоположение_товараBindingSource, "Категория", true));
            this.категорияTextBox.Location = new System.Drawing.Point(214, 73);
            this.категорияTextBox.Name = "категорияTextBox";
            this.категорияTextBox.Size = new System.Drawing.Size(160, 20);
            this.категорияTextBox.TabIndex = 10;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(398, 202);
            this.Controls.Add(категорияLabel);
            this.Controls.Add(this.категорияTextBox);
            this.Controls.Add(___ПолкиLabel);
            this.Controls.Add(this.___ПолкиTextBox);
            this.Controls.Add(холоднй_цехLabel);
            this.Controls.Add(this.холоднй_цехTextBox);
            this.Controls.Add(___СтелажаLabel);
            this.Controls.Add(this.___СтелажаTextBox);
            this.Controls.Add(наименование_товараLabel);
            this.Controls.Add(this.наименование_товараTextBox);
            this.Controls.Add(this.местоположение_товараBindingNavigator);
            this.Name = "Form8";
            this.Text = "Местоположение товара";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоположение_товараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.местоположение_товараBindingNavigator)).EndInit();
            this.местоположение_товараBindingNavigator.ResumeLayout(false);
            this.местоположение_товараBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource местоположение_товараBindingSource;
        private DataSet1TableAdapters.Местоположение_товараTableAdapter местоположение_товараTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator местоположение_товараBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton местоположение_товараBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox наименование_товараTextBox;
        private System.Windows.Forms.TextBox ___СтелажаTextBox;
        private System.Windows.Forms.TextBox холоднй_цехTextBox;
        private System.Windows.Forms.TextBox ___ПолкиTextBox;
        private System.Windows.Forms.TextBox категорияTextBox;
    }
}