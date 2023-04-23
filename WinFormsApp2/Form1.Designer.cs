namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewProducts = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            productBindingSource3 = new BindingSource(components);
            buttonUpdate = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            menuStrip1 = new MenuStrip();
            Menu = new ToolStripMenuItem();
            SaveData = new ToolStripMenuItem();
            LoadData = new ToolStripMenuItem();
            buttonShowGreet = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxCategory = new TextBox();
            textBoxCount = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource3).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, Count, Category });
            dataGridViewProducts.DataSource = productBindingSource3;
            dataGridViewProducts.Location = new Point(12, 31);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(776, 188);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellClick += dataGridViewProduct_CellClick;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Count
            // 
            Count.DataPropertyName = "Count";
            Count.HeaderText = "Count";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.ReadOnly = true;
            Count.Width = 125;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 125;
            // 
            // productBindingSource3
            // 
            productBindingSource3.DataSource = typeof(Product);
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(12, 225);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(130, 47);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += button1_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 278);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(130, 47);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button2_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(12, 331);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(130, 47);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += button3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menu, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            Menu.DropDownItems.AddRange(new ToolStripItem[] { SaveData, LoadData, buttonShowGreet });
            Menu.Name = "Menu";
            Menu.Size = new Size(65, 24);
            Menu.Text = "Меню";
            // 
            // SaveData
            // 
            SaveData.Name = "SaveData";
            SaveData.Size = new Size(284, 26);
            SaveData.Text = "Сохранение данных в файл";
            SaveData.Click += toolStripButton1_Click;
            // 
            // LoadData
            // 
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(284, 26);
            LoadData.Text = "Загрузка данных из файла";
            LoadData.Click += toolStripButton2_Click;
            // 
            // buttonShowGreet
            // 
            buttonShowGreet.Name = "buttonShowGreet";
            buttonShowGreet.Size = new Size(284, 26);
            buttonShowGreet.Text = "Показывать приветствие";
            buttonShowGreet.Click += ShowGreetings;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(67, 24);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 238);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 5;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 278);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 6;
            label2.Text = "Категория";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 322);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 7;
            label3.Text = "Количество";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(340, 235);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 8;
            textBoxName.KeyUp += textBox1_KeyUp;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(340, 278);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(125, 27);
            textBoxCategory.TabIndex = 9;
            textBoxCategory.KeyUp += textBox2_KeyUp;
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(340, 319);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(125, 27);
            textBoxCount.TabIndex = 10;
            textBoxCount.KeyUp += textBox3_KeyUp;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCount);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonUpdate);
            Controls.Add(dataGridViewProducts);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Button buttonUpdate;
        private Button buttonAdd;
        private Button buttonDelete;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menu;
        private ToolStripMenuItem SaveData;
        private ToolStripMenuItem LoadData;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxCategory;
        private TextBox textBoxCount;
        private BindingSource productBindingSource3;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Category;
        private ToolStripMenuItem buttonShowGreet;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}